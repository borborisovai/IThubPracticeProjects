using ControlPoint1;
List<string> books = new List<string>();
books.Add("Homestuck");

Library library = new Library("Sburb", books);
Reader reader = new Reader("John", "Eggbert");

reader.ReadBook(library, "Homestuck");
reader.ReadBook(library, "SomeNeardyBook");