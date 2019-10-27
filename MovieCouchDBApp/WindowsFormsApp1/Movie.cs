using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Movie
    {
       public string _id
        {
            get;
            set;
        }

       public string title
        {
            get;
            set;
        }

        public int year
        {
            get;
            set;
        }

        public string director
        {
            get;
            set;
        }

        public string producer
        {
            get;
            set;
        }

        public string composer
        {
            get;
            set;
        }

        public int runtimeInMinutes
        {
            get;
            set;
        }

        public string company
        {
            get;
            set;
        }

        public int price
        {
            get;
            set;
        }

        public int numberInStock
        {
            get;
            set;
        }

        public Movie(Movie m)
        {
            _id = m._id;
            title = m.title;
            year = m.year;
            director = m.director;
            producer = m.producer;
            composer = m.composer;
            runtimeInMinutes = m.runtimeInMinutes;
            company = m.company;
            price = m.price;
            numberInStock = m.numberInStock;

        }

        public Movie(string _id, string title, int year, string director, string producer, string composer, int runtimeInMinutes, string company, int price, int numberInStock)
        {
            this._id = _id;
            this.title = title;
            this.year = year;
            this.director = director;
            this.producer = producer;
            this.composer = composer;
            this.runtimeInMinutes = runtimeInMinutes;
            this.company = company;
            this.price = price;
            this.numberInStock = numberInStock;
        }








    }
}
