using System;
using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;
using ExLib.TamTam.Bot.Exceptions;
using ExLib.TamTam.Bot.Queries;

namespace ExLib.TamTam.Bot
{
    public class TamTamBotApi
    {
        private readonly TamTamClient _client;

        public TamTamBotApi(string accessToken, ITamTamTransportClient transport)
         : this(new TamTamClient(accessToken, transport))
        {
        }

        public TamTamBotApi(TamTamClient client)
        {
            _client = client;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public static TamTamBotApi Create(string accessToken)
        {
            return new TamTamBotApi(TamTamClient.Create(accessToken));
        }

        /// <summary>
        /// Add members
        /// Adds members to chat. Additional permissions may require.
        /// </summary>
        /// <param name="userIdsList">(required)</param>
        /// <param name="chatId">Chat identifier (required)</param>
        /// <returns>SimpleQueryResult</returns>
        public AddMembersQuery AddMembers(UserIdsList userIdsList, long chatId)
        {
            if (userIdsList == null)
            {
                throw new RequiredParameterMissingException("Missing the required request body when calling addMembers");
            }

            return new AddMembersQuery(_client, userIdsList, chatId);
        }

        /// <summary>
        /// Answer on callback
        /// This method should be called to send an answer after a user has clicked the button. The answer may be an updated message or/and a one-time user notification.
        /// </summary>
        /// <param name="callbackAnswer">(required)</param>
        /// <param name="callbackId">Identifies a button clicked by user. Bot receives this identifier after user pressed button as part of MessageCallbackUpdate (required)</param>
        /// <returns>SimpleQueryResult</returns>
        public AnswerOnCallbackQuery AnswerOnCallback(CallbackAnswer callbackAnswer, string callbackId)
        {
            if (callbackId == null)
            {
                throw new RequiredParameterMissingException("Missing the required parameter 'callback_id' when calling answerOnCallback");
            }

            if (callbackAnswer == null)
            {
                throw new RequiredParameterMissingException("Missing the required request body when calling answerOnCallback");
            }

            return new AnswerOnCallbackQuery(_client, callbackAnswer, callbackId);
        }

        /// <summary>
        /// Construct message
        /// Sends answer on construction request.Answer can contain any prepared message and/or keyboard to help user interact with bot.
        /// </summary>
        /// <param name="constructorAnswer"> constructorAnswer  (required)</param>
        /// <param name="sessionId">sessionId Constructor session identifier (required)</param>
        /// <returns>SimpleQueryResult</returns>
        public ConstructQuery Construct(ConstructorAnswer constructorAnswer, string sessionId)
        {
            if (sessionId == null)
            {
                throw new RequiredParameterMissingException("Missing the required parameter 'session_id' when calling construct");
            }

            if (constructorAnswer == null)
            {
                throw new RequiredParameterMissingException("Missing the required request body when calling construct");
            }

            return new ConstructQuery(_client, constructorAnswer, sessionId);
        }

        /// <summary>
        /// Delete message
        /// Deletes message in a dialog or in a chat if bot has permission to delete messages.
        /// </summary>
        /// <param name="messageId">Deleting message identifier (required)</param>
        /// <returns>SimpleQueryResult</returns>
        public DeleteMessageQuery DeleteMessage(string messageId)
        {
            if (messageId == null)
            {
                throw new RequiredParameterMissingException("Missing the required parameter 'message_id' when calling deleteMessage");
            }

            return new DeleteMessageQuery(_client, messageId);
        }

        /// <summary>
        /// Edit chat info
        /// Edits chat info: title, icon, etc…
        /// </summary>
        /// <param name="chatPatch">(required)</param>
        /// <param name="chatId">Chat identifier (required)</param>
        /// <returns>Chat</returns>
        public EditChatQuery EditChat(ChatPatch chatPatch, long chatId)
        {
            if (chatPatch == null)
            {
                throw new RequiredParameterMissingException("Missing the required request body when calling editChat");
            }

            return new EditChatQuery(_client, chatPatch, chatId);
        }

        /// <summary>
        /// Edit message
        /// Updated message should be sent as &#x60;NewMessageBody&#x60; in a request body. In case &#x60;attachments&#x60; field is &#x60;null&#x60;, the current message attachments won’t be changed. In case of sending an empty list in this field, all attachments will be deleted.
        /// </summary>
        /// <param name="newMessageBody">(required)</param>
        /// <param name="messageId">Editing message identifier (required)</param>
        /// <returns>SimpleQueryResult</returns>
        public EditMessageQuery EditMessage(NewMessageBody newMessageBody, String messageId)
        {
            if (messageId == null)
            {
                throw new RequiredParameterMissingException("Missing the required parameter 'message_id' when calling editMessage");
            }

            if (newMessageBody == null)
            {
                throw new RequiredParameterMissingException("Missing the required request body when calling editMessage");
            }

            return new EditMessageQuery(_client, newMessageBody, messageId);
        }

        /// <summary>
        /// Edit current bot info
        /// Edits current bot info. Fill only the fields you want to update. All remaining fields will stay untouched
        /// </summary>
        /// <param name="botPatch">(required)</param>
        /// <returns>BotInfo</returns>
        public EditMyInfoQuery EditMyInfo(BotPatch botPatch)
        {
            if (botPatch == null)
            {
                throw new RequiredParameterMissingException("Missing the required request body when calling editMyInfo");
            }

            return new EditMyInfoQuery(_client, botPatch);
        }

        /// <summary>
        /// Get chat
        /// Returns info about chat.
        /// </summary>
        /// <param name="chatId">Requested chat identifier (required)</param>
        /// <returns>Chat</returns>
        public GetChatQuery GetChat(long chatId)
        {
            return new GetChatQuery(_client, chatId);
        }

        /// <summary>
        /// Get chat admins
        /// Returns info about chat admins.
        /// </summary>
        /// <param name="chatId">Requested chat identifier (required)</param>
        /// <returns>Chat admins</returns>
        public GetAdminsQuery GetChatAdmins(long chatId)
        {
            return new GetAdminsQuery(_client, chatId);
        }

        /// <summary>
        /// Get all chats
        /// Returns information about chats that bot participated in: a result list and marker points to the next page
        /// </summary>
        /// <returns>ChatList</returns>
        public GetChatsQuery GetChats()
        {
            return new GetChatsQuery(_client);
        }

        /// <summary>
        /// Get members
        /// Returns users participated in chat.
        /// </summary>
        /// <param name="chatId">Chat identifier (required)</param>
        /// <returns>ChatMembersList</returns>
        public GetMembersQuery GetMembers(long chatId)
        {
            return new GetMembersQuery(_client, chatId);
        }

        /// <summary>
        /// Get chat membership
        /// Returns chat membership info for current bot
        /// </summary>
        /// <param name="chatId">Chat identifier (required)</param>
        /// <returns>ChatMember</returns>
        public GetMembershipQuery GetMembership(long chatId)
        {
            return new GetMembershipQuery(_client, chatId);
        }

        /// <summary>
        /// Get message
        /// Returns single message by its identifier.
        /// </summary>
        /// <param name="messageId">messageId Message identifier  to get single message in chat (required)</param>
        /// <returns>Message</returns>
        public GetMessageByIdQuery GetMessageById(string messageId)
        {
            if (messageId == null)
            {
                throw new RequiredParameterMissingException("Missing the required parameter 'messageId' when calling getMessageById");
            }

            return new GetMessageByIdQuery(_client, messageId);
        }

        /// <summary>
        /// Get messages
        /// Returns messages in chat: result page and marker referencing to the next page. Messages traversed in reverse direction so the latest message in chat will be first in result array. Therefore if you use &#x60;from&#x60; and &#x60;to&#x60; parameters, &#x60;to&#x60; must be **less than** &#x60;from&#x60;
        /// </summary>
        /// <returns>MessageList</returns>
        public GetMessagesQuery GetMessages()
        {
            return new GetMessagesQuery(_client);
        }

        /// <summary>
        /// Get current bot info
        /// Returns info about current bot. Current bot can be identified by access token. Method returns bot identifier, name and avatar (if any)
        /// </summary>
        /// <returns>BotInfo</returns>
        public GetMyInfoQuery GetMyInfo()
        {
            return new GetMyInfoQuery(_client);
        }

        /// <summary>
        /// Get subscriptions
        /// In case your bot gets data via WebHook, the method returns list of all subscriptions
        /// </summary>
        /// <returns>GetSubscriptionsResult</returns>
        public GetSubscriptionsQuery GetSubscriptions()
        {
            return new GetSubscriptionsQuery(_client);
        }

        /// <summary>
        /// Get updates
        /// You can use this method for getting updates in case your bot is not subscribed to WebHook. The method is based on long polling.  Every update has its own sequence number. &#x60;marker&#x60; property in response points to the next upcoming update.  All previous updates are considered as *committed* after passing &#x60;marker&#x60; parameter. If &#x60;marker&#x60; parameter is **not passed**, your bot will get all updates happened before the last commitment.
        /// </summary>
        /// <returns>UpdateList</returns>
        public GetUpdatesQuery GetUpdates()
        {
            return new GetUpdatesQuery(_client);
        }

        /// <summary>
        /// Get upload URL
        /// Returns the URL for the subsequent file upload.  For example, you can upload it via curl:  &#x60;&#x60;&#x60;curl -i -X POST   -H \&quot;Content-Type: multipart/form-data\&quot;   -F \&quot;data&#x3D;@movie.mp4\&quot; \&quot;%UPLOAD_URL%\&quot;&#x60;&#x60;&#x60;  Two types of an upload are supported: - single request upload (multipart request) - and resumable upload.  ##### Multipart upload This type of upload is a simpler one but it is less reliable and agile. If a &#x60;Content-Type&#x60;: multipart/form-data header is passed in a request our service indicates upload type as a simple single request upload.  This type of an upload has some restrictions:  - Max. file size - 2 Gb - Only one file per request can be uploaded - No possibility to restart stopped / failed upload  ##### Resumable upload If &#x60;Content-Type&#x60; header value is not equal to &#x60;multipart/form-data&#x60; our service indicated upload type as a resumable upload. With a &#x60;Content-Range&#x60; header current file chunk range and complete file size can be passed. If a network error has happened or upload was stopped you can continue to upload a file from the last successfully uploaded file chunk. You can request the last known byte of uploaded file from server and continue to upload a file.  ##### Get upload status To GET an upload status you simply need to perform HTTP-GET request to a file upload URL. Our service will respond with current upload status, complete file size and last known uploaded byte. This data can be used to complete stopped upload if something went wrong. If &#x60;REQUESTED_RANGE_NOT_SATISFIABLE&#x60; or &#x60;INTERNAL_SERVER_ERROR&#x60; status was returned it is a good point to try to restart an upload
        /// </summary>
        /// <param name="type">Uploaded file type: photo, audio, video, file (required)</param>
        /// <returns>UploadEndpoint</returns>
        public GetUploadUrlQuery GetUploadUrl(UploadType type)
        {
            return new GetUploadUrlQuery(_client, type);
        }

        /// <summary>
        /// Leave chat
        /// Removes bot from chat members.
        /// </summary>
        /// <param name="chatId">Chat identifier (required)</param>
        /// <returns>SimpleQueryResult</returns>
        public LeaveChatQuery LeaveChat(long chatId)
        {
            return new LeaveChatQuery(_client, chatId);
        }

        /// <summary>
        /// Removes member from chat. Additional permissions may require.
        /// </summary>
        /// <param name="chatId">Chat identifier (required)</param>
        /// <param name="userId">User id to remove from chat (required)</param>
        /// <returns>SimpleQueryResult</returns>
        public RemoveMemberQuery RemoveMember(long chatId, long userId)
        {
            return new RemoveMemberQuery(_client, chatId, userId);
        }

        /// <summary>
        /// Send bot action to chat
        /// </summary>
        /// <param name="actionRequestBody">(required)</param>
        /// <param name="chatId">Chat identifier (required)</param>
        /// <returns>SimpleQueryResult</returns>
        public SendActionQuery SendAction(ActionRequestBody actionRequestBody, long chatId)
        {
            if (actionRequestBody == null)
            {
                throw new RequiredParameterMissingException("Missing the required request body when calling sendAction");
            }

            return new SendActionQuery(_client, actionRequestBody, chatId);
        }

        /// <summary>
        /// Sends a message to a chat. As a result for this method new message identifier returns. ### Attaching media Attaching media to messages is a three-step process.  At first step, you should [obtain a URL to upload](#operation/getUploadUrl) your media files.  At the second, you should upload binary of appropriate format to URL you obtained at the previous step. See [upload](https://dev.tamtam.chat/#operation/getUploadUrl) section for details.  Finally, if the upload process was successful, you will receive JSON-object in a response body.  Use this object to create attachment. Construct an object with two properties:  - &#x60;type&#x60; with the value set to appropriate media type  - and &#x60;payload&#x60; filled with the JSON you&#39;ve got.   For example, you can attach a video to message this way:  1. Get URL to upload. Execute following: &#x60;&#x60;&#x60;shell curl -X POST \\   &#39;https://botapi.tamtam.chat/uploads?access_token&#x3D;%access_token%&amp;type&#x3D;video&#39; &#x60;&#x60;&#x60; As the result it will return URL for the next step. &#x60;&#x60;&#x60;json {     \&quot;url\&quot;: \&quot;http://vu.mycdn.me/upload.do…\&quot; } &#x60;&#x60;&#x60;   2. Use this url to upload your binary:  &#x60;&#x60;&#x60;shell curl -i -X POST      -H \&quot;Content-Type: multipart/form-data\&quot;      -F \&quot;data&#x3D;@movie.mp4\&quot; \&quot;http://vu.mycdn.me/upload.do…\&quot; &#x60;&#x60;&#x60; As the result it will return JSON you can attach to message: &#x60;&#x60;&#x60;json {     \&quot;id\&quot;: 1234567890 } &#x60;&#x60;&#x60; 3. Send message with attach: &#x60;&#x60;&#x60;json {  \&quot;text\&quot;: \&quot;Message with video\&quot;,  \&quot;attachments\&quot;: [   {    \&quot;type\&quot;: \&quot;video\&quot;,    \&quot;payload\&quot;: {        \&quot;id\&quot;: 1173574260020    }   }  ] } &#x60;&#x60;&#x60;  **Important notice**:  It may take time for the server to process your file (audio/video or any binary). While a file is not processed you can&#39;t attach it. It means the last step will fail with &#x60;400&#x60; error. Try to send a message again until you&#39;ll get a successful result.
        /// </summary>
        /// <param name="newMessageBody">(required)</param>
        /// <returns>SendMessageResult</returns>
        public SendMessageQuery SendMessage(NewMessageBody newMessageBody)
        {
            if (newMessageBody == null)
            {
                throw new RequiredParameterMissingException("Missing the required request body when calling sendMessage");
            }

            return new SendMessageQuery(_client, newMessageBody);
        }

        /// <summary>
        /// Subscribes bot to receive updates via WebHook. After calling this method, the bot will receive notifications about new events in chat rooms at the specified URL.  Your server **must** be listening on one of the following ports: **80, 8080, 443, 8443, 16384-32383**
        /// </summary>
        /// <param name="subscriptionRequestBody">(required)</param>
        /// <returns>SimpleQueryResult</returns>
        public SubscribeQuery Subscribe(SubscriptionRequestBody subscriptionRequestBody)
        {
            if (subscriptionRequestBody == null)
            {
                throw new RequiredParameterMissingException("Missing the required request body when calling subscribe");
            }

            return new SubscribeQuery(_client, subscriptionRequestBody);
        }

        /// <summary>
        /// Unsubscribes bot from receiving updates via WebHook. After calling the method, the bot stops receiving notifications about new events. Notification via the long-poll API becomes available for the bot
        /// </summary>
        /// <param name="url">URL to remove from WebHook subscriptions (required)</param>
        /// <returns>SimpleQueryResult</returns>
        public UnsubscribeQuery Unsubscribe(String url)
        {
            if (url == null)
            {
                throw new RequiredParameterMissingException("Missing the required parameter 'url' when calling unsubscribe");
            }

            return new UnsubscribeQuery(_client, url);
        }

        public void StartWebHook(string url, Action<Update> callback)
        {
            if (url == null)
            {
                throw new RequiredParameterMissingException("Missing the required parameter 'url' when start WebHook");
            }

            if (callback == null)
            {
                throw new RequiredParameterMissingException("Missing the required parameter 'callback' when start WebHook");
            }

            _client.StartWebHook(url, callback);
        }
    }
}
