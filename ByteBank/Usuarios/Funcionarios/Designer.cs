namespace ByteBank.Funcionarios {
    internal class Designer : Funcionario {

        internal Designer(string nome, string cpf) : base(nome, cpf, 3000) { }

        internal override void AumentarSalario() { Salario *= 1.1; }

        internal override double Bonificacao() => Salario * 1.3;
    }
}
