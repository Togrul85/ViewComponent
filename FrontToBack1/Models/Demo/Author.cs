﻿namespace FrontToBack1.Models.Demo
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SocialPage SocialPageId { get; set; }
        public SocialPage SocialPage { get; set; } 

        public List<BookAuthor> BookAuthors { get; set; }
    }
}
