using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacTOe.Models.App
{
    public class Move
    {
        public int MoveId { get; set; }

        public int Xcor { get; set; }

        public int Ycor { get; set; }

        public DateTime Timstamp { get; set; }

        public int? GameId { get; set; }

        public Game Game { get; set; }
    }
}