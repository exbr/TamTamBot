using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
  public  class UnsubscribeQuery: TamTamQuery<SimpleQueryResult>
  {
      private readonly QueryParam<string> _url ;

      public UnsubscribeQuery(TamTamClient client, string url)
          :base(client, "/subscriptions", null,  Method.DELETE)
      {
          _url = new QueryParam<string>("url", url, this).Required();
      }

      public string Url
      {
          get => _url.Value;
          set => _url.Value = value;
      }

  }
}
