﻿using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace dnlib.Examples {
	class Program {
        static void Main(string[] args) {


            ModuleDefMD mod = ModuleDefMD.Load(typeof(Program).Assembly.Location);
            //Reflection-style Method fetched
            MethodDef targetMethod = mod.ResolveMethod(0x040000E8);


            //Get all type except <module>
            foreach (var t in mod.GetTypes(true)) {
                //Invoke MEthodDef using MethodInfo
                foreach (var m in t.Methods(true)) {
                    if (m.Name == "testInvoke") {
                        var k = m.Invoke(new object[] { "Hello World :-)" });
                    }
                    m.Empty();



                }
            }
        }


        static string testInvoke(string msg) {
            Console.WriteLine(msg);
            return "ok";
        }
    }
}
