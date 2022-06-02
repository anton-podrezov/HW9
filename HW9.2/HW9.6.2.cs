//Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек.
//Сортировка должна происходить при помощи события.
//Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А).

//Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию
//TryCatchFinally с использованием собственного типа исключения.


NumberReader numberReader = new NumberReader();
numberReader.NumberReaderEvent += SortSecondName;
while (true)
{
    try
    {
        numberReader.Read();
    }

    catch (FormatException)
    {
        Console.WriteLine("Введено некорректное значение");
        Console.WriteLine();
    }
}

static void SortSecondName(int number)
{
    string[] users = new string[5];
    users[0] = "Арбузиков";
    users[1] = "Помидорчиков";
    users[2] = "Дынькин";
    users[3] = "Клубничкин";
    users[4] = "Путин";

    switch (number)
    {
        case 1:
            Array.Sort(users);
            break;

        case 2:
            Array.Sort(users);
            Array.Reverse(users);
            break;
    }

    foreach (string user in users)
    {
        Console.WriteLine(user);
        
    }
    Console.WriteLine();
}

class NumberReader
{
    public delegate void NumberReaderDelegate(int number);
    public event NumberReaderDelegate NumberReaderEvent;

    public void Read()
    {
        Console.WriteLine("Введите число 1 - для сортировки от А-Я или 2 для сортировки от Я-А");

        int numberSort = Convert.ToInt32(Console.ReadLine());

        if (numberSort != 1 && numberSort != 2) throw new FormatException();

        NumberEntered(numberSort);

    }

    protected virtual void NumberEntered(int number)
    {
        NumberReaderEvent?.Invoke(number);
    }
}