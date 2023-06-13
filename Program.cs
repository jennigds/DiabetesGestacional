Console.Clear();

Console.WriteLine("  DIABETES GESTACIONAL. \n  ");

Console.Write("Digite a Glicemia (em mg/dL): ");
double glicemia = Convert.ToDouble(Console.ReadLine());

if (glicemia > 126)
{
    Console.WriteLine("Diabetes Mellitus na gravidez");
    
}
else
{
    if (glicemia >= 92)
    {
        Console.WriteLine("Compatível com Diabetes Gestacional");
    }
    else
    {
        Console.WriteLine("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
    }
}
