using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Configuration;

namespace TestModel
{
    public class ClientBehaviorExtension:BehaviorExtensionElement
    {

        public override Type BehaviorType
        {
            get { return typeof(ClientEndpointBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new ClientEndpointBehavior();
        }
    }
}
