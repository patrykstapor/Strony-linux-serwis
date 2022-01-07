using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Strony.Models
{
    public class Website
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Tytuł")]
        public string Title { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        [DisplayName("Kategoria")]
        public string Category { get; set; }
        [Required]
        [DisplayName("Stopka")]
        public string Footer { get; set; }
        [Required]
        [DisplayName("Opis")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Słowo kluczowe 1")]
        public string KeyWord1 { get; set; }
        [Required]
        [DisplayName("Słowo kluczowe 2")]
        public string KeyWord2 { get; set; }


    }
}
