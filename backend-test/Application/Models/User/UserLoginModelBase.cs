namespace Application.Models.User
{
    public class UserLoginModelBase
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        //public bool SenhaValida(string senha)
        //{
        //    return Senha == senha.GerarHash();
        //}

        //public void SetSenhaHash() => Senha = Senha.GerarHash();
    }
}
