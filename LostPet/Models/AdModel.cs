using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LostPet.Models
{
    public class AdModel
    {
        [Display(Name = "Ad title")]
        [Required(ErrorMessage = "Ad title is mandatory")]
        public string Title { get; set; }

        [Display(Name = "Ad description")]
        [Required(ErrorMessage = "Ad description is mandatory")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Ad description should have at least 20 characters.")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime PublishDate { get; set; }

        [Display(Name = "Place of loss")]
        [StringLength(50)]
        public string Location { get; set; }

        public string UserName { get; set; }

        [Display(Name = "Images")]
        public List<string> Images { get; set; }

        public bool Status { get; set; } //false - pending approval; true - approved

    }
}