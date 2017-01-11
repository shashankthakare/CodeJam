using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace TestModel
{
    public static class ClientExtension
    {
        public static void CloseClient(this ICommunicationObject client)
        {
            if (client == null)
                return;
            if (client.State == CommunicationState.Faulted)
                client.Abort();
            else
                client.Close();

        }



    }
}
