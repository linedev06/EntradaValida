 Console.WriteLine(" --- Entrada Válida ---");

 Console.Write("DIgite um valor entre 1 e 9 (Digite 0 para reiniciar): ");
 int num = int.Parse(Console.ReadLine()!);

while (num < 0 || num > 9)
{
     Console.WriteLine("", ConsoleColor.White);
     Console.WriteLine("Digite um número entre 1 e 9 (ou 0 para cancelar a operação)...", ConsoleColor.White);
   num = int.Parse(Console.ReadLine()!);
}

if (num >= 1 && num <= 9)
{
Console.WriteLine($"O valor digitado é igual a {num}");
}
else if (num == 0)
{
 Console.WriteLine("A operação foi encerrada!", Console.ForegroundColor = ConsoleColor.DarkRed);
 Console.ResetColor();
 return;    
}