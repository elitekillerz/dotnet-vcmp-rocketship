using System;

namespace EliteKillerz.DotnetVcmp.Rocketship.Lifecycle
{
    public class StartupClassUnderivedException : Exception
    {
        internal StartupClassUnderivedException()
            : base() { }

        public override string Message
        {
            get => "Startup class does not implement IStartup"; 
        }

        public override string ToString() => Message;
    }
}
