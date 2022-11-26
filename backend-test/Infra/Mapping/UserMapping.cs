using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.Property(x => x.Nome).HasColumnName(nameof(UserEntity.Nome)).IsRequired();
            builder.Property(x => x.Email).HasColumnName(nameof(UserEntity.Email)).IsRequired();
            builder.Property(x => x.Login).HasColumnName(nameof(UserEntity.Login)).IsRequired();
            builder.Property(x => x.Senha).HasColumnName(nameof(UserEntity.Senha)).IsRequired();
            builder.Property(x => x.Cpf).HasColumnName(nameof(UserEntity.Cpf)). IsRequired();
            builder.Property(x => x.DataNascimento).HasColumnName(nameof(UserEntity.DataNascimento)).IsRequired();
            builder.Property(x => x.Genero).HasColumnName(nameof(UserEntity.Genero)).IsRequired();
            builder.Property(x => x.EstadoCivil).HasColumnName(nameof(UserEntity.EstadoCivil)).IsRequired();
            builder.Property(x => x.Escolaridade).HasColumnName(nameof(UserEntity.Escolaridade)).IsRequired();
            builder.Property(x => x.Curso).HasColumnName(nameof(UserEntity.Curso)).IsRequired();
            builder.Property(x => x.ExperienciaProfissional).HasColumnName(nameof(UserEntity.ExperienciaProfissional)).IsRequired();
            builder.Property(x => x.PretensaoSalarial).HasColumnName(nameof(UserEntity.PretensaoSalarial)).IsRequired();
            builder.Property(x => x.CriadoEm).HasColumnName(nameof(UserEntity.CriadoEm)).IsRequired();
            builder.Property(x => x.AlteradoEm).HasColumnName(nameof(UserEntity.AlteradoEm));
            builder.Property(x => x.Role).HasColumnName(nameof(UserEntity.Role)).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName(nameof(UserEntity.Ativo)).IsRequired();
        }
    }
}
