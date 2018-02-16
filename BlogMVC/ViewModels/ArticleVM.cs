using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogMVC.ViewModels
{
    public class ArticleVM
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "text")]
        [DisplayName("Your article")]
        [MinLength(120)]
        [DataType(DataType.MultilineText)]
        public string BodyText { get; set; }
    }
}