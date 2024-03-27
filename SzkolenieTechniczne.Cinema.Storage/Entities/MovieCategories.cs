using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Storage.Common;

namespace SzkolenieTechniczne.Cinema.Storage.Entities
{
    [Table("MovieCategories", Schema = "Cinema")]
    public class MovieCategories:BaseEntity
    {
        public MovieCategories()
        {
        }

        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string CategoryName { get; set; }

        [Required]
        [MinLength(1)]
        public int MovieCategoryId { get; set; }
      
    }
}
