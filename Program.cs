Console.Write("Введите фамилию: ");
string? name = Console.ReadLine();

Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите специальность: ");
string? spec = Console.ReadLine();

Console.Write("Введите номер группы: ");
decimal group = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Анкета обучающегося: ");
Console.WriteLine($"Фамилия обучающегося по буквам: ");
foreach (var i in name)
{
    Console.WriteLine(i);
}

Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Рост: {height}");
Console.WriteLine($"Специальность: {spec}");
Console.WriteLine($"Номер группы: {group}");

if (age >= 17 && height >= 170)
{
    Console.WriteLine($"Обучающийся может состоять в баскетбольной команде и команде по шахматам");
}
else if (age >= 17 && height < 170)
{
    Console.WriteLine($"Обучающийся может состоять только в команде по шахматам");
}
else if (age < 17) {
    Console.WriteLine($"Увидимся в следующем году");
}