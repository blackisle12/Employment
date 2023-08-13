namespace Employment.Domain.Dto.User
{
    public class GetEmploymentResponseDto
    {
        public int Id { get; set; }
        public string? Company { get; set; }
        public uint? MonthsOfExperience { get; set; }
        public uint? Salary { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
