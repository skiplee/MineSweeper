namespace MineSweeperTests
{
    public class Gameboard
    {
        internal Gameboard(int dimensionX, int dimensionY, int mines )
        {
            DimensionX = dimensionX;
            DimensionY = dimensionY;
            Mines = mines;
        }
        public int DimensionX { get; private set; }

        public int DimensionY { get; private set; }

        public int Mines { get; private set; }
    }
}