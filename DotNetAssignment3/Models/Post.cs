using System.ComponentModel.DataAnnotations;

namespace DotNetAssignment3.Models
{
    public class Post
    {
        //PK
        public int PostId { get; set; }


        [MaxLength(60)]
        [Required]
        public string? Title { get; set; }

        public string? Image { get; set; }

        [MaxLength(255)]
        public string? Body { get; set; }

        [Display(Name = "Lost/Found Date and Time")]
        public DateTime LostFoundDate { get; set; }

        //child reference
        public List<Response>? Responses { get; set; }
    }
}