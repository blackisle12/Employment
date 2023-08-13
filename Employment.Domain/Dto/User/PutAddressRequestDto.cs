using System.ComponentModel.DataAnnotations;

namespace Employment.Domain.Dto.User
{
    public class PutAddressRequestDto
    {
        [Required]
        public string? Street { get; set; }
        [Required]
        public string? City { get; set; }
        public int? PostCode { get; set; }

    }
}
