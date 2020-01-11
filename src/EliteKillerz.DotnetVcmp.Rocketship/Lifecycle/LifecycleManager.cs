using System;
using System.Collections.Generic;
using System.Linq;

namespace EliteKillerz.DotnetVcmp.Rocketship.Lifecycle
{
    public static class LifecycleManager
    {
        private static IStartup InstantiateStartupClass()
        {
            IList<Type> startupClasses =
                (from assemblies in AppDomain.CurrentDomain.GetAssemblies()
                 from type in assemblies.GetTypes()
                 where type.IsClass && Attribute.IsDefined(type, typeof(StartupClassAttribute))
                 select type).ToList();

            if (startupClasses.Count == 0)
                throw new StartupClassNotFoundException();

            if (startupClasses.Count > 1)
                throw new AmbiguousStartupClassException();

            Type startupClassType = startupClasses.First();

            if (!startupClassType.IsSubclassOf(typeof(IStartup)))
                throw new StartupClassUnderivedException();

            IStartup? startupClass = (IStartup?)Activator.CreateInstance(startupClassType);

            if (startupClass == null)
                throw new StartupClassUninstantiableException();

            return startupClass;
        }
    }
}
