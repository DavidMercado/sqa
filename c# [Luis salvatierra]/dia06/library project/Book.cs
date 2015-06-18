using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private int id;
        private string titulo, autor, categoria;

        public Book(string nuevoTitulo, string nuevoAutor, string nuevoCategoria){            
            id = 0;
            titulo = nuevoTitulo;
            autor = nuevoAutor;
            categoria = nuevoCategoria;          
        }

        public Book(){
            id = 0;
            titulo = autor = categoria = "";
        }
        public int getId(){
            return id;
        }

        public string getTitulo(){
            return titulo;
        }

        public string getAutor(){
            return autor;
        }

        public string getCategoria(){
            return categoria;
        }

        public void setTitle(string newTitle){
            titulo = newTitle;
        }

        public void setId(int newId){
            id = newId;
        }
    }
}
