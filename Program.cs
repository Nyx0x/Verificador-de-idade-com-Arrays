using System;

namespace SegurancaBombado
{
    class Program
{
        static void Main(string[] args)
    {
        // 1. Criando lista de respostas (array)
        string[] respostasDaZoeira =
        {
            "Vai beber leite, criança.",
            "Vai ver se eu to na esquina.",
            "Parece que eu nasci ontem? Vaza!",
            "volta pro jardim de infância.",
            "Aqui não é a Disney, não. Cai fora!"
        };

        Console.WriteLine("=== BOATE DO C# ===");
        Console.WriteLine("Segurança: ...Quantos anos você tem?");

        // 2. Leitura e conversão
        string textoDigitado = Console.ReadLine();

        // O int.Parse quebra se digitarem texto
        // Mas assumindo que o usuário digite o número da idade
        int idade = int.Parse(textoDigitado);

        // 3. Decisão
        if (idade >=18)
        {
            Console.ForegroundColor = ConsoleColor.Green; // Texto Verde
            Console.WriteLine("Pode entrar. Aproveite a festa!");
        }
        else
        {
            // 4. Aleatoriedade com dado virtual
            Random dado = new Random();
        
           // 5. Pedimos para o dado "rolar" entre 0 e total de frases
           int numeroSorteado = dado.Next(respostasDaZoeira.Length);

           // 6. Pegamos a frase correspondente
           string respostaFinal = respostasDaZoeira[numeroSorteado];

           Console.ForegroundColor = ConsoleColor.Red; //Texto vermelho
           Console.WriteLine(respostaFinal);
           }

           // Reseta a cor
           Console.ResetColor();
        }
    }
}
