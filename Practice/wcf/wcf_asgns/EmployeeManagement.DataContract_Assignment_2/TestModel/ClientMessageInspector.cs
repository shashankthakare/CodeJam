using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.Net;

namespace TestModel
{
    public class ClientMessageInspector:IClientMessageInspector
    {
        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            //No implementation
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
        {
            string IpAddress = Dns.GetHostAddresses(Environment.MachineName)[0].ToString();
            request.Headers.Add(MessageHeader.CreateHeader("ClientName", "http://Client",IpAddress));
            return null;
        }
    }
}
