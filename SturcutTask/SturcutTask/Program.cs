using System.Runtime.InteropServices;

namespace SturcutTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ListInt list = new ListInt(8,1,2,3,4,5,6,12,34,7);
            list.Add(145);
            list.Containts(5);
            list.AddRange( 42, 19);
            list.Sum();
            list.Remove(1);
            list.RemoveRange(4, 8, 12);
            Console.WriteLine(list.ToString());
            
            


        }
    }
}
