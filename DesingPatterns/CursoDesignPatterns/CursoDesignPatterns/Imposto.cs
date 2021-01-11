namespace CursoDesignPatterns
{
    public abstract class Imposto
    {
        protected Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        protected Imposto()
        {
            OutroImposto = null;
        }

        public Imposto OutroImposto { get; set; }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;

            return OutroImposto.Calcula(orcamento);
        }
    }
}