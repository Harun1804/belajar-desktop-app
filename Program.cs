namespace Belajar 
{
    class Program
    {
        static void Main() 
        {
            Console.WriteLine(Cube(5));
        }

        static int Cube(int num) 
        {
            int result = num * num * num;
            return result;
        }
    }
}