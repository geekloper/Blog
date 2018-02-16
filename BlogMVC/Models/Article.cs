using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class Article
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "text")]
        [DisplayName("Your article")]
        [DataType(DataType.MultilineText)]
        public string BodyText { get; set; }

        public ApplicationUser Author { get; set; }

        [Required]
        public string ArtistId { get; set; }
    }
}