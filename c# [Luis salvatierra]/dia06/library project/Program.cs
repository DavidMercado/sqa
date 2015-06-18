using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static Library library = new Library("The black cat");
        public static void Main(string[] args){            

            ConsoleKeyInfo tecla;

            do{
                Console.Clear(); //Limpiar la pantalla
                Console.WriteLine("\t\t\t Menú - The Black Cat Library \n");
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.Write("[A] All\t");
                Console.Write("[G] Get by id\t");
                Console.Write("[R] Remove\t");
                Console.Write("[U] Update\t");
                Console.Write("[D] Add\t");
                Console.Write("[Esc] Exit\t\n\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose a option...");
                tecla = Console.ReadKey(false);//Que no muestre la tecla señalada

                //métodos son acciones, las propiedades son valores
                switch (tecla.Key){
                    case ConsoleKey.A:
                        Console.WriteLine("You select the option :ALL:");
                        all();
                        Console.Write("Press any key to continue ...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.G:
                        Console.WriteLine("You select the option :GET BY ID:");
                        getById();
                        Console.Write("Press any key to continue ...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.R:
                        Console.WriteLine("You select the option :REMOVE:");
                        remove();
                        Console.Write("Press any key to continue ...");
                        Console.ReadKey();                        
                        break;

                    case ConsoleKey.U:
                        Console.WriteLine("You select the option :UPDATE:");
                        updateTitle();
                        Console.Write("Press any key to continue ...");
                        Console.ReadKey();                        
                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("You select the option :ADD:");
                        add();
                        Console.Write("Press any key to continue ...");
                        Console.ReadKey();                        
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Bye ...");

                        break;
                }
            } while (tecla.Key != ConsoleKey.Escape);
        }//FIN MAIN

        private static void all(){
            if (library.all().Count() == 0){
                Console.WriteLine("The library is empty, adds a book ...");
            }
            else{
                List<Book> books = library.all();
                foreach (Book book in books){
                    Console.WriteLine("ID: " + book.getId() + " TITULO: " + book.getTitulo() + " AUTOR: " + book.getAutor() + " CATEGORIA: " + book.getCategoria());
                }
            }
        }

        //PRECONDITION OF DATA READ IS INTEGER
        private static void getById(){
            Console.WriteLine("Enter the id to search the book");
            int id = Convert.ToInt32(Console.ReadLine());

            Book book = library.getById(id);
            if (book != null)
            {
                Console.WriteLine("ID: " + book.getId() + " TITLE: " + book.getTitulo() + " AUTHOR: " + book.getAutor() + " Category: " + book.getCategoria());
            }
            else{
                Console.WriteLine("The Book not exits ...");
            }                      
        }

        //PRECONDITION OF DATA READ IS INTEGER
        private static void remove(){
            Console.WriteLine("Enter the id to remove the book");
            int id = Convert.ToInt32(Console.ReadLine());

            if (library.remove(id))
            {
                Console.WriteLine("The book is removed");
            }
            else
            {
                Console.WriteLine("The Book not exits ...");
            }
        }

        //UPDATE WITH TITLE BOOK
        private static void updateTitle(){
            Console.WriteLine("Enter the ID of the book modified");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the new title of the book");
            string newTitle = Console.ReadLine();

            if (library.update(newTitle, id))
            {
                Console.WriteLine("The book is update ...");
            }
            else{
                Console.WriteLine("Problem of update ...");
            }
        }

        private static void add(){
            Console.WriteLine("Enter the Title of the new Book");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the Autor of the new Book");
            string author = Console.ReadLine();
            Console.WriteLine("Enter the Category of the new Book");
            string category = Console.ReadLine();

            if (library.add(new Book(title, author, category)))
            {
                Console.WriteLine("The book successfully added ...");
            }
            else{
                Console.WriteLine("There was a problem adding the book ...");
            }
        }
    }//FIN CLASS
}
