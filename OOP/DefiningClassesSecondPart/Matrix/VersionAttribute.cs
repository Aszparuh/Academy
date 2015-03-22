namespace Matrix
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Struct | AttributeTargets.Property)]
    public class VersionAttribute : Attribute
    {

        public VersionAttribute(int major, int minor)
        {
            this.MajorVersion = major;
            this.MinorVersion = minor;
        }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
    }
}