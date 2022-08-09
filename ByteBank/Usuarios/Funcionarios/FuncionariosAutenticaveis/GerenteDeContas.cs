namespace ByteBank.Usuarios.Funcionarios.FuncionariosAutenticaveis{

    internal class GerenteDeContas : FuncionarioAutenticavel {

        internal GerenteDeContas(string nome, string cpf, double salario, string senha) : base(nome, cpf, 3000, senha) { }

        internal override void AumentarSalario() { Salario *= 1.05; }

        internal override double Bonificacao() => Salario * 1.25;
    }
}
