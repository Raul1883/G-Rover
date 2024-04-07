using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


namespace G_Rover
{
    public class Enemy: Entity, IDrawableEntity
{
        readonly string Deskription;
        readonly int Initiative;
        readonly List<Skill> SkillList;
    }
}
