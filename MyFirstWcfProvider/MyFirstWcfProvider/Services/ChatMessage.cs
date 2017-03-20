using System;
using System.Runtime.Serialization;

namespace MyFirstWcfProvider.Services
{
    [DataContract]
    public class ChatMessage
    {
        [DataMember]
        public string Header { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public string Content { get; set; }
    }
}
