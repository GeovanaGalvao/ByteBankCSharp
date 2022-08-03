namespace ByteBank.Funcionarios {
    internal class GerenteDeContas : Funcionario {

        internal GerenteDeContas(string nome, string cpf) : base(nome, cpf, 4000) { }

        internal override void AumentarSalario() { Salario *= 1.05; }

        internal override double Bonificacao() => Salario * 1.25;
    }
}
