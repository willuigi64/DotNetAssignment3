using System.ComponentModel.DataAnnotations;

namespace DotNetAssignment3.Models
{
    public class Response
    {
        //PK
        public int ResponseId { get; set; }

        //FK
        public int PostId { get; set; }

        [StringLength(255, MinimumLength = 3)]
        [Required]
        public string? Content { get; set; }

        [Required]
        public DateTime? Created {  get; set; }

        // parent reference to Posts ; many-comments => one-post
        [Required]
        public Post? Post { get; set; }
    }
}
