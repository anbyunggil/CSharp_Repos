// See https://aka.ms/new-console-template for more information

interface iWing
{
    public void Fly();
}
class Horse
{

}
class Unicon : Horse, iWing
{
    public void Fly()
    {
        Console.WriteLine("유니콘이 날다. ");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Unicon u = new Unicon();
        u.Fly();
    }
}
