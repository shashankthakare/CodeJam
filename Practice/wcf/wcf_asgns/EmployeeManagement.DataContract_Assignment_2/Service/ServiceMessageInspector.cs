using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;

namespace Service
{
    public class ServiceMessageInspector:IDispatchMessageInspector
    {

        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message requestMessage, System.ServiceModel.IClientChannel iClientChannel, System.ServiceModel.InstanceContext instanceContext)
        {
            //No implementation.
            return null;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message replyMessage, object correlationState)
        {
            string machineName = Environment.MachineName;
            replyMessage.Headers.Add(MessageHeader.CreateHeader("serverName", "http://EmployeeManagementService.svcs", machineName));
        }
    }
}