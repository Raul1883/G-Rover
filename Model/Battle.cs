using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Rover
{
    public class Battle : IState
    {
        public BattleMap Map;


        public Battle(Rover rover,
            Entity firstEnemy, Entity secondEnemy, Entity thirdEnemy)
        {
            Map = new BattleMap();
            Map.AddEntity(rover, rover.Position );
            Map.AddEntity(firstEnemy, firstEnemy.Position);
            Map.AddEntity(secondEnemy, secondEnemy.Position);
            Map.AddEntity(thirdEnemy, thirdEnemy.Position);
        }

        public void Update(MouseState mouseState)
        {
            throw new NotImplementedException();
        }
    }
}
