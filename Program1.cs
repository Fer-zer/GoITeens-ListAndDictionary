// 1.
Dictionary<string, string> countries = new Dictionary<string, string>();
countries.Add("Україна", "Київ");
countries.Add("Франція", "Париж");
countries.Add("Німеччина", "Берлін");
countries.Add("Італія", "Рим");
countries.Add("Японія", "Токіо");

Console.WriteLine("Гра: Вгадай столицю країни");
foreach (var country in countries)
{
    Console.Write("Яка столиця країни " + country.Key + "? ");
    string answer = Console.ReadLine();
    if (answer != null && answer.Trim().ToLower() == country.Value.ToLower())
        Console.WriteLine("Правильно!");
    else
        Console.WriteLine("Неправильно. Правильна відповідь: " + country.Value);
}
Console.WriteLine();

// 2.
Dictionary<string, string> phoneBook = new Dictionary<string, string>();
phoneBook.Add("Ганна", "123-45-67");
phoneBook.Add("Олег", "987-65-43");
phoneBook.Add("Софія", "555-00-11");

Console.WriteLine("Телефонний довідник:");
foreach (var contact in phoneBook)
{
    Console.WriteLine(contact.Key + ": " + contact.Value);
}
Console.WriteLine();

// 3.
Dictionary<string, string> objects = new Dictionary<string, string>();
objects.Add("ключ", "лежить у скрині");
objects.Add("меч", "захований у печері");
objects.Add("карта", "на столі у хатині");

Console.WriteLine("Гра-пригода: Знайди предмет!");
foreach (var item in objects)
{
    Console.WriteLine("Предмет " + item.Key + " " + item.Value + ".");
}
Console.WriteLine();

// 4.
Dictionary<string, int> shop = new Dictionary<string, int>();
shop.Add("Хліб", 20);
shop.Add("Молоко", 30);
shop.Add("Сир", 50);
shop.Add("Яблуко", 10);

Console.WriteLine("Крамниця:");
foreach (var product in shop)
{
    Console.WriteLine(product.Key + " — " + product.Value + " грн");
}
Console.WriteLine();

// 5.
Dictionary<string, string> riddles = new Dictionary<string, string>();
riddles.Add("Сонце", "Вдень на небі, вночі його нема.");
riddles.Add("Зірка", "Мерехтить високо в небі.");
riddles.Add("Дерево", "Має листя, коріння й стовбур.");

Console.WriteLine("Квест із загадками:");
foreach (var riddle in riddles)
{
    Console.WriteLine("Загадка: " + riddle.Value);
    Console.Write("Відповідь: ");
    string answer = Console.ReadLine();
    if (answer != null && answer.Trim().ToLower() == riddle.Key.ToLower())
        Console.WriteLine("Правильно!\n");
    else
        Console.WriteLine("Неправильно. Відповідь: " + riddle.Key + "\n");
}

// 6.
Dictionary<string, int> marks = new Dictionary<string, int>();
marks.Add("Андрій", 10);
marks.Add("Марія", 12);
marks.Add("Ігор", 8);
marks.Add("Оксана", 9);

Console.WriteLine("🏫 Оцінки учнів:");
foreach (var mark in marks)
{
    Console.WriteLine(mark.Key + ": " + mark.Value + " балів");
}
Console.WriteLine();

// 7.
Dictionary<string, string> dictionary = new Dictionary<string, string>();
dictionary.Add("hello", "привіт");
dictionary.Add("sun", "сонце");
dictionary.Add("apple", "яблуко");
dictionary.Add("friend", "друг");

Console.WriteLine("Перекладач:");
Console.Write("Введи слово англійською: ");
string eng = Console.ReadLine();
if (eng != null && dictionary.ContainsKey(eng))
    Console.WriteLine("Переклад: " + dictionary[eng]);
else
    Console.WriteLine("Такого слова немає у словнику.");
Console.WriteLine();

// 8.
Dictionary<string, int> fruits = new Dictionary<string, int>();
fruits.Add("Яблука", 15);
fruits.Add("Груші", 8);
fruits.Add("Сливи", 12);

Console.WriteLine("Фруктовий сад:");
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit.Key + ": " + fruit.Value + " шт.");
}
Console.WriteLine();

// 9.
int total = 0;
foreach (var mark in marks)
{
    total += mark.Value;
}

double average = (double)total / marks.Count;
Console.WriteLine("Середня оцінка у класі: " + average);

