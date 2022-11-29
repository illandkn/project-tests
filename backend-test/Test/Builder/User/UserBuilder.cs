using Domain.Entities;

namespace Test.Builder.User
{
    public class UserBuilder
    {
        private Guid _id;
        private string _nome;
        private string _email;
        private string _login;
        private string _senha;
        private string _cpf;
        private DateTime _dataNascimento;
        private string _genero;
        private string _estadoCivil;
        private string _escolaridade;
        private string _curso;
        private string _experienciaProfissional;
        private decimal _pretensaoSalarial;
        private bool _ativo;

        public UserEntity Build()
        {
            return new UserEntity(_nome, _email, _login, _senha, _cpf, _dataNascimento, _genero, _estadoCivil, _escolaridade, _curso, _experienciaProfissional, _pretensaoSalarial)
            {
                Id = _id
            };
        }

        public UserBuilder WithNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public UserBuilder WithEmail(string email)
        {
            _email = email;
            return this;
        }

        public UserBuilder WithLogin(string login)
        {
            _login = login;
            return this;
        }

        public UserBuilder WithSenha(string senha)
        {
            _senha = senha;
            return this;
        }

        public UserBuilder WithCPF(string cpf)
        {
            _cpf = cpf;
            return this;
        }

        public UserBuilder WithDataNascimento(DateTime dataNascimento)
        {
            _dataNascimento = dataNascimento;
            return this;
        }

        public UserBuilder WithGenero(string genero)
        {
            _genero = genero;
            return this;
        }

        public UserBuilder WithEstadoCivil(string estadoCivil)
        {
            _estadoCivil = estadoCivil;
            return this;
        }

        public UserBuilder WithEscolaridade(string escolaridade)
        {
            _escolaridade = escolaridade;
            return this;
        }

        public UserBuilder WithCurso(string curso)
        {
            _curso = curso;
            return this;
        }

        public UserBuilder WithExperienciaProfissional(string experienciaProfissional)
        {
            _experienciaProfissional = experienciaProfissional;
            return this;
        }

        public UserBuilder WithPretensaoSalarial(decimal pretensaoSalarial)
        {
            _pretensaoSalarial = pretensaoSalarial;
            return this;
        }

        public UserBuilder WithId(Guid id)
        {
            _id = id; 
            return this;
        }

        public UserBuilder Ativo()
        {
            _ativo = true;
            return this;
        }

        public UserBuilder Inativo()
        {
            _ativo = false;
            return this;
        }
    }
}
