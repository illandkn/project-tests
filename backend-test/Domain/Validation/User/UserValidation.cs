using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation.User
{
    public class UserValidation : AbstractValidator<UserEntity>
    {
        public UserValidation() 
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(user => user.Nome)
                .NotNull().WithMessage("O nome não pode ser nulo!")
                .NotEmpty().WithMessage("O nome não pode ser vazio!");
            RuleFor(user => user.Email)
                .NotNull().WithMessage("O e-mail não pode ser nulo!")
                .NotEmpty().WithMessage("O e-mail não pode ser vazio!");
            RuleFor(user => user.Login)
                .NotNull().WithMessage("O login não pode ser nulo!")
                .NotEmpty().WithMessage("O login não pode ser vazio!");
            RuleFor(user => user.Senha)
                .NotNull().WithMessage("A senha não pode ser nulo!")
                .NotEmpty().WithMessage("A senha não pode ser vazio!");
            RuleFor(user => user.Cpf)
                .NotNull().WithMessage("O cpf não pode ser nulo!")
                .NotEmpty().WithMessage("O cpf não pode ser vazio!")
                .IsValidCPF();
            RuleFor(user => user.Genero)
                .NotNull().WithMessage("O genero não pode ser nulo!")
                .NotEmpty().WithMessage("O genero não pode ser vazio!");
            RuleFor(user => user.EstadoCivil)
                .NotNull().WithMessage("O estado civil não pode ser nulo!")
                .NotEmpty().WithMessage("O estado civil não pode ser vazio!");
            RuleFor(user => user.Escolaridade)
                .NotNull().WithMessage("A escolaridade não pode ser nulo!")
                .NotEmpty().WithMessage("A escolaridade não pode ser vazio!");
            RuleFor(user => user.Curso)
                .NotNull().WithMessage("O curso não pode ser nulo!")
                .NotEmpty().WithMessage("O curso não pode ser vazio!");
            RuleFor(user => user.ExperienciaProfissional)
                .NotNull().WithMessage("A experiencia profissional não pode ser nulo!")
                .NotEmpty().WithMessage("A experiencia profissional não pode ser vazio!");
            RuleFor(user => user.PretensaoSalarial)
                .NotEmpty().WithMessage("A pretensao salarial não pode ser vazio!");


        }
    }
}
