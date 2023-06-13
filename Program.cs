namespace Alice_Bookshelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader read = new StreamReader(@"..\..\..\Input.txt");
            string inputString = read.ReadLine();

            Stack<char> bookShelf = new Stack<char>();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '\\')
                {
                    Queue<char> temp = new Queue<char>();
                    char x;

                    while((x = bookShelf.Pop()) != '/')
                        temp.Enqueue(x);

                    while(temp.Count > 0)
                        bookShelf.Push(temp.Dequeue());
                }
                else
                    bookShelf.Push(inputString[i]);
            }

            string output = string.Concat(bookShelf.ToArray().Reverse());

            Console.WriteLine(output);
        }
    }
}