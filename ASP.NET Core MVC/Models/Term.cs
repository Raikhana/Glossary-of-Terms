using System.ComponentModel.DataAnnotations;
namespace ASP.NET_Core_MVC.Models
{
    public class Term
    {
        // EF will instruct the database to automatically generate this value
        public int TermId { get; set; }

        [Required(ErrorMessage = "Please enter a term.")]
        public string TermName { get; set; }

        [Required(ErrorMessage = "Please enter a page numbers.")]
        [Range(1, 765, ErrorMessage = "Page numbers must be between 1 and 765.")]
        public int? Page { get; set; }

        [Required(ErrorMessage = "Please enter a stage.")]
        [Range(1, 5, ErrorMessage = "Study stages must be between 1 and 5.")]
        public int? Stage { get; set; }

        [Required(ErrorMessage = "Please enter a chapter.")]
        public string ChapterId { get; set; } 
        public Chapter Chapter { get; set; }

        public string Slug =>
            TermName?.Replace(' ', '-').ToLower() + '-' + Page?.ToString();
    }
}
