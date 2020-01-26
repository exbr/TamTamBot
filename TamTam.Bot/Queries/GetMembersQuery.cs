using System.Collections.Generic;
using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class GetMembersQuery : TamTamQuery<ChatMembersList>
    {
        private readonly QueryParam<List<long>> _userIds;
        private readonly QueryParam<long> _marker;
        private readonly QueryParam<int> _count;

        public GetMembersQuery(TamTamClient client, long chatId)
            : base(client, $"/chats/{chatId}/members", null, Method.GET)
        {
            _userIds = new QueryParam<List<long>>("user_ids", this);
            _marker = new QueryParam<long>("marker", this);
            _count = new QueryParam<int>("count", this);
        }


        public List<long> UserIds
        {
            get => _userIds.Value;
            set => _userIds.Value = value;
        }

        public long Marker
        {
            get => _marker.Value;
            set => _marker.Value = value;
        }

        public int Count
        {
            get => _count.Value;
            set => _count.Value = value;
        }


    }
}
