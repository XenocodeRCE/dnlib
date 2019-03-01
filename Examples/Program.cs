using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.Collections;
using System.Collections.Generic;

namespace dnlib.Examples {
	class Program {
		static void Main(string[] args) {
            //standard loading
            ModuleDefMD mod = ModuleDefMD.Load(typeof(Program).Assembly.Location);
            
            //Get all type except <module>
            foreach (var t in mod.GetTypes(true)) {
                //Get only method that has CilBody
                foreach (var m in t.Methods(true)) {
                    //Grab the instruction(s) you look for directly
                    IList<Instruction> instr = m.Body.Instructions.Find(Instruction.Create(OpCodes.Ldstr, "the_string"));
                }
            }
		}
    }
}
