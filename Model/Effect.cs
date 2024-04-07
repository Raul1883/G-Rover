using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Rover
{
    internal class Effect
{
        readonly string Name;
        readonly EffectType Type;
        readonly int DamagePerTick;
        public  Effect(string name, EffectType type, int damagePerTick)
        {
            Name = name;
            Type = type;    
            DamagePerTick = damagePerTick;
        }
}
    enum EffectType
    {
        Bleed,
        Fire,
        Stunned
    }
}
