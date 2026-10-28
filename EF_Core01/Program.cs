using EF_Core01.Contexts;

namespace EF_Core01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using BookStoreDBContext dbContext = new BookStoreDBContext();
        }
    }
}
