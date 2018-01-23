using System;
using System.Reflection;

namespace EdiEngine
{
    public static class ActivatorHelper
    {
        public static object Instantiate(string asmName, string typeName)
        {
            Type t = Type.GetType($"{typeName}, {asmName}",
                Assembly.Load,
                (assm, name, ignore) => assm.GetType(name, false, ignore), 
                false);

            if (t == null)
            {
                throw new TypeLoadException($"Can not resolve type asm: {asmName}, type: {typeName}");
            }
            return Activator.CreateInstance(t);
        }
    }
}
