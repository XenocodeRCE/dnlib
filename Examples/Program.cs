using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace dnlib.Examples {
	class Program {
        static void Main(string[] args) {
            ModuleDefMD mod = ModuleDefMD.Load(typeof(Program).Assembly.Location);
            foreach (var t in mod.GetTypes(true)) {
                foreach (var m in t.Methods(true)) {
                    //InsertBefore / InsertAfter
                    m.Body.Instructions.InsertAfter(OpCodes.Switch.ToInstruction(), Instruction.CreateLdcI4(12));
                    m.Body.Instructions.InsertAfter(m.Body.Instructions[0], OpCodes.Ret.ToInstruction());

                    m.Body.Instructions.InsertBefore(OpCodes.Switch.ToInstruction(), OpCodes.Nop.ToInstruction());
                    m.Body.Instructions.InsertBefore(m.Body.Instructions[m.Body.Instructions.Count], OpCodes.Ret.ToInstruction());
                }
            }
        }


        static string testInvoke(string msg) {
            Console.WriteLine(msg);
            return "ok";
        }
    }
}
