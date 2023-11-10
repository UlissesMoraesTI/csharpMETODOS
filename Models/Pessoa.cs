using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploMetodosConstrutores.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            SobreNome = sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome
        {

            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome é Obrigatório");
                }

                _nome = value;
            }
        }

        public string SobreNome { get; set; }

        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();

        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade Não pode ser negativa");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade {Idade} anos.");
        }
    }
}