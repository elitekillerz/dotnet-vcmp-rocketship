using System;

namespace EliteKillerz.DotnetVcmp.Rocketship.Lifecycle
{
    public class AmbiguousStartupClassException : Exception
    {
        internal AmbiguousStartupClassException()
            : base() { }

        public override string Message
        {
            get => "Multiple startup classes found - make sure that only startup class is marked with StartupClassAttribute"; 
        }

        public override string ToString() => Message;
    }
}
