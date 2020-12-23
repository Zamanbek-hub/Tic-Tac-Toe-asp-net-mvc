# Tic-Tac-Toe-asp-net-mvc
## Hi this project developed for the ASP.NET MVC course on the univer

**Includes:**
- DB Connection and One to Many, Many to Many, One to One relationships
- JQuery for Ajax
- Views, Partial Views
- Controllers, CRUD
- Master Page
- Data Validation
- Unittest
- Authorization/Registration
- Play Tic Tac Toe


## How you see on the below code, demonstrated model Game(Include):
- Validation
- One to Many relationship with ApplicationUser
```
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
```

