namespace FreeQuant.QuantRouterLib.Data
{
    public class Level2 : Tick
    {
        public byte Side { get; set; }

        public byte Action { get; set; }

        public int Position { get; set; }
    }
}
