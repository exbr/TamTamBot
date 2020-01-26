using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    /// <summary >
    /// Add members
    /// Adds members to chat. Additional permissions may require.
    /// Execute() return <see cref="SimpleQueryResult"/>
    /// </summary>
    public class AddMembersQuery : TamTamQuery<SimpleQueryResult>
    {
        public AddMembersQuery(TamTamClient client, UserIdsList userIdsList, long chatId)
            : base(client, $"/chats/{chatId}/members", userIdsList, Method.POST)
        {
        }

}
}
