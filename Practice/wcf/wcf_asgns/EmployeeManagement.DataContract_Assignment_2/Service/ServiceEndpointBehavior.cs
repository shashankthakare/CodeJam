using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Service
{
    public class ServiceEndpointBehavior:IEndpointBehavior
    {

        public void AddBindingParameters(ServiceEndpoint serviceEndpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameterCollection)
        {
            //No implementation
        }

        public void ApplyClientBehavior(ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {
            throw new NotImplementedException();
        }

        public void ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
        {
            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(new ServiceMessageInspector());

            foreach (DispatchOperation dispatchOperation in endpointDispatcher.DispatchRuntime.Operations)
            {
                if (dispatchOperation.Name.Equals("ReturnEmployeeList", StringComparison.InvariantCultureIgnoreCase))
                {
                    dispatchOperation.ParameterInspectors.Add(
                       new ServiceSortingParameterInspector());
                }
            }
        }

        public void Validate(ServiceEndpoint serviceEndpoint)
        {
            //No implementation
        }
    }
}