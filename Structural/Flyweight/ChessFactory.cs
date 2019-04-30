using System;
using System.Collections;
using System.Collections.Generic;

namespace Flyweight
{
    public class ChessFactory
    {
        private Hashtable chesses = new Hashtable();

        public T GetChess<T>(string key, string color, int[] coordinate) where T : Chess
        {
            if (chesses[key] == null)
                chesses.Add(key, Activator.CreateInstance<T>());
            var chess = (T)chesses[key];
            chess.Color = color;
            chess.Coordinate = coordinate;
            return chess;
        }
    }
}
