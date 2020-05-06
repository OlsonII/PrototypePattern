namespace Domain
{
    public class Weapon : IClonable
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
        
        public IClonable Clone()
        {
            return this;
        }
    }
}