using System;
using System.Collections.Generic;
using System.Linq;

namespace EliteKillerz.DotnetVcmp.Rocketship.Lifecycle
{
    public static class LifecycleManager
    {
        private static Type GetStartupClass()
        {
            IList<Type> startupClasses =
                (from assemblies in AppDomain.CurrentDomain.GetAssemblies()
                 from type in assemblies.GetTypes()
                 where Attribute.IsDefined(type, typeof(StartupClassAttribute))
                 select type).ToList();

            if (startupClasses.Count == 0)
                throw new StartupClassNotFoundException();

            if (startupClasses.Count > 1)
                throw new AmbiguousStartupClassException();

            return startupClasses.First();
        }
    }
}
