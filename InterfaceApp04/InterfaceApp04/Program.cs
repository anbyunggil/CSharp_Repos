
interface iLogger
{
    void WriteLog(string message);
}

class ConsoleLooger : iLogger
{
    public void writeLog(string message)
    {
        Console.WriteLine($"{DateTime.Now.ToLocalTime()} : {message}");
    }
}
class MainClass
{ 
    public static void Main(string[] args)
    {
    ConsoleLooger looger = new ConsoleLooger();
    looger.writeLog("장애 이벤ㅌ트 발생");
    }
}
