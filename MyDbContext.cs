using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext // DbContext represents a session with the database and is used to query and interact with the database.
{
    public DbSet<User> Users { get; set; }//DbSet is a generic class provided by Entity Framework Core, and it represents a collection of entities of a specific type.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
 
            // TODO: custom code here
            //There are two supported methods made 
            //available by EF core. conventions and the data annotation
            //modelBuilder.Entity<User>()
            //     .HasKey(u => u.UserId);

            //configure the primary key

            // modelBuilder.Entity<User>()
            //     .Property(u => u.UserName)
            //     .HasMaxLength(50);
            //maxlength

            // modelBuilder.Entity<User>()
            //     .HasMany(u => u.Posts)
            //     .WithOne(p => p.Author)
            //     .HasForeignKey(p => p.AuthorId);
            //
        }
}


public class User
{
    [Key]//this are data annotations
    public int Id { get; set; }

    [MaxLength]
    public string FirstName { get; set; }
    //conventions database schema automatically, without any additional config.
    public string LastName { get; set; }
    
}
[Table("BoardGames")]
public class BoardGame
{
    [Key]
    [Required]
    public int Id{get;set;}
    [Required]
    [MaxLength]
    public string Name{get;set;} = null;
    public string Name { get; set; } = null!;
 
        [Required]
        public int Year { get; set; }
 
        [Required]
        public int MinPlayers { get; set; }
 
        [Required]
        public int MaxPlayers { get; set; }
 
        [Required]
        public int PlayTime { get; set; }
 
        [Required]
        public int MinAge { get; set; }
 
        [Required]
        public int UsersRated { get; set; }
 
        [Required]
        [Precision(4, 2)]
        public decimal RatingAverage { get; set; }
 
        [Required]
        public int BGGRank { get; set; }
 
        [Required]
        [Precision(4, 2)]
        public decimal ComplexityAverage { get; set; }
 
        [Required]
        public int OwnedUsers { get; set; }
 
        [Required]
        public DateTime CreatedDate { get; set;}

}



class Program
{
    static void Main(string[] args)
    {
        using (var context = new MyDbContext())
        {
            var user = new User { FirstName = "John", LastName = "Doe" };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}

