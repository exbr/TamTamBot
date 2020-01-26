using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class RemoveMemberQuery : TamTamQuery<SimpleQueryResult>
    {
        private readonly QueryParam<long> _userId;
        private readonly QueryParam<bool> _block;

        public RemoveMemberQuery(TamTamClient client, long chatId, long userId)
            : base(client, $"/chats/{chatId}/members", null, Method.DELETE)
        {
            _userId = new QueryParam<long>("user_id", userId, this).Required();
            _block = new QueryParam<bool>("block", this);
        }

        public long UserId
        {
            get => _userId.Value;
            set => _userId.Value = value;
        }

        public bool Block
        {
            get => _block.Value;
            set => _block.Value = value;
        }
    }
}
