using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TicTacTOe.Models.App
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [Range(3, 5, ErrorMessage = "Недопустимая длина")]
        public int Height { get; set; }

        [Required]
        [Range(100, 500, ErrorMessage = "Недоступимая  значение")]
        public double Bet { get; set; }


        public bool Begin { get; set; }

        public DateTime Timestamp { get; set; }

        public ICollection<Move> Moves { get; set; }
        public ICollection<Message> Messages { get; set; }

        public Game()
        {
            Moves = new List<Move>();
            Messages = new List<Message>();
        }

        public int? PlayerId { get; set; }
        public ApplicationUser Player { get; set; }

        public int? OpponentId { get; set; }
        public ApplicationUser Opponent { get; set; }


    }
}