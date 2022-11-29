using Application.Models;
using Application.Models.User;
using Application.Services.Token;
using Domain.Entities;
using Domain.Interfaces.UserRepository;
using Microsoft.AspNetCore.Mvc;

namespace Application.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) => _userRepository = userRepository;

        public async Task Create(UserRequestModel request)
        {
            var user = new UserEntity(request.Nome, request.Email, request.Login, request.Senha,
                                      request.Cpf, request.DataNascimento, request.Genero,
                                      request.EstadoCivil, request.Escolaridade, request.Curso,
                                      request.ExperienciaProfissional, request.PretensaoSalarial);
            user.Validate();
            await _userRepository.Create(user);
        }
        public async Task Update(Guid id, UserRequestModel request)
        {
            var user = await _userRepository.GetById(id);
            ValidateUser(user);

            user.Update(request.Nome, request.Email, request.Login, request.Senha, request.Cpf, 
                        request.DataNascimento, request.Genero, request.EstadoCivil, request.Escolaridade, 
                        request.Curso, request.ExperienciaProfissional, request.PretensaoSalarial, request.Ativo);
            user.Validate();
            await _userRepository.Update(id, user);
        }

        public async Task Delete(Guid id)
        {
            var user = await _userRepository.GetById(id);
            ValidateUser(user);

            user.Disable();
            await _userRepository.Update(id, user);
        }

        public async Task<IList<UserResponseModel>> GetAll()
        {
            var users = await _userRepository.GetAll();

            return users.Select(x => new UserResponseModel
            {
                Id = x.Id,
                Nome = x.Nome,
                Email = x.Email,
                Login = x.Login,
                Senha = x.Senha,
                Role = x.Role,
                Cpf = x.Cpf,
                DataNascimento = x.DataNascimento,
                Genero = x.Genero,
                EstadoCivil = x.EstadoCivil,
                Escolaridade = x.Escolaridade,
                Curso = x.Curso,
                ExperienciaProfissional = x.ExperienciaProfissional,
                PretensaoSalarial = x.PretensaoSalarial,
                CriadoEm = x.CriadoEm,
                AlteradoEm =  x.AlteradoEm,
                Ativo = x.Ativo
            }).ToList();
        }

        public async Task<UserResponseModel> GetById(Guid id)
        {
            var user = await _userRepository.GetById(id);
            ValidateUser(user);

            return new UserResponseModel()
            {
                Id = user.Id,
                Nome = user.Nome,
                Email = user.Email,
                Login = user.Login,
                Senha = user.Senha,
                Role = user.Role,
                Cpf = user.Cpf,
                DataNascimento = user.DataNascimento,
                Genero = user.Genero,
                EstadoCivil = user.EstadoCivil,
                Escolaridade = user.Escolaridade,
                Curso = user.Curso,
                ExperienciaProfissional = user.ExperienciaProfissional,
                PretensaoSalarial = user.PretensaoSalarial,
                CriadoEm = user.CriadoEm,
                AlteradoEm = user.AlteradoEm,
                Ativo = user.Ativo
            };
        }

        public async Task<ActionResult<dynamic>> Authenticate(UserLoginModelBase request)
        {
            var user = await _userRepository.GetUser(request.Login, request.Senha);

            if (user == null)
                throw new Exception("Usuário ou senha incorretos");

            var token = TokenService.GenerateToken(user);

            return new
            {
                user = user,
                token = token,
            };
        }

        private void ValidateUser(UserEntity user)
        {
            if (user == null)
                throw new Exception("Não foi possível encontrar esse curriculo!");
        }
    }
}
