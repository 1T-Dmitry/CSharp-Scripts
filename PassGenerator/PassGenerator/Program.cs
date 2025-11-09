using System.Security.AccessControl;

Console.WriteLine("Длина пароля: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Выберите несколько или один пункт для генерации.\n1. Генерация со специальными знаками.\n"
    + "2. Генерация с буквами.\n3. Генерация c цифрами.\nНапример: 23");

int choices = Convert.ToInt32(Console.ReadLine());
string password = "";

if (choices == 1)
{
    string symbols = "!@#$%^&*()_+90-=№;:?{}/.,'\"`~<>";
    
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        password += symbols[random.Next(0, symbols.Length - 1)];
    }

    Console.WriteLine($"Пароль: {password}");
} 
else if (choices == 2)
{
    string symbols = "qwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбю";

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        if (random.Next(1, 3) == 1)
        {
            password += symbols.ToUpper()[random.Next(0, symbols.Length - 1)];
        }
        else
        {
            password += symbols[random.Next(0, symbols.Length - 1)];
        }
    }

    Console.WriteLine($"Пароль: {password}");
}
else if (choices == 3)
{
    string symbols = "0123456789";

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        password += symbols[random.Next(0, symbols.Length - 1)];
    }

    Console.WriteLine($"Пароль: {password}");
}
else if (choices == 12)
{
    string symbols1 = "!@#$%^&*()_+90-=№;:?{}/.,'\"`~<>";
    string symbols2 = "qwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбю";

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        if (random.Next(1, 3) == 1)
        {
            password += symbols1[random.Next(0, symbols1.Length - 1)];
        }
        else
        {
            password += symbols2[random.Next(0, symbols2.Length - 1)];
        }
    }

    Console.WriteLine($"Пароль: {password}");
}
else if (choices == 13)
{
    string symbols1 = "!@#$%^&*()_+90-=№;:?{}/.,'\"`~<>";
    string symbols2 = "0123456789";

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        if (random.Next(1, 3) == 1)
        {
            password += symbols1[random.Next(0, symbols1.Length - 1)];
        }
        else
        {
            password += symbols2[random.Next(0, symbols2.Length - 1)];
        }
    }

    Console.WriteLine($"Пароль: {password}");
}
else if (choices == 23)
{
    string symbols1 = "qwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбю";
    string symbols2 = "0123456789";

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        if (random.Next(1, 3) == 1)
        {
            password += symbols1[random.Next(0, symbols1.Length - 1)];
        }
        else
        {
            password += symbols2[random.Next(0, symbols2.Length - 1)];
        }
    }

    Console.WriteLine($"Пароль: {password}");
}
else
{
    string symbols1 = "!@#$%^&*()_+90-=№;:?{}/.,'\"`~<>";
    string symbols2 = "qwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбю";
    string symbols3 = "0123456789";

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        if (random.Next(1, 4) == 1)
        {
            password += symbols1[random.Next(0, symbols1.Length - 1)];
        }
        else if (random.Next(1, 4) == 2)
        {
            password += symbols2[random.Next(0, symbols2.Length - 1)];
        }
        else
        {
            password += symbols3[random.Next(0, symbols3.Length - 1)];
        }
    }

    Console.WriteLine($"Пароль: {password}");
}
