using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class ProductCategoryUpsertRequest
    {
        [MinLength(2)]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
    }
}
