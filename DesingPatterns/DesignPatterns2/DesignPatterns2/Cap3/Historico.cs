﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap3
{
    public class Historico
    {
        private IList<Estado> Estados = new List<Estado>();

        public Estado Pega(int index)
        {
            return Estados[index];
        }

        public void Adiciona(Estado estado)
        {
            Estados.Add(estado);
        }
    }
}
