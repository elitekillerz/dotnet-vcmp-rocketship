using System;

namespace EliteKillerz.DotnetVcmp.Rocketship.Lifecycle
{
    public class StartupClassNotFoundException : Exception
    {
        internal StartupClassNotFoundException()
            : base() { }

        public override string Message
        {
            get => "No startup class found - make sure your startup class is marked with StartupClassAttribute and is publicly accessible"; 
        }

        public override string ToString() => Message;
    }
}
