using System;
using System.Collections.Generic;
using Domain;

namespace Application
{
    public class PrototypeSoldier
    {
        private readonly Dictionary<string, Soldier> _prototypes = new Dictionary<string, Soldier>();
        
        public PrototypeSoldier()
        {
            var generalWeapon = new Weapon(referenceCode: "000", name: "9mm");
            var general = new Soldier(range: "General", weapon: (Weapon) generalWeapon.Clone());
            var initialWeapon = new Weapon(referenceCode: "000", name: "M16");
            var initialSoldier = new Soldier(range: "Initial", weapon: (Weapon) initialWeapon.Clone());
            
            _prototypes.Add("General", general);
            _prototypes.Add("Initial", initialSoldier);
        }

        public Soldier Prototype(string range)
        {
            if (_prototypes.TryGetValue(range, out var soldier))
            {
                return (Soldier) soldier.Clone();
            }

            return null;
        }
    }
}