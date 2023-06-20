Console.Clear();
int chute, numSecreto, tentativas = 0;
int maxTentativas = 7;

Random rd = new Random();
int rand_num = rd.Next(1,101);
numSecreto = rand_num;


// Muda a cor da letra 
Console.ForegroundColor = ConsoleColor.Blue;
// Escreve a letra J
Console.Write("J");
// Delay de 1 segundo para exibição
Thread.Sleep(190);

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("O");
Thread.Sleep(190);     

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("G");
Thread.Sleep(190);

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("O");
Thread.Sleep(190);     

Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" ");
Thread.Sleep(190);

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("D");
Thread.Sleep(190);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("O");
Thread.Sleep(190);     

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(" ");
Thread.Sleep(190);

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("A");
Thread.Sleep(190);     

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("D");
Thread.Sleep(190);

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("I");
Thread.Sleep(190);

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("V");
Thread.Sleep(190);     

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("I");
Thread.Sleep(190);

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("N");
Thread.Sleep(190);     

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("H");
Thread.Sleep(190);

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("A");
Thread.Sleep(190);

Console.ResetColor();
Console.WriteLine();

Console.ForegroundColor =  ConsoleColor.Yellow;
Console.WriteLine($"No jogo o computador sorteará um número entre 1 e 100 para ser o número secreto que o jogador deverá adivinhar.");  
Thread.Sleep(2000);
Console.WriteLine($"O jogador dará palpites até que acerte o número secreto e ganhe o jogo, ou erre 7 vezes e perca o jogo.");    
Thread.Sleep(2000);
Console.WriteLine($"\naperte a tecla ENTER para continuar");    
Thread.Sleep(2000);
Console.ReadLine();
Console.WriteLine($"\nO número secreto está sendo sorteado....");  
Thread.Sleep(2000);
Console.WriteLine($"\nPor Favor Aguarde....");  
Thread.Sleep(2000);
Console.WriteLine($"\nProntinho número sorteado, agora vamos ver se você é um bom adivinha HAHAHA");  
Thread.Sleep(2000);
Console.ResetColor();


Console.ForegroundColor =  ConsoleColor.Green;
Console.WriteLine($"\n-------------------------------------------------------------------------------------------------------------------");
Thread.Sleep(2000);
Console.ResetColor();

Console.ForegroundColor =  ConsoleColor.White;
Console.WriteLine($"\nDigite o número que voce acha que foi o sorteado:"); 
chute = int.Parse(Console.ReadLine()!); 
Thread.Sleep(2000);
Console.ResetColor();
    
do {
    tentativas++;


    int diferenca = chute - numSecreto;
    if (diferenca < 0)
    {
        diferenca = diferenca * -1;
    }
    


            if(diferenca <= 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if(chute > numSecreto)
                {
                    Console.WriteLine("está PELANDO, o número secreto é menor");
                }
                else
                {
                    Console.WriteLine("está PELANDO, o número secreto é maior");
                }
                Console.ResetColor();
            }

            else if(diferenca <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (chute > numSecreto)
                {
                    Console.WriteLine("está QUENTE, o número secreto é menor");
                }
                else
                {
                    Console.WriteLine("está QUENTE, o número secreto é maior");
                }
                Console.ResetColor();

            }
            else if (diferenca <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                if(chute > numSecreto)
                {
                    Console.WriteLine("está FRIO, o número secreto é menor");
                }
                else
                {
                    Console.WriteLine("está FRIO, o número secreto é maior");
                }
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if(chute > numSecreto)
                {
                    Console.WriteLine("está CONGELANDO, o número secreto é menor");
                }
                else
                {
                Console.WriteLine("está CONGELANDO, o número secreto é maior");
                }
                Console.ResetColor();
            }

        Console.ForegroundColor =  ConsoleColor.White;
        Console.WriteLine("Digite o número que você acha que foi o sorteado:");
        chute = int.Parse(Console.ReadLine()!);
        Console.ResetColor();

        if(tentativas == maxTentativas)
        {
            Console.WriteLine($"Você atingiu o limite de tentativas, o número secreto era {numSecreto}");
        }

        


}while (numSecreto != chute && tentativas < maxTentativas);

if(chute == numSecreto) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Parabéns, Você acertou o número secreto {numSecreto}!!!");
    Console.ResetColor();
}
