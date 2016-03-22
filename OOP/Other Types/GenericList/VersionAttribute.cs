using System;

namespace GenericList
{
    [AttributeUsage(AttributeTargets.Struct | 
                    AttributeTargets.Class | 
                    AttributeTargets.Interface | 
                    AttributeTargets.Enum | 
                    AttributeTargets.Method)]
    public class VersionAttribute : System.Attribute
    {
        public double Version { get; private set; }

        public VersionAttribute(double version)
        {
            this.Version = version;
        }
    }
}
