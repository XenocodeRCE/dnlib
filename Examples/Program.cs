using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace dnlib.Examples {
	class Program {
		static void Main(string[] args) {

            //standard loading
            ModuleDefMD mod = ModuleDefMD.Load(typeof(Program).Assembly.Location);
            
            //Get all type except <module>
            foreach (var t in mod.GetTypes(true)) {
                //Invoke MEthodDef using MethodInfo
                foreach (var m in t.Methods(true)) {
                    if(m.Name == "testInvoke") {
                        var k = m.Invoke(new object[] { "Hello World :-)" });
                    }
                }
            }
		}


        public string testInvoke(string msg) {
            Console.WriteLine(msg);
            return "ok";
        }
    }
}
