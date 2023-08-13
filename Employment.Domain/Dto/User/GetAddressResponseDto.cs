namespace Employment.Domain.Dto.User
{
    public class GetAddressResponseDto
    {
        public int Id { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public int? PostCode { get; set; }
    }
}
