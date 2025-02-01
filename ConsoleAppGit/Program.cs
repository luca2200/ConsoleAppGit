namespace ConsoleAppGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           Dado dado = new Dado();
           int valore = dado.LanciaDado();
           Console.WriteLine(valore);
        }
    }
}
