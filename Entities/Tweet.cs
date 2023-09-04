using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Tweet
    {
        [Key]
        public Guid IdTweet { get; set; }
        public string? Content { get; set; }
        [Required]
        public Guid IdUser { get; set; }
        public DateTime? CreatedTime { get; set; }
        public byte[]? Media { get; set; }
        public string? Tag { get; set; }
    }
}