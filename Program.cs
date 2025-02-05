// Este programa solicita dois números (a e b) ao usuário e realiza a divisão de a por b.
// Caso a operação de divisão não seja possível (por exemplo, divisão por zero),
// o programa exibe uma mensagem clara no console informando o erro ocorrido,
// garantindo que o usuário receba um retorno apropriado.
try
{
    Console.Write("Digite o numerador: ");
    int numerador = int.Parse(Console.ReadLine());

    Console.Write("Digite o denominador: ");
    int denominador = int.Parse(Console.ReadLine());

    int resultado = numerador / denominador;
    Console.WriteLine($"Resultado: {resultado}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: na matemática não é permitida a divisão por 0.");
}