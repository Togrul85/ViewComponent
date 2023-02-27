namespace FrontToBack1.Models.Demo
{
    public class Book
    {
        public int Id { get; set; }
        public List<BookImages> BookImages { get; set; }
        public List<BookAuthor> bookAuthors { get; set; }

    }
}
