namespace G_Rover
{
    public interface IDrawableEntity : IDrawable
    {

        public Positions Position { get; set; }


    }
    public enum Positions
    {
        BacklineRover,
        MiddleLineRover,
        NearLineRover,
        NearLineEnemy,
        MiddleLineEnemy,
        BacklineEnemy,
    }

}
