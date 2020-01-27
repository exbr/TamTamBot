# TamTamBot

API https://tamtam.chat

Protocol version 0.2.0

```C#
TamTamBotApi bot = TamTamBotApi.Create("%ACCESS_TOKEN%");
var message = new NewMessageBody { Text = "text message" };
var messageQuery = bot.SendMessage(message);
messageQuery.UserId = 123456789;
SendMessageResult result = await messageQuery.Execute();
```
