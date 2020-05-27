using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyResolveTest
{
    // This is a testing program for debuging one problem with name of resolving assembly
    class Program
    {


        static void Main(string[] args)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;

            currentDomain.AssemblyResolve += new ResolveEventHandler(MyResolveEventHandler);

            //We try to load assembly in different case

            var t0 = Type.GetType("CommonComponents.Infra.Zero.Uc.Deployment.ClientSoftwareUpdateStrategy, CommonComponents.Infra.Zero.Uc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
            Console.WriteLine("*** Type 0 ***");

            var t = Type.GetType("CommonComponents.Infra.Zero.Uc.Deployment.ClientSoftwareUpdateStrategy, CommonComponents.Infra.Zero.Uc");
            Console.WriteLine("*** Type 1 ***");

            var t2 = Type.GetType("CommonComponents.Infra.Zero.Uc.Deployment.ClientSoftwareUpdateStrategy, CommonComponents.Infra.Zero.Uc ");
            Console.WriteLine("*** Type 2 ***");

            var t3 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
            Console.WriteLine("*** Type 3 ***");

            var t4 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Version=4.0.0.0, Culture=neutral");
            Console.WriteLine("*** Type 4 ***");

            var t5 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Version=4.0.0.0, Culture=neutral ");
            Console.WriteLine("*** Type 5 ***");

            var t6 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Version=4.0.0.0");
            Console.WriteLine("*** Type 6 ***");

            var t7 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Version=4.0.0.0 ");
            Console.WriteLine("*** Type 7 ***");

            var t8 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Version=4.0.0.0, PublicKeyToken=b77a5c561934e089");
            Console.WriteLine("*** Type 8 ***");

            var t9 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Version=4.0.0.0, PublicKeyToken=b77a5c561934e089 ");
            Console.WriteLine("*** Type 9 ***");

            var t10 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Culture=neutral");
            Console.WriteLine("*** Type 10 ***");

            var t11 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Culture=neutral ");
            Console.WriteLine("*** Type 11 ***");

            var t12 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Culture=neutral2");
            Console.WriteLine("*** Type 12 ***");

            var t13 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Version=4.0.0.0, PublicKeyToke2n=b77a5c561934e089");
            Console.WriteLine("*** Type 13 ***");

            var t14 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, Vedrsion=4.0.0.0, PublicKeyToke2n=b77a5c561934e089");
            Console.WriteLine("*** Type 14 ***");

            var t15 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel2, PublicKeyToken=b77a5c561934e089, Version=4.0.0.0, Culture=neutral");
            Console.WriteLine("*** Type 15 ***");

            var t16 = Type.GetType("System.ServiceModel.Configuration.DiagnosticSection    , System.ServiceModel2   , PublicKeyToken=b77a5c561934e089  , Version=4.0.0.0  , Culture=neutral    ");
            Console.WriteLine("*** Type 16 ***");


        }

        private static Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Console.WriteLine($" Resolving assembly name: {args.Name}/");
            return null;
        }
    }
}
