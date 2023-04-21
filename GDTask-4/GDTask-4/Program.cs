Console.Write("Введите код символа: ");

int code = Convert.ToInt32(Console.ReadLine());

void decoder(int code)
{
    if (code > 255)
    {
        code = code - 256;
        Console.Write($"Символ в соответствии с кодом {code} : {Convert.ToChar(code)}");
    }
    else if (code < 0)
    {
        Console.WriteLine("Код не может быть меньше нуля. Повторите попытку.");
    }
    else
    {
        Console.Write($"Символ в соответствии с кодом {code} : {Convert.ToChar(code)}");
    }
    
}

decoder(code);