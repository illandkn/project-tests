namespace Application.Models.User
{
    public class UserResponseModel : UserModalBase
    {
        public Guid Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AlteradoEm { get; set; }
        //public decimal? TotalSalario { get; set; }
        //public decimal? MediaSalarial { get; set; }

    }
}
