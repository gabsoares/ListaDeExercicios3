string option = "";

while (option != "N" && option != "n")
{
    Console.WriteLine("Digite a temperatura em Celsius para converter em Fahrenheit");
    double temperature = Convert.ToDouble(Console.ReadLine());

    double fahrenheit = (temperature * 1.8) + 32;

    Console.WriteLine($"A temperatura convertida eh {fahrenheit}F");


    Console.Write("Digite S/N para continuar ou não: ");
    option = Console.ReadLine();
}











