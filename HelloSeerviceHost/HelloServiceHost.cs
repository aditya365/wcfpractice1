﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace HelloSeerviceHost
{
    class HelloServiceHost
    {
        public static void Main() {
            using (ServiceHost host=new ServiceHost(typeof(HelloService.HelloService))) {
                host.Open();
                Console.WriteLine("Host started @"+DateTime.Now.ToString());
                Console.ReadLine();
            };
        }
    }
}
