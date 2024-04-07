using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Rover
{
    public static class GameState
    {
        public static IState State { get; private set; }

        public static IState GetCurrentState()
        {
            return State;
        }

        public static void RunMainMenu() => State = new MainMenu();
        public static void RunBattle(Rover rover,
            Entity firstEnemy, Entity secondEnemy, Entity thirdEnemy) => 
            State = new Battle(rover, firstEnemy, secondEnemy, thirdEnemy);


    }
}
