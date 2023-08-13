using System.ComponentModel.DataAnnotations;

namespace Employment.Domain.Dto.User
{
    public class PutEmploymentRequestDto
    {
        public int? Id { get; set; }
        [Required]
        public string? Company { get; set; }
        [Required]
        public uint? MonthsOfExperience { get; set; }
        [Required]
        public uint? Salary { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
