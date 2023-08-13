using System.ComponentModel.DataAnnotations;

namespace Employment.Domain.Dto.User
{
    public class PostAddressRequestDto
    {
        [Required]
        public string? Street { get; set; }
        [Required]
        public string? City { get; set; }
        public int? PostCode { get; set; }

    }
}
