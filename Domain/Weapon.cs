using System;

namespace Domain
{
    public class Weapon : ICloneable
    {
        public string ReferenceCode { get; set; }
        public string Name { get; set; }
        
        public Weapon()
        {
        }
        
        public Weapon(string referenceCode, string name)
        {
            ReferenceCode = referenceCode;
            Name = name;
        }
        
        public Object Clone()
        {
            return this;
        }
    }
}