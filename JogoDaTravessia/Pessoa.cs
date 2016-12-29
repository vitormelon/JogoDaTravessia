using System.Collections.Generic;

namespace JogoDaTravessia
{
    class Pessoa
    {
        public string Nome;
        public List<Pessoa> NaoPodeFicarSozinhoCom;
        public List<Pessoa> DeveAcompanhar;
        public bool PodeDirigir;

        public Pessoa(string nome, bool podeDirigir)
        {
            Nome = nome;
            PodeDirigir = podeDirigir;
            NaoPodeFicarSozinhoCom = new List<Pessoa>();
            DeveAcompanhar = new List<Pessoa>();
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
