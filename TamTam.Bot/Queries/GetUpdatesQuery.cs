using System.Collections.Generic;
using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class GetUpdatesQuery : TamTamQuery<UpdateList>
    {
        private readonly QueryParam<int> _limit;
        private readonly QueryParam<int> _timeout;
        private readonly QueryParam<long> _marker;
        private readonly QueryParam<List<string>> _types;

        public GetUpdatesQuery(TamTamClient client)
            : base(client, "/updates", null, Method.GET)
        {
            _limit = new QueryParam<int>("limit", 100, this);
            _timeout = new QueryParam<int>("timeout", 30, this);
            _marker = new QueryParam<long>("marker", this);
            _types = new QueryParam<List<string>>("types", this);
        }

        public int Limit
        {
            get => _limit.Value;
            set => _limit.Value = value;
        }

        public int Timeout
        {
            get => _timeout.Value;
            set => _timeout.Value = value;
        }
        public long Marker
        {
            get => _marker.Value;
            set => _marker.Value = value;
        }
        public List<string> Types
        {
            get => _types.Value;
            set => _types.Value = value;
        }
    }

}
