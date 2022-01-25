using COMMON.Constants;
using System.ComponentModel.DataAnnotations;

namespace COMMON.DTO
{
    public class DTORequest
    {
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        public string Make { get; set; }

        public string Year { get; set; }

        public int Sales { get; set; }
    }
}
