using ByteBank.Usuarios;

namespace ByteBank.Funcionarios {
    internal abstract class Funcionario : Pessoa {

        private double _salario;
        internal static int TotalDeFuncionarios { get; private set; }

        internal Funcionario(string nome, string cpf, double salario) : base(nome, cpf) {
            _salario = salario;
            TotalDeFuncionarios++;
        }

        internal double Salario {
            get => _salario;
            set {
                if (value <= 1212.00 || value > 100000.00)
                    Console.WriteLine("\nValor Inválido!");
                else _salario = value;
            }
        }

        internal abstract void AumentarSalario();

        internal abstract double Bonificacao();

        public override string ToString() => base.ToString() + "\nSalario: " + Salario;
    }
}
