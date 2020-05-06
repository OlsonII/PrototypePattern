using System;
using System.Collections.Generic;
using Domain;

namespace Application
{
    public class PrototypeSoldier
    {
        private Dictionary<string, Soldier> Prototypes = new Dictionary<string, Soldier>();
        
        public PrototypeSoldier()
        {
            Soldier General = new Soldier(range: "General", weapon: new Weapon(referenceCode: "000", name: "9mm"));
            Soldier InitialSoldier = new Soldier(range: "Initial", weapon: new Weapon(referenceCode: "000", name: "M16"));
            
            Prototypes.Add("General", General);
            Prototypes.Add("Initial", InitialSoldier);
        }

        public IClonable Prototype(string range)
        {
            if (Prototypes.TryGetValue(range, out Soldier soldier))
            {
                return soldier.Clone();
            }

            return null;
        }
    }
}