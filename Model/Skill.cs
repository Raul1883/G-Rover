using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Rover
{
    public class Skill
    {
        readonly string Name;
        readonly string Description;
        readonly int UserPosition;
        readonly int TargetPosition;
        readonly int Damage;
        readonly Effect Effect;
        readonly int FuelCost;
        readonly int LifeCost;

        public Skill(string name, int userPosition, int targetPosition, int damage)
        {
            if (name == null) throw new ArgumentNullException("name");
            Name = name;
            UserPosition = userPosition;
            TargetPosition = targetPosition;
            Damage = damage;
        }

        /*
        public void DoSkill(int target, int damage)
        {

        }
        */
    }
}
