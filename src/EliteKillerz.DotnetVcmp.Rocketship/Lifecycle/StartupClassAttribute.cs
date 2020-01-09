using System;

namespace EliteKillerz.DotnetVcmp.Rocketship.Lifecycle
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    class StartupClassAttribute : Attribute { }
}
