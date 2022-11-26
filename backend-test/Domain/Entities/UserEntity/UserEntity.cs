using Domain.Enum;

namespace Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public UserEntity(string nome, string email, string login, string senha, string cpf, DateTime dataNascimento, string genero, string estadoCivil, string escolaridade, string curso, string experienciaProfissional, decimal pretensaoSalarial)
        {
            Nome = nome;
            Email = email;
            Login = login;
            Senha = senha;
            Role = PerfilEnum.Padrao;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Genero = genero;
            EstadoCivil = estadoCivil;
            Escolaridade = escolaridade;
            Curso = curso;
            ExperienciaProfissional = experienciaProfissional;
            PretensaoSalarial = pretensaoSalarial;
            CriadoEm = DateTime.Now;
            Ativo = true;
        }

        public void Update(string nome, string email, string login, string senha, string cpf, DateTime dataNascimento, string genero, string estadoCivil, string escolaridade, string curso, string experienciaProfissional, decimal pretensaoSalarial, bool ativo)
        {
            Nome = nome;
            Email = email;
            Login = login;
            Senha = senha;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Genero = genero;
            EstadoCivil = estadoCivil;
            Escolaridade = escolaridade;
            Curso = curso;
            ExperienciaProfissional = experienciaProfissional;
            PretensaoSalarial = pretensaoSalarial;
            AlteradoEm = DateTime.Now;
            Ativo = ativo;
        }

        public void Disable()
        {
            Ativo = false;
        }

        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        public string Login { get; protected set; }
        public string Senha { get; protected set; }
        public PerfilEnum Role { get; protected set; }
        public string Cpf { get; protected set; }
        public DateTime DataNascimento { get; protected set; }
        public string Genero { get; protected set; }
        public string EstadoCivil { get; protected set; }
        public string Escolaridade { get; protected set; }
        public string Curso { get; protected set; }
        public string ExperienciaProfissional { get; protected set; }
        public decimal PretensaoSalarial { get; set; }
        public DateTime CriadoEm { get; protected set; }
        public DateTime AlteradoEm { get; protected set; }
        public bool Ativo { get; protected set; }
    }
}
