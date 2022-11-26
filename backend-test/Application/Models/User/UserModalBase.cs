using Domain.Enum;

namespace Application.Models
{
    public class UserModalBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public PerfilEnum Role { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public string Escolaridade { get; set; }
        public string Curso { get; set; }
        public string ExperienciaProfissional { get; set; }
        public decimal PretensaoSalarial { get; set; }
        public bool Ativo { get; set; }
    }
}
