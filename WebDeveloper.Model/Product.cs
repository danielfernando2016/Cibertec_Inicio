using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int ID { get; set; }
        
        [Display(Name = "Description_Name", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "This field is required")]
        public string Description { get; set; }



        [DataType(DataType.Date)]
        [Display(Name = "Create Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? CreateDate { get; set; }

        //[Display(Name = "Stock")]
        //[Required(ErrorMessage = "The field is required")]
        //public int ProductStock { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "The field is required")]
        public double Price { get; set; }

    }
}
