using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.Client.Models;

namespace TwitchUNO.libs
{
    interface IMessage
    {
        static extern string GetMessageBody(ChatMessage str);
        static extern string GetMessageAuthor(ChatMessage str);
    }

    class Message : IMessage
    {
        public static string GetMessageAuthor(ChatMessage str)
        {
            return str.Message;
        }

        public static string GetMessageBody(ChatMessage str)
        {
            return str.Username;
        }
    }
}
