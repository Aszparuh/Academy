namespace MvcEssentials.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Models;

    public class NewsArticle : BaseModel<int>
    {
        private ICollection<Visit> visits;
        private ICollection<Image> images;

        public NewsArticle()
        {
            this.visits = new HashSet<Visit>();
        }

        [Required]
        [MaxLength(300)]
        public string Title { get; set; }

        [Required]
        [MaxLength(3000)]
        public string Content { get; set; }

        public bool? IsTop { get; set; }

        public int? NewsCategoryId { get; set; }

        public virtual NewsCategory Category { get; set; }

        public int? RegionId { get; set; }

        public virtual Region Region { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public int? ImageId { get; set; }

        public virtual Image Image { get; set; }

        public virtual ICollection<Image> Images
        {
            get { return this.images; }
            set { this.images = value; }
        }

        public virtual ICollection<Visit> Visits
        {
            get { return this.visits; }
            set { this.visits = value; }
        }
    }
}
