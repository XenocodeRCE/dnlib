using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace dnlib.Examples {
	class Program {
        static void Main(string[] args) {
            ModuleDefMD mod = ModuleDefMD.Load("Target.exe");
            foreach (var t in mod.GetTypes(true)) {
                Console.WriteLine($"Type :{t.Name}");
                foreach (var m in t.Methods(true)) {
                    Console.WriteLine($"    Method :{m.Name}");

                    Console.WriteLine($"        CilBody :");

                    foreach (var item in m.Body.GetILAsByteArray()) {
                        Console.WriteLine("             {" + item + "} , ");
                    }
                }
            }

            Console.ReadKey();
        }


        static string testInvoke(string msg) {
            Console.WriteLine(msg);
            return "ok";
        }
    }
}
