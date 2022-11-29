using Domain.Validation.User;
using FluentAssertions;
using FluentAssertions.Equivalency;
using Infra.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.Builder.User;
using Xunit;

namespace Test.Unit.Validation.User
{
    public class UserValidationTest
    {
        private UserValidation validators;

        public UserValidationTest() 
        {
            validators = new UserValidation();
        }

        [Theory]
        [InlineData(null)]
        public void should_return_error_when_name_is_null(string nome)
        {
            var user = new UserBuilder()
                .WithNome(nome)
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O nome não pode ser nulo!");
        }

        [Theory]
        [InlineData("")]
        public void should_return_error_when_name_is_empty(string nome)
        {
            var user = new UserBuilder()
                .WithNome(nome)
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O nome não pode ser vazio!");
        }

        [Theory]
        [InlineData(null)]
        public void should_return_error_when_email_is_null(string email)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail(email)
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O e-mail não pode ser nulo!");
        }

        [Theory]
        [InlineData("")]
        public void should_return_error_when_email_is_empty(string email)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail(email)
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O e-mail não pode ser vazio!");
        }

        [Theory]
        [InlineData(null)]
        public void should_return_error_when_login_is_null(string login)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin(login)
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O login não pode ser nulo!");
        }

        [Theory]
        [InlineData("")]
        public void should_return_error_when_login_is_empty(string login)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin(login)
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O login não pode ser vazio!");
        }

        [Theory]
        [InlineData(null)]
        public void should_return_error_when_password_is_null(string password)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha(password)
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("A senha não pode ser nulo!");
        }

        [Theory]
        [InlineData("")]
        public void should_return_error_when_password_is_empty(string password)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha(password)
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("A senha não pode ser vazio!");
        }

        [Theory]
        [InlineData(null)]
        public void should_return_error_when_cpf_is_null(string cpf)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF(cpf)
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O cpf não pode ser nulo!");
        }

        [Theory]
        [InlineData("")]
        public void should_return_error_when_cpf_is_empty(string cpf)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF(cpf)
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O cpf não pode ser vazio!");
        }

        [Theory]
        [InlineData(null)]
        public void should_return_error_when_gender_is_null(string gender)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero(gender)
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O genero não pode ser nulo!");
        }

        [Theory]
        [InlineData("")]
        public void should_return_error_when_gender_is_empty(string gender)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero(gender)
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O genero não pode ser vazio!");
        }

        [Theory]
        [InlineData(null)]
        public void should_return_error_when_marital_status_is_null(string maritalStatus)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil(maritalStatus)
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O estado civil não pode ser nulo!");
        }

        [Theory]
        [InlineData("")]
        public void should_return_error_when_marital_status_is_empty(string maritalStatus)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil(maritalStatus)
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O estado civil não pode ser vazio!");
        }

        [Theory]
        [InlineData(null)]
        public void should_return_error_when_scholarity_is_null(string scholarity)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade(scholarity)
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("A escolaridade não pode ser nulo!");
        }

        [Theory]
        [InlineData("")]
        public void should_return_error_when_scholarity_is_empty(string scholarity)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade(scholarity)
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("A escolaridade não pode ser vazio!");
        }

        [Theory]
        [InlineData(null)]
        public void should_return_error_when_curses_is_null(string curses)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso(curses)
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O curso não pode ser nulo!");
        }

        [Theory]
        [InlineData("")]
        public void should_return_error_when_curses_is_empty(string curses)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso(curses)
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("O curso não pode ser vazio!");
        }

        [Theory]
        [InlineData(null)]
        public void should_return_error_when_professional_experience_is_null(string professionalExperience)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional(professionalExperience)
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("A experiencia profissional não pode ser nulo!");
        }

        [Theory]
        [InlineData("")]
        public void should_return_error_when_professional_experience_is_empty(string professionalExperience)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional(professionalExperience)
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("A experiencia profissional não pode ser vazio!");
        }

        [Theory]
        [InlineData(0)]
        public void should_return_error_when_salary_expectation_is_empty(decimal salaryExpectation)
        {
            var user = new UserBuilder()
                .WithNome("João")
                .WithEmail("joao@email.com")
                .WithLogin("joao123")
                .WithSenha("12345")
                .WithCPF("181.389.450-79")
                .WithDataNascimento(DateTime.Parse("2001-07-02"))
                .WithGenero("Masculino")
                .WithEstadoCivil("Solteiro")
                .WithEscolaridade("Ensino Medio Completo")
                .WithCurso("Eng de Software")
                .WithExperienciaProfissional("Empresa 3")
                .WithPretensaoSalarial(salaryExpectation)
                .Ativo()
                .Build();

            var result = validators.Validate(user);
            result.Errors.First().ErrorMessage.Should().Be("A pretensao salarial não pode ser vazio!");
        }
    }
}
