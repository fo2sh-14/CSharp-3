namespace Ass_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st answer
            Book Book_01 = new Book();
            Book_01.Title = "C#";
            Book_01.Pages = 100;

            object obj = Book_01;
            Console.WriteLine(obj);
            Console.WriteLine($"Title : {Book_01.Title} - Pages : {Book_01.Pages}");
            #endregion

            #region 2st answer
            Console.WriteLine(Book_01.Pages.ToString());
            Console.WriteLine(Book_01.Equals(obj));
            Console.WriteLine(Book_01.GetHashCode());
            Console.WriteLine(Book_01.GetType().Name);
            #endregion

            #region 3st answer
            //int pagess = "468"; ==> compile-time error 
            int pages = 468;
            #endregion

        }
    }
}
