using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class GameField
    {
        //[JsonPropertyName("board")]
        public int[][] field { get; set; }

       // [JsonPropertyName("gameState")]
        public int gameState { get; set; }

        public GameField()
        {
            field = new int[][]
                {
                new int[] {0,0,0},
                new int[] {0,0,0},
                new int[] {0,0,0}
            };
            gameState = 2;
        }
    }
}
