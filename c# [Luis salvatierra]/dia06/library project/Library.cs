using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        private string nombre;
        private int counterBooks;
        private Dictionary<int, Book> repository;

        public Library(string newNombre){
            nombre = newNombre;
            repository = new Dictionary<int, Book>();
            counterBooks = 0;
        }

        //Method ALL
        public List<Book> all(){
            List<Book> res = new List<Book>();

            if (!isEmpty()){
                foreach(KeyValuePair<int, Book> book in repository){
                    res.Add(book.Value);
                }
            }

            return res;
        }

        //METHOD REMOVE
        public bool remove(int id){
            bool res = false;

            if (!isEmpty()){
                if(repository.ContainsKey(id)){
                    repository.Remove(id);
                    res = true;
                }
            }

            return res;
        }

        //METHOD ADD
        public bool add(Book newBook){
            bool res = true;
            counterBooks += 1;
            newBook.setId(counterBooks);
            repository.Add(counterBooks, newBook);

            
            return res;
        }

        //METHOD UPDATE
        public bool update(string newTitle, int id){
            bool res = false;

            if(!isEmpty()){
                if (repository.ContainsKey(id)){
                    repository[id].setTitle(newTitle);
                    res = true;
                }
            }

            return res;
        }

        //METHOD GETBYID
        public Book getById(int id){
            Book res = null;

            if(!isEmpty()){
                if (repository.ContainsKey(id)){
                    res = repository[id];
                }
            }            

            return res;
        }

        private Boolean isEmpty(){
            bool res = false;

            if(repository == null || repository.Count == 0){
                res = true;
            }

            return res;
        }
    }
}
