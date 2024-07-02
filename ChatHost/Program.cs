﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ChatHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(WpfLibrary2NNC.Service1)))
            {
                host.Open();
                Console.ReadLine();
            }
        }
    }
}
