using ByteBank.Funcionarios;
using ByteBank.SistemaInterno;

namespace ByteBank.Usuarios.Funcionarios.FuncionariosAutenticaveis {
    internal abstract class FuncionarioAutenticavel : Funcionario, IAutenticacao
    {

        private string _senha;

        internal FuncionarioAutenticavel(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario) { Senha = senha; }

        internal string Senha
        {
            get => _senha;
            set
            {
                if (value == null || value == "" || value.Length < 5)
                    Console.WriteLine("\nSenha Invalida!");
                else _senha = value;
            }
        }

        bool IAutenticacao.Autentica(string senha) => Senha == senha;
    }
}
