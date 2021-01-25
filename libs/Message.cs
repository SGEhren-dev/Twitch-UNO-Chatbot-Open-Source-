using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.Client.Models;

namespace TwitchUNO.libs
{

    class Message
    {
        public static string GetMessageAuthor(ChatMessage str)
        {
            return str.Message;
        }

        public static string GetMessageBody(ChatMessage str)
        {
            return str.Username;
        }

        public static bool IsValidCommand(string msg)
        {
            for(int i = 0; i < msg.Length; i++)
            {
                if(i == 0 && msg[i] == '!')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
