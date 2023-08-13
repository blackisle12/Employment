namespace Employment.Repository.Entities
{
    public class Address : BaseEntity
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public int? PostCode { get; set; }
    }
}
