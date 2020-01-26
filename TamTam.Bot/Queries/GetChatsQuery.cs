using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class GetChatsQuery : TamTamQuery<ChatList>
    {
        private readonly QueryParam<int> _count;
        private readonly QueryParam<long> _marker;

        public GetChatsQuery(TamTamClient tamTamClient) : base(tamTamClient, "/chats", null, Method.GET)
        {
            _count = new QueryParam<int>("count", this);
            _marker = new QueryParam<long>("marker", this);
        }

        public int Count
        {
            get => _count.Value;
            set => _count.Value = value;
        }

        public long Marker
        {
            get => _marker.Value;
            set => _marker.Value = value;
        }

        public GetChatsQuery SetCount(int count)
        {
            Count = count;
            return this;
        }

        public GetChatsQuery SetMarker(int marker)
        {
            Marker = marker;
            return this;
        }


    }
}
