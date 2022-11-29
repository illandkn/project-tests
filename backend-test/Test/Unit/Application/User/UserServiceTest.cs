using Application.Models.User;
using Application.Services.User;
using Domain.Entities;
using Domain.Interfaces.UserRepository;
using FluentAssertions;
using NSubstitute;
using Test.Builder.User;
using Xunit;

namespace Test.Unit.Application.User
{
    public class UserServiceTest
    {
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;

        public UserServiceTest()
        {
            _userRepository = Substitute.For<IUserRepository>();
            _userService = new UserService(_userRepository);
        }

        [Fact]
        public async Task Must_save_user()
        {
            var model = new UserRequestModel()
            {
                Ativo = true,
                Nome = "João",
                Email = "joao@email.com",
                Login = "joao123",
                Senha = "123456789",
                Cpf = "181.389.450-79",
                DataNascimento = DateTime.Parse("2001-07-02"),
                Genero = "Masculino",
                EstadoCivil = "Solteiro",
                Escolaridade = "Ensino Medio Completo",
                Curso = "Engenharia de Software",
                ExperienciaProfissional = "Empresa 3",
                PretensaoSalarial = 3000,
            };

            await _userService.Create(model);
            await _userRepository.Received(1).Create(Arg.Is<UserEntity>(x => x.Ativo == true
                                                                          && x.Nome == "João"
                                                                          && x.Email == "joao@email.com"
                                                                          && x.Login == "joao123"
                                                                          && x.Senha == "123456789"
                                                                          && x.Cpf == "181.389.450-79"
                                                                          && x.DataNascimento == DateTime.Parse("2001-07-02")
                                                                          && x.Genero == "Masculino"
                                                                          && x.EstadoCivil == "Solteiro"
                                                                          && x.Escolaridade == "Ensino Medio Completo"
                                                                          && x.Curso == "Engenharia de Software"
                                                                          && x.ExperienciaProfissional == "Empresa 3"
                                                                          && x.PretensaoSalarial == 3000));
        }

        [Fact]
        public async Task Must_update_user()
        {
            var userId = Guid.NewGuid();
            var model = new UserRequestModel()
            {
                Ativo = true,
                Nome = "João",
                Email = "joao@email.com",
                Login = "joao123",
                Senha = "123456789",
                Cpf = "181.389.450-79",
                DataNascimento = DateTime.Parse("2001-07-02"),
                Genero = "Masculino",
                EstadoCivil = "Solteiro",
                Escolaridade = "Ensino Medio Completo",
                Curso = "Engenharia de Software",
                ExperienciaProfissional = "Empresa 3",
                PretensaoSalarial = 3000,
            };

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

            _userRepository.GetById(userId).Returns(user);
            await _userService.Update(userId, model);
            await _userRepository.Received(1).Update(userId, Arg.Is<UserEntity>(x => x.Ativo == true
                                                                                  && x.Nome == "João"
                                                                                  && x.Email == "joao@email.com"
                                                                                  && x.Login == "joao123"
                                                                                  && x.Senha == "123456789"
                                                                                  && x.Cpf == "181.389.450-79"
                                                                                  && x.DataNascimento == DateTime.Parse("2001-07-02")
                                                                                  && x.Genero == "Masculino"
                                                                                  && x.EstadoCivil == "Solteiro"
                                                                                  && x.Escolaridade == "Ensino Medio Completo"
                                                                                  && x.Curso == "Engenharia de Software"
                                                                                  && x.ExperienciaProfissional == "Empresa 3"
                                                                                  && x.PretensaoSalarial == 3000));
        }

        [Fact]
        public async Task Must_inactivate_user()
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

            _userRepository.GetById(userId).Returns(user);
            await _userService.Delete(userId);
            await _userRepository.Received(1).Update(userId, Arg.Is<UserEntity>(x => x.Ativo == false
                                                                                  && x.Nome == "João"
                                                                                  && x.Email == "joao@email.com"
                                                                                  && x.Login == "joao123"
                                                                                  && x.Senha == "12345"
                                                                                  && x.Cpf == "181.389.450-79"
                                                                                  && x.DataNascimento == DateTime.Parse("2001-07-02")
                                                                                  && x.Genero == "Masculino"
                                                                                  && x.EstadoCivil == "Solteiro"
                                                                                  && x.Escolaridade == "Ensino Medio Completo"
                                                                                  && x.Curso == "Eng de Software"
                                                                                  && x.ExperienciaProfissional == "Empresa 3"
                                                                                  && x.PretensaoSalarial == 3000));
        }

        [Fact]
        public async Task Must_get_by_id()
        {
            var userId = Guid.NewGuid();
            var user = new UserBuilder()
                .WithId(userId)
                .WithNome("João")
                .Ativo()
                .Build();

            _userRepository.GetById(userId).Returns(user);

            var userReturned = await _userService.GetById(userId);

            userReturned.Nome.Should().Be(user.Nome);
            userReturned.Ativo.Should().Be(user.Ativo);
            userReturned.Id.Should().Be(user.Id);
        }

        [Fact]
        public async Task Must_return_all_users()
        {
            var userIdA = Guid.NewGuid();
            var userA = new UserBuilder()
                .WithId(userIdA)
                .WithNome("João")
                .Ativo()
                .Build();

            var userIdB = Guid.NewGuid();
            var userB = new UserBuilder()
                .WithId(userIdB)
                .WithNome("Gabriel")
                .Ativo()
                .Build();

            var users = new List<UserEntity>();
            users.Add(userA);
            users.Add(userB);

            _userRepository.GetAll().Returns(users);

            var userReturned = await _userService.GetAll();

            userReturned.Should().HaveCount(2);

            userReturned[0].Nome.Should().Be(userA.Nome);
            userReturned[0].Ativo.Should().Be(userA.Ativo);
            userReturned[0].Id.Should().Be(userIdA);

            userReturned[1].Nome.Should().Be(userB.Nome);
            userReturned[1].Ativo.Should().Be(userB.Ativo);
            userReturned[1].Id.Should().Be(userIdB);

        }
    }
}
