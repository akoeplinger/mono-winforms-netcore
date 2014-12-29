using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
    public class ILGenerator
    {
        public void Emit(OpCode ldarg_S, int v)
        {
            throw new NotImplementedException();
        }

        public void EmitCalli(OpCode calli, CallingConvention stdCall, Type ret_type, Type[] param_types)
        {
            throw new NotImplementedException();
        }

        public void Emit(OpCode ldarg_3)
        {
            throw new NotImplementedException();
        }
    }
}