namespace MVC.Essentials.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common.Models;

    public class NewsArticle : BaseModel<int>
    {
        [Required]
        [MaxLength(3000)]
        public string Content { get; set; }

        public int CategoryId { get; set; }

        public virtual NewsCategory Category { get; set; }

        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
    }
}
