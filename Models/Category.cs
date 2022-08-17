using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BimBookWeb.Models
{
    public class Category
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Category()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage ="Display Order must be between 1 and 100 only!")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;


    }
}

