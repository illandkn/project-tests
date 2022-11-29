using FluentAssertions;
using Test.Builder.User;
using Xunit;

namespace Test.Unit.Domain.User
{
    public class UserEntityTest
    {
        public UserEntityTest() { }

        [Fact]
        public async Task Must_update_user()
        {
            var userId = Guid.NewGuid();
            var user = new UserBuilder()
                .WithId(userId)
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
                .WithPretensaoSalarial(3000)
                .Ativo()
                .Build();

            user.Update("João", "joao@email.com", "joao123", "123456789", "181.389.450-79", DateTime.Parse("2001-07-02"), "Masculino", "Solteiro", "Ensino Medio Completo", "Engenharia de Software", "Empresa 3", 3000, true);

            user.Nome.Should().Be("João");
            user.Email.Should().Be("joao@email.com");
            user.Login.Should().Be("joao123");
            user.Senha.Should().Be("123456789");
            user.Cpf.Should().Be("181.389.450-79");
            user.DataNascimento.Should().Be(DateTime.Parse("2001-07-02"));
            user.Genero.Should().Be("Masculino");
            user.EstadoCivil.Should().Be("Solteiro");
            user.Escolaridade.Should().Be("Ensino Medio Completo");
            user.Curso.Should().Be("Engenharia de Software");
            user.ExperienciaProfissional.Should().Be("Empresa 3");
            user.PretensaoSalarial.Should().Be(3000);
            user.Ativo.Should().BeTrue();
            user.Id.Should().Be(userId);
        }

        [Fact]
        public async Task Must_inactive_user()
        {
            var user = new UserBuilder().Ativo().Build();
            user.Disable();
            user.Ativo.Should().BeFalse();
        }
    }
}
