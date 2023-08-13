using System.ComponentModel.DataAnnotations;

namespace Employment.Domain.Dto.User
{
    public class PostRequestDto
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public PostAddressRequestDto Address { get; set; }
        public List<PostEmploymentRequestDto> Employments { get; set; }
    }
}
