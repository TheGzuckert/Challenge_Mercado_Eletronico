// PROVA ADA 2023 GUSTAVO ZUCKERT
int escolha;

do
{
  Console.WriteLine("\n------------PROVA DA ADA------------\n");
  Console.WriteLine("1 - Exercício um");
  Console.WriteLine("2 - Exercício dois");
  Console.WriteLine("3 - Exercício três");
  Console.WriteLine("4 - Visualizar respota questão 4");
  Console.WriteLine("5 - Visualizar respota questão 5");
  Console.WriteLine("6 - Para encerrar o programa");
  Console.Write("\nOpção escolhida: ");

  if (int.TryParse(Console.ReadLine(), out escolha))
  {
    switch (escolha)
    {
      case 1:
        // Entrada dos numeros impares pares positivos e negativos
        int[] numeros = new int[5];
        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
          Console.Write($"\nDigite o {i + 1} número: ");
          numeros[i] = int.Parse(Console.ReadLine());
        }

        // Verificação dos numeros
        for (int i = 0; i < numeros.Length; i++)
        {
          if (numeros[i] % 2 == 0)
          {
            pares++;
          }
          else
          {
            impares++;
          }

          if (numeros[i] > 0)
          {
            positivos++;
          }
          else
          {
            negativos++;
          }
        }

        // Resultado
        Console.WriteLine($"\nVocê digitou {pares} números pares.");
        Console.WriteLine($"Você digitou {impares} números ímpares.");
        Console.WriteLine($"Você digitou {positivos} números positivos.");
        Console.WriteLine($"Você digitou {negativos} números negativos.");
        break;

      case 2:
        // Entrada dos numeros N1 e N2
        Console.WriteLine("Digite o primeiro número:");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double n2 = double.Parse(Console.ReadLine());

        // Inicialização das variáveis
        double resultadoMult = 0;
        double div = n1;
        double resultadoDiv = 0;

        // Verificação caso um dos números seja divisível por 0
        if (n1 == 0 || n2 == 0)
        {
          Console.WriteLine("Número divisível por 0 não é válido.");
          return;
        }

        // Verificação caso o número seja negativo
        while (div >= n2)
        {
          div -= n2;
          resultadoDiv++;
        }

        double resto = div;

        for (int i = 0; i < n2; i++)
        {
          resultadoMult += n1;
        }

        // Resultado
        Console.WriteLine("O resultado da multiplicação é: " + resultadoMult);
        Console.WriteLine("O resultado da divisão é: " + resultadoDiv);
        Console.WriteLine("O resto da divisão é: " + resto);
        break;
      case 3:

      // Recebe a frase
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();

        string[] palavras = frase.Split(' ');

        int maiusculas = 0;
        int minusculas = 0;
        int maiusculaInicio = 0;
        int minusculaInicio = 0;

        foreach (string palavra in palavras)
        {
          // Verifica se a palavra é nula ou vazia
          if (!string.IsNullOrEmpty(palavra))
          {
            // Verifica se a palavra começa com maiuscula
            if (char.IsUpper(palavra[0]))
            {
              maiusculaInicio++;
            }
            else
            {
              minusculaInicio++;
            }
            // Verifica se a palavra é maiuscula
            if (palavra.Equals(palavra.ToUpper()))
            {
              maiusculas++;
            }
            // Verifica se a palavra é minuscula
            else if (palavra.Equals(palavra.ToLower()))
            {
              minusculas++;
            }
          }
        }
        // Resultado
        Console.WriteLine($"Palavras Maiúsculas: {maiusculas}");
        Console.WriteLine($"Palavras Minúsculas: {minusculas}");
        Console.WriteLine($"Palavras que começam com Maiúscula: {maiusculaInicio}");
        Console.WriteLine($"Palavras que começam com Minúscula: {minusculaInicio}");
        Console.WriteLine($"Total de Palavras digitadas: {palavras.Length}");
        break;

      case 4:
        // Resultado por extenso
        Console.WriteLine("\nALTERNATIVA CORRETA: C)\n\nJUSTIFICATIVA:\nO codigo está fazendo uma comparação entre dois numeros inteiros, 21 e 21.\nO operador > significa maior que, e o operador ! significa negação.\nComo 21 não é maior que 21, o resultado é falso, e a negação de falso é verdadeiro.\nPor isso o resultado é 1.");
        break;
      case 5:
        // Resultado por extenso
        Console.WriteLine("\nALTERNATIVA CORRETA: E)\n\nO codigo soma sempre de três em três, começando em -5 e terminando em 7\nEm cada uma das opereções ele soma 3 ao valor anterior\nPor isso ele vai de -5, -2, 1, 4, 7\nSomando de 3 em 3, até chegar em 7");
        break;
      case 6:
      // Encerra o programa caso o usuario escolha a opção 6
        Console.WriteLine("\nEncerrando o programa...\n\nPrograma finalizado\n\nAté mais ^^\n");
        break;
      default:
      // Caso o usuario escolha uma opção invalida Ex: 7,8,9,10,11...
        Console.WriteLine("\nOpção inválida. Por favor, escolha uma opção válida.");
        break;
    }
  }
  else
  {
    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
  }

} while (escolha != 6);

// Atenciosamente Gustavo Zuckert