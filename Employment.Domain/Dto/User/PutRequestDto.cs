using System.ComponentModel.DataAnnotations;

namespace Employment.Domain.Dto.User
{
    public class PutRequestDto
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public PutAddressRequestDto Address { get; set; }
        public List<PutEmploymentRequestDto> Employments { get; set; }
    }
}
