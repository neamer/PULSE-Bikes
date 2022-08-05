using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class BicycleSizeUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string? Size { get; set; }
    }
}
