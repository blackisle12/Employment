using System.ComponentModel.DataAnnotations;

namespace Employment.Domain.Dto.User
{
    public class PostEmploymentRequestDto
    {
        [Required]
        public string? Company { get; set; }
        [Required]
        public uint? MonthsOfExperience { get; set; }
        [Required]
        public uint? Salary { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
