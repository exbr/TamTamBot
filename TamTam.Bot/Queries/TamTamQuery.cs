using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;
using ExLib.TamTam.Bot.Exceptions;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Queries
{
    public class TamTamQuery<T> : ITamTamQuery, ITamTamQuery<T> where T : class
    {
        private readonly TamTamClient _tamTamClient;
        private readonly string _url;
        private readonly object _body;
        private readonly Method _method;
        private List<IQueryParam> _parameters;

        public TamTamQuery(TamTamClient tamTamClient, string url) : this(tamTamClient, url, null, Method.POST)
        {
            
        }

        public TamTamQuery(TamTamClient tamTamClient, string url, Method method) : this(tamTamClient, url, null, method)
        {

        }

        public TamTamQuery(TamTamClient tamTamClient, string url, object body, Method method)
        {
            _tamTamClient = tamTamClient;
            _url = url;
            _body = body;
            _method = method;
        }

        //public TamTamQuery(TamTamClient tamTamClient, String url, Object body,  Method method)
        //{
        //    this.tamTamClient = tamTamClient;
        //    this.url = url;
        //    this.body = body;
        //    this.method = method;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ClientException"></exception>
        public virtual async Task<T> Execute(CancellationToken cancellationToken = default)
        {
            //try
            //{
            var response = await Call(cancellationToken);
            return Deserialize(response);
            //}
            //catch (InterruptedException e)
            //{
            //    throw new ClientException("Current request was interrupted", e);
            //}
            //catch (ExecutionException e)
            //{
            //    throw new ClientException("Request " + url + " failed", e.getCause());
            //}
        }

        //public Task<T> enqueue()
        //{
        //    return call();
        //}

        public void AddParam(IQueryParam param)
        {
            if (_parameters == null)
            {
                _parameters = new List<IQueryParam>();
            }

            _parameters.Add(param);
        }

        Task ITamTamQuery.Execute(CancellationToken cancellationToken)
        {
            return Execute(cancellationToken);
        }

        protected Task<ClientResponse> Call(CancellationToken cancellationToken)
        {
            var url = BuildUrl();
            var requestBody = JsonConvert.SerializeObject(_body);
            var transport = _tamTamClient.Transport;

            try
            {
                switch (_method)
                {
                    case Method.GET:
                        return transport.Get(url, cancellationToken);
                    case Method.POST:
                        return transport.Post(url, requestBody, cancellationToken);
                    case Method.PUT:
                        return transport.Put(url, requestBody, cancellationToken);
                    case Method.DELETE:
                        return transport.Delete(url, cancellationToken);
                    case Method.PATCH:
                        return transport.Patch(url, requestBody, cancellationToken);
                    default:
                        throw new ClientException(HttpStatusCode.BadRequest, "Method " + _method + " is not supported.");
                }
            }
            catch (TransportClientException e)
            {
                throw new ClientException("Error query executing ", e);
            }
        }

        //private static string Substitute(string pathTemplate, params object[] substitutions)
        //{
        //    //StringBuilder sb = new StringBuilder();
        //    //int nextSubst = 0;
        //    //var chars = pathTemplate;
        //    //for (int i = 0; i < chars.Length; i++)
        //    //{
        //    //    char c = chars[i];
        //    //    if (c == '{')
        //    //    {
        //    //        i = pathTemplate.IndexOf('}', i);
        //    //        sb.Append(substitutions[nextSubst++]);
        //    //        continue;
        //    //    }

        //    //    sb.Append(c);
        //    //}

        //    return string.Format(pathTemplate, substitutions);
        //}

        public static T Deserialize(ClientResponse response)
        {
            var responseBody = response.BodyAsString;
            if (response.StatusCode == HttpStatusCode.ServiceUnavailable)
            {
                throw new ServiceNotAvailableException(responseBody);
            }

            if (((int)response.StatusCode) / 100 != 2)
            {
                try
                {
                    var error = JsonConvert.DeserializeObject<Error>(responseBody);
                    if (error == null)
                    {
                        throw new APIException(response.StatusCode);
                    }

                    throw APIException.Map(response.StatusCode, error);
                }
                catch (JsonSerializationException)
                {
                    throw new APIException(response.StatusCode, responseBody);
                }
            }

            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        private string BuildUrl()
        {
            var sb = new StringBuilder(_url);
            if (!_url.StartsWith("http"))
            {
                sb.Insert(0, _tamTamClient.Endpoint);
            }

            sb.Append(_url.IndexOf('?') == -1 ? '?' : '&');

            sb.Append("access_token=").Append(_tamTamClient.AccessToken);
            sb.Append('&');
            sb.Append("v=").Append(Version.Get());

            if (_parameters == null)
            {
                return sb.ToString();
            }

            foreach (var param in _parameters)
            {
                var name = param.Name;
                if (!param.IsSetValue)
                {
                    if (param.IsRequired)
                    {
                        throw new RequiredParameterMissingException("Required param " + name + " is missing.");
                    }

                    continue;
                }

                sb.Append('&');
                sb.Append(name);
                sb.Append('=');
                try
                {
                    sb.Append(EncodeParam(param.ValueString));
                }
                catch (UriFormatException e)
                {
                    throw new ClientException("UriFormatException", e);
                }
            }

            return sb.ToString();
        }

        protected string EncodeParam(string paramValue)
        {

            return Uri.EscapeUriString(paramValue);
        }

        //protected enum Method
        //{
        //    GET, POST, PUT, HEAD, DELETE, PATCH, OPTIONS
        //}

        //    private class FutureResult<TM> //: Task<TM>
        //    {
        //        private Task<TM> _task;

        //        public FutureResult(Task<TM> task)
        //        {
        //            this._task = task;
        //        }

        //        public bool cancel(bool mayInterruptIfRunning)
        //        {
        //            return _task.Cancel(mayInterruptIfRunning);
        //        }

        //        public boolean isCancelled()
        //        {
        //            return delegate.isCancelled();
        //        }

        //        public boolean isDone()
        //        {
        //            return delegate.isDone();
        //        }

        //        public T get()
        //        {
        //            try
        //            {
        //                return deserialize(delegate.get());
        //            }
        //            catch (ClientException | APIException e) {
        //                throw new ExecutionException(e);
        //            } catch (ExecutionException e)
        //            {
        //                throw unwrap(e);
        //            }
        //        }

        //        public T get(long timeout, TimeUnit unit)
        //        {
        //            try
        //            {
        //                return deserialize(delegate.get(timeout, unit));
        //            }
        //            catch (ClientException | APIException e) {
        //                throw new ExecutionException(e);
        //            } catch (ExecutionException e)
        //            {
        //                throw unwrap(e);
        //            }
        //        }

        //        private ExecutionException
        //    {
        //        Throwable cause = e.getCause();
        //        if (cause == null)
        //        {
        //            return e;
        //        }

        //        if (cause instanceof TransportClientException) {
        //            return new ExecutionException(new ClientException(cause));
        //        }

        //        return e;
        //    }
    }
}