using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System;

namespace ГотиниСъбития.Data.Entities
{
    public class Event
    {
        public Event()
        {
            //
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EventDate { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]      
        public string ImageUrl { get; set; }
    }
    
}
