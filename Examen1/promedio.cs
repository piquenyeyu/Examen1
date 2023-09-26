using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Examen1
{
    public class promedio
    {
        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Range(0, 100,
        ErrorMessage = "Value  must be between {0} and {100}.")]
        public double NOTA1 { get; set; }

        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Range(0, 100,
        ErrorMessage = "Value  must be between {0} and {100}.")]
        public double NOTA2 { get; set; }

        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Range(0, 100,
        ErrorMessage = "Value  must be between {0} and {100}.")]
        public double NOTA3 { get; set; }

        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Range(0, 100,
        ErrorMessage = "Value must be between {0} and {100}.")]
        public double ACTITUDINAL { get; set; }

    }
}
