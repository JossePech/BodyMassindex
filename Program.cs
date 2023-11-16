using BodyMassindex.Models;

string? nombre;
string? entrada;
double peso;
double estatura;
double imc;

Persona persona;

Console.WriteLine("Aplicación que calcula el indice de masa corporal de una persona");

//Obtener datos de entrada
//Datos a obtener:nombre,peso y la estatura de la persona
Console.WriteLine("Proporcione el nombre de la persona");
nombre=Console.ReadLine();
peso = ReadDouble("Proporcione el peso en kilogramos  de la persona");
estatura = ReadDouble("Proporcione la estatura en metros   de la persona");

persona = new Persona(nombre, peso, estatura);

//Calcular el índice de masa corporal
//double- imc = peso /(estatura * estatura)
imc = CalculadoraImc.Indicedemasacorporal(persona.Peso, persona.Estatura);
Console.WriteLine($"Indice de masa corporal de {nombre}: { imc:F4}");

//Determinar la situacion nutricional de la persona

double  ReadDouble(string? s)
{
    Console.WriteLine(s);
    string? linea = Console.ReadLine();
    return Convert.ToDouble(linea);
}
string SituacionNutricionalComoTexto(double Imc)
{
    CalculadoraImc.EstadoNutrcional estadoNutrcional =
     CalculadoraImc.SituacionNutricional(Imc);
    
    switch(estadoNutrcional)
    {
        case CalculadoraImc.EstadoNutrcional.PesoBajo:
            return "Peso Bajo";
        case CalculadoraImc.EstadoNutrcional.PesoNormal:
            return "Peso Normal";
        case CalculadoraImc.EstadoNutrcional.SobrePeso:
            return "Sobre Peso";
        case CalculadoraImc.EstadoNutrcional.Obesidad:
            return "Obesidad";
        case CalculadoraImc.EstadoNutrcional.ObesidadExtrema:
            return "Obesidad Extrema";
        default:
            return string.Empty;
    }
}
