using System.Text.RegularExpressions;

namespace ByteBank.Usuarios {
    internal abstract class Pessoa {

        private string _nome;
        private string _cpf;

        internal Pessoa(string nome, string cpf) {
            _nome = nome;
            _cpf = cpf;
        }

        internal string Nome {
            get => _nome;
            set {
                if (value == null || value == "" || value.Length < 3)
                    Console.WriteLine("\nNome Inválido!");
                else _nome = value;
            }
        }

        internal string Cpf {
            get => _cpf;
            private set {
                if (!Regex.IsMatch(value, @"/^([0-9]{3}.[0-9]{3}.[0-9]{3}-[0-9]{2})|([0-9]{11})$/"))
                    Console.WriteLine("\nCPF Inválido!");
                else _cpf = value;
            }
        }

        public override string ToString() => "\nNome: " + _nome + "\nCpf: " + _cpf;
    }
}
