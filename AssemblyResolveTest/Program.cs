using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyResolveTest
{
    class Program
    {

        // This is a testing program for debuging one problem with name of resolving assembly
        static void Main(string[] args)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;

            //try to load assembly
            currentDomain.AssemblyResolve += new ResolveEventHandler(MyResolveEventHandler);

            var type = Type.GetType("CommonComponents.Infra.Zero.Uc.Deployment.ClientSoftwareUpdateStrategy, CommonComponents.Infra.Zero.Uc ");

        }

        private static Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Console.WriteLine($"Неудачно искали для загрузки :(args.Name) : {args.Name}");

            // Using Mono - args.Name="CommonComponents.Infra.Zero.Uc , Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"
            // It is wrong because using .Net Framework we can take args.Name="CommonComponents.Infra.Zero.Uc"
            // This problem have been detected when I try use Mono with one application that use compare this parametr

            // This problem with  mono_stringify_assembly_name in assembly.c

            if (args.Name.Equals("CommonComponents.Infra.Zero.Uc"))
                Console.WriteLine("args.Name is equal \"CommonComponents.Infra.Zero.Uc\"");

            return null;
        }
    }
}
