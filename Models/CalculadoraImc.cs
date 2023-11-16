namespace BodyMassindex.Models
{
    public static class CalculadoraImc
    {
        public static double Indicedemasacorporal (double peso, double estatura)
                 => peso / Math.Pow(estatura, 2);
        public enum EstadoNutrcional
        {

            PesoBajo,
            PesoNormal,
            SobrePeso,
            Obesidad,
            ObesidadExtrema
        }

        public static EstadoNutrcional SituacionNutricional(double imc)
        {
        if (imc < 18.5)
            {
                return  EstadoNutrcional.PesoBajo;
            }
        else if (imc <25.0)
            {
                return EstadoNutrcional.PesoNormal;
            }
        else if (imc < 30.0)
            {
                return EstadoNutrcional.SobrePeso;
            }
         else if (imc < 40.0)
            {
                return EstadoNutrcional.Obesidad;
            }
         else
            {
                return EstadoNutrcional.ObesidadExtrema;
            }
        }
    }
}
