using Library;
using System.Diagnostics.CodeAnalysis;


List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

books.Add(new Book("C# for beginners", "BillGates", "12345678"));
books.Add(new Book("C# Methods and classes", "Microsoft", "55667778"));

members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));


// Create new instances of the Member class
// These new members are created using the
// Member constructor in the Members class

//display all the items in the book list 

Console.WriteLine("*********************");
Console.WriteLine("Current library books");
Console.WriteLine("*********************");
Console.WriteLine();

foreach (Book book in books)
{
   
    Console.WriteLine(book.Title);
    Console.WriteLine(book.Author);
    Console.WriteLine(book.ISBN);
    Console.WriteLine();
}
Console.WriteLine("*********************");
Console.WriteLine("Current library members");
Console.WriteLine("*********************");
Console.WriteLine();

foreach (Member member in members)
{
    Console.WriteLine($"Member name: {member.Name}");
    Console.WriteLine($"Member address: {member.Address}");
    Console.WriteLine($"Member phone: {member.Phone}");
    Console.WriteLine();
}





