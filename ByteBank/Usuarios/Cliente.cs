using ByteBank.Usuarios;

namespace ByteBank {
    internal class Cliente : Pessoa{
        private string _genero, _profissao;
        private int _idade;

        internal Cliente(string nome, string genero, string cpf, string profissao, int idade) : base(nome, cpf){
            _genero = genero;
            _profissao = profissao;
            _idade = idade;
        }

        internal string Genero { get => _genero;
            set {
                if (value != "M" || value != "F") {
                    Console.WriteLine("\nGenero Inválido!");
                }
                else _genero = value;
            }
        }

        internal string Profissao { get => _profissao;
            set {
                if (value == null || value == "") {
                    Console.WriteLine("\nProfissão Inválida!");
                }
                else _profissao = value;
            }
        }

        internal int Idade { get => _idade;
            set {
                if (!int.TryParse(Console.ReadLine(), out value) || value < 18 || value > 120) {
                    Console.WriteLine("\nIdade inválida!");
                }
                else _idade = value;
            }
        }
        public override string ToString() => base.ToString() + "\nIdade: " + _idade + "\nGenero: "
            + _genero + "\nProfissão: " + _profissao;
    }
}
