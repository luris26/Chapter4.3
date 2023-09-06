using System.ComponentModel.DataAnnotations;
namespace MyBGList.Models
{
    public class BoardGames_Mechanics
    {
        public ICollection<BoardGames_Domains>? BoardGames_Domains { get; set; }
        public ICollection<BoardGames_Mechanics>? BoardGames_Mechanics1 { get; set; }
        [Key]public ICollection<BoardGames_Domains>? BoardGames_Domains1 { get; set; }
        [Required]
        public int BoardGameId { get; set; }

        [Key]
        [Required]
        public int MechanicId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}