using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
    internal class ILGenerator
    {
        internal void Emit(OpCode ldarg_S, int v)
        {
            throw new NotImplementedException();
        }

        internal void EmitCalli(OpCode calli, CallingConvention stdCall, Type ret_type, Type[] param_types)
        {
            throw new NotImplementedException();
        }

        internal void Emit(OpCode ldarg_3)
        {
            throw new NotImplementedException();
        }
    }
}