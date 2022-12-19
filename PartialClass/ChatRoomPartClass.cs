using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public partial class ChatRoom
    {
        public string GetGetLastMessage
        {
            get
            {
                string message = "Ничего нет";
                try
                {
                    message = ChatMessage.ToList().LastOrDefault().textMessage;
                    return message;
                }
                catch
                {
                    return message;
                }
            }
        }
    }
}