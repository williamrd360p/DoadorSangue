Console.Clear();
int idade;

Console.Write("Insira sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18 && idade <= 67)
{
    Console.WriteLine("Parabéns! Você pode ser doador de sangue. :D");
}
else
{
    Console.WriteLine("Poxa! Você não pode ser doador de sangue.:(");
}
