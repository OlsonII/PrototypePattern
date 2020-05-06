namespace Domain
{
    public class Soldier : IClonable
    {
        public string Range { get; set; }
        public Weapon Weapon { get; set; }

        public Soldier()
        {
        }

        public Soldier(string range, Weapon weapon)
        {
            Range = range;
            Weapon = (Weapon) weapon.Clone();
        }

        public IClonable Clone()
        {
            return this;
        }
    }
}