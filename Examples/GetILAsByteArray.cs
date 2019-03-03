using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

class MyClass {
    //static void aaa(string[] args) {
    //    //load file
    //    ModuleDefMD mod = ModuleDefMD.Load("Target.exe");
    //    //grab only app types
    //    foreach (var t in mod.GetTypes(true)) {
    //        Console.WriteLine($"Type :{t.Name}");
    //        //grab only method with CilBody
    //        foreach (var m in t.Methods(true)) {
    //            Console.WriteLine($"    Method :{m.Name}");

    //            Console.WriteLine($"        CilBody :");
                
    //            //iterate in CilBoddy as byte[] 
    //            foreach (var item in m.Body.GetILAsByteArray()) {
    //                Console.WriteLine("             {" + item + "} , ");
    //            }

    //        }
    //    }

    //    Console.ReadKey();
    //}
}