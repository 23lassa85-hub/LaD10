Console.Write("Введите строку: ");
string s = Console.ReadLine();

Dictionary<char, int> count = new Dictionary<char, int>();
for (int i = 0; i < s.Length; i++)
{
    char c = s[i];
    if (count.ContainsKey(c))
        count[c]++;
    else
        count[c] = 1;
}
Console.WriteLine("Количество различных символов: " + count.Count);

Console.Write("Введите количество пар ключ-значение: ");
int n = int.Parse(Console.ReadLine());

Dictionary<string, int> Numbers = new Dictionary<string, int>();
for (int i = 0; i < n; i++)
{
    Console.Write("Введите ключ: ");
    string key = Console.ReadLine();
    Console.Write("Введите значение: ");
    int value = int.Parse(Console.ReadLine());
    Numbers.Add(key, value);
}

int product = 1;
foreach (var kvp in Numbers)
{
    product *= kvp.Value;
}
Console.WriteLine("Произведение: " + product);
