namespace Employment.Domain.Dto.User
{
    public class GetResponseDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public GetAddressResponseDto Address { get; set; }
        public List<GetEmploymentResponseDto> Employments { get; set; }
    }
}
