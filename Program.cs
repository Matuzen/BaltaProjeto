using ProjetoBalta.ContentContext;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var course = new Course();
        foreach (var intens in course.Modules)
        {

        }
    }
}