namespace ByteBank.Usuarios.Funcionarios.FuncionariosAutenticaveis {
    internal class Diretor : FuncionarioAutenticavel {

        internal Diretor(string nome, string cpf, double salario, string senha) : base(nome, cpf, 4000, senha) { }

        internal override void AumentarSalario() { Salario *= 1.15; }

        internal override double Bonificacao() => Salario;
    }
}
