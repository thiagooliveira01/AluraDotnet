﻿using System.ComponentModel.DataAnnotations;

namespace Alura.Filmes.App.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AnoLancamento { get; set; }
        public short Duracao { get; set; }

        public override string ToString()
        {
            return $"Filme ({Id}): {Titulo} - {AnoLancamento}";
        }
    }
}
