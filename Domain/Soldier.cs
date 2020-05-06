using System;

namespace Domain
{
    public class Soldier : ICloneable
    {
        public string Range { get; set; }
        private Weapon Weapon { get; set; }

        public Soldier()
        {
        }

        public Soldier(string range, Weapon weapon)
        {
            Range = range;
            Weapon = (Weapon) weapon.Clone();
        }

        public Object Clone()
        {
            return this;
        }
    }
}