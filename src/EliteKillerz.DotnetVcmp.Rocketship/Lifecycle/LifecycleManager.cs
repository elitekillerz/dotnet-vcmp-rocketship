using System;
using System.Collections.Generic;
using System.Linq;

namespace EliteKillerz.DotnetVcmp.Rocketship.Lifecycle
{
    public sealed class LifecycleManager
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

        public static LifecycleManager Default
        {
            get
            {
                if (_defaultLifecycleManager == null)
                    _defaultLifecycleManager = new LifecycleManager();

                return _defaultLifecycleManager;
            }

            private set
            {
                _defaultLifecycleManager = value;
            }
        }

        private static LifecycleManager? _defaultLifecycleManager;
    }
}
