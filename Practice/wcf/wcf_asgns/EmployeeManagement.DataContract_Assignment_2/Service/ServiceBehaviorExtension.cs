using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Configuration;

namespace Service
{
    public class ServiceBehaviorExtension:BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(ServiceEndpointBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new ServiceEndpointBehavior();
        }
    }
}