using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace G_Rover
{
    public class BattleMap
    {
        public List<IDrawableEntity> Entitys = new();

        public BattleMap()
        {
            for (int i = 0; i < 6; i++)
                Entitys.Add(Entity.Void);
        }

        public void AddEntity(IDrawableEntity entity, Positions position)
        {
            if (Entitys[(int)position] != Entity.Void)
                throw new InvalidOperationException($"{position} уже содержит сущность");
            Entitys[(int)position] = entity;  

        }

        public void RemoveEntity(Positions position )
        {
            Entitys[(int)position] = Entity.Void;
        }

    }
}
