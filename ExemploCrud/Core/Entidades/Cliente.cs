using System;

namespace ExemploCrud.Core.Entidades
{
    internal class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}