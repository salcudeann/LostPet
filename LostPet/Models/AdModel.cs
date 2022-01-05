using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LostPet.Models
{
    public class AdModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime PublishDate { get; set; }

        public string Owner { get; set; }

        public bool Status { get; set; }

        public bool Rejected { get; set; }
    }
}