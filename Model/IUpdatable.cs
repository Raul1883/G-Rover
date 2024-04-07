using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Rover
{
    public interface IUpdatable
    {
        public void Update(MouseState mouseState);
        
    }
}
