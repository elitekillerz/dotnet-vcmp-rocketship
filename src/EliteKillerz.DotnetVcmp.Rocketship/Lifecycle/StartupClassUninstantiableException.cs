using System;

namespace EliteKillerz.DotnetVcmp.Rocketship.Lifecycle
{
    public class StartupClassUninstantiableException : Exception
    {
        internal StartupClassUninstantiableException()
            : base() { }

        public override string Message
        {
            get => "Startup class cannot be instantiated"; 
        }

        public override string ToString() => Message;
    }
}
