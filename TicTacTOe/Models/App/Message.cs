using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacTOe.Models.App
{
    public class Message
    {
        public int MessageId { get; set; }

        public string MessageText { get; set; }

        public DateTime Timstamp { get; set; }

        public int? GameId { get; set; }

        public Game Game { get; set; }

    }
}