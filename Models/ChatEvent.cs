using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatServer.Models
{
    public class ChatMessage
    {
        public string text { get; set; }

        public int id { get; set; }
    }



    public class ChatEvent
    {
        public string EventType { get; set; }

        public ChatMessage Body { get; set; }
    }
}
