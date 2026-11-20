using System.Text;
namespace omarkhaled_Assign2

{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-1
            // Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            // both title and upperTitle to show that title did not change ? 
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine($"title: {title}");
            Console.WriteLine($"upperTitle: {upperTitle}");
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-2
            // Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            // to check if they point to the same object in memory ? 
            string str1 = "Clean Code";
            string str2 = "Clean Code";
            bool areSame = ReferenceEquals(str1, str2);
            Console.WriteLine($"Are str1 and str2 the same object? {areSame}");
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-3
            // Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            // object. Print the final result ? 
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine($"Final result: {sb.ToString()}");

            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-4
            // Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            // Print the result ? 
            sb.Replace("Book List", "Library");
            Console.WriteLine($"After Replace: {sb.ToString()}");
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-5
            // Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            // Pages: 464" using the + operator ? 
            string title2 = "Clean Code";
            int pages = 464;
            string sentence = "Book: " + title2 + ", Pages: " + pages;
            Console.WriteLine($"Final sentence: {sentence}");
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-6
            // Build the same sentence as above, but using string interpolation ($"...") ?
            string sentence2 = $"Book: {title2}, Pages: {pages}";
            Console.WriteLine($"Final sentence using interpolation: {sentence2}");
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-7
            // Build the same sentence again, but using string.Format() ?
            string sentence3 = string.Format("Book: {0}, Pages: {1}", title2, pages);
            Console.WriteLine($"Final sentence using Format: {sentence3}");
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-8
            // Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            // 300, otherwise prints "Short Book" ?
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-9
            // Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            // greater than 300 and isAvailable is true.Use the && operator ? 
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            else
            {
                Console.WriteLine("You cannot borrow this book");
            }
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-10
            // Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            // "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else ? 
            string title3 = "Refactoring";
            switch (title3)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-11
            // Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            // variable sizeLabel(same rule as question 8: long if pages > 300) ? 
            string sizeLabel = (pages > 300) ? "Long Book" : "Short Book";
            Console.WriteLine($"Size label: {sizeLabel}");
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-12
            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
            // to print each book with its position number, like 1.Clean Code ? 
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-13
            // Using the same books array, use a while loop to print every book title ?
            int index = 0;
            while (index < books.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-14
            // Write a do-while loop that prints "Checking book..." exactly 3 times ? 
            int count = 0;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count < 3);
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-15
            // Using the same books array, use a foreach loop to print every book title ? 
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-16
            // Using the same books array, loop through it and print each title, but stop completely (break) once
            // you reach "Refactoring" ? 
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(book);
            }
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-17
            // Using the same books array, print every title except "The Pragmatic Programmer" (skip it with
            // continue, don't stop the loop) ? 
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }
            #endregion
            Console.WriteLine("-----------------------------------------------------------");
            #region Question-18
            // Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,
            // use return to exit the method early instead of printing anything ?
            PrintFirstBook(books);
            string result = PrintFirstBook2(books);
            Console.WriteLine(result);
            #endregion
        }
        public static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return;
            }
            Console.WriteLine($"First book: {books[0]}");
        }
        public static string PrintFirstBook2(string[] books)
        {
            if (books.Length == 0)
            {
                return "No books available.";
            }
            return $"First book: {books[0]}";
        }

    }
}

