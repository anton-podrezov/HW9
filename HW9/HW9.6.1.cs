// 1 Создайте свой тип исключения.

// 2 Сделайте массив из пяти различных видов исключений, включая собственный тип исключения.
// Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).

// 3 В блоке catch выведите в консольном сообщении текст исключения.


Exception[] exceptions = new Exception[5];
exceptions[0] = new MyException();
exceptions[1] = new DivideByZeroException();
exceptions[2] = new IndexOutOfRangeException();
exceptions[3] = new OverflowException();
exceptions[4] = new RankException();


foreach (Exception ex in exceptions)
{
    try
    {
        throw ex;
    }
    catch (Exception e) when (e is MyException)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e) when (e is DivideByZeroException)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e) when (e is IndexOutOfRangeException)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e) when (e is OverflowException)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e) when (e is RankException)
    {
        Console.WriteLine(e.Message);
    }

}
class MyException : Exception
{
    public MyException()
    {

    }
    public MyException(string message) : base(message)
    {

    }
}