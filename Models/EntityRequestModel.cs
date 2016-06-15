using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sabio.Web.Models.Requests
{
    public class EVA_EntityRequestModel
    {
        public string ID { get; set; }

        [Required]
        public int WebsiteId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Slug { get; set; }

    }
}