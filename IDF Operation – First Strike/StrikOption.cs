using IDF_Operation___First_Strike.logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation___First_Strike
{
    abstract class StrikeOption
    {
        private string AttackVehicle;
        public int AmmunitionCapacity { get; set; }
        public string EffectiveAgainst { get; set; }
        
        public StrikeOption(string attackVehicle, string effectiveAgainst, int AmmunitionCapacity)
        {
            this.AttackVehicle = attackVehicle;
            this.EffectiveAgainst = effectiveAgainst;
            this.AmmunitionCapacity = AmmunitionCapacity;
        }

        public void SetName(string rank, string name)
        {
            bool permision = Permision.GetSet(rank);
            if (permision)
            {
                this.AttackVehicle = name;
            }
            else
            {
                Console.WriteLine("you dont heve permision");
            }
        }

        public string GetName(string rank)
        {
            bool permision = Permision.GetSet(rank);
            {
                if (permision)
                {
                    return this.AttackVehicle;
                }
                else
                {
                    return "you dont heve permision to this intel";
                }
            } 
        }
    }
}
