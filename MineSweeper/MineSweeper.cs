using System;

namespace MineSweeperTests
{
    public class MineSweeper
    {
        public Gameboard Gameboard;

        public MineSweeper(int dimensionX, int dimensionY, int mines)
        {
            Gameboard = new Gameboard(dimensionX, dimensionY, mines);

        }

    }
}