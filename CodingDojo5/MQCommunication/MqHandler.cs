using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MQCommunication
{
    public class MqHandler<T>
    {
        //string mqName = @".\private$\dataexchange";
        string mqName;
        MessageQueue mq;

        public MqHandler(string mqName)
        {
            this.mqName = mqName;
            if (!MessageQueue.Exists(mqName))
            {
                MessageQueue.Create(mqName);
            }
            mq = new MessageQueue("FormatName:direct=os:" + mqName);
            mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(T) });
        }

        public void Send(T s)
        {
            mq.Send(s);
        }

        public T Receive()
        {
            return (T)mq.Receive().Body;
        }
    }
}
