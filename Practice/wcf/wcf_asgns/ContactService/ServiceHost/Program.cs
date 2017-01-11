using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ContactService;

namespace ServiceHostServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svc = new ServiceHost(typeof(CRUDContact));

            svc.Open();
            foreach (Uri uri in svc.BaseAddresses)
                Console.WriteLine(uri.AbsoluteUri);

            Console.WriteLine("Press any key to exit..");
            Console.Read();

            svc.Close();
        }
    }
}
