using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

public class ModuleInit
{
#pragma warning disable CA2255
    [ModuleInitializer]
#pragma warning restore CA2255
    public static void Init()
    {
        AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
        {
            var name = new AssemblyName(args.Name).Name;
            var dir = Path.GetDirectoryName(typeof(ModuleInit).Assembly.Location);
            if (dir != null)
            {
                var path = Path.Combine(dir, name + ".dll");
                if (File.Exists(path))
                {
                    return Assembly.LoadFrom(path);
                }
            }
            return null;
        };
    }
}
