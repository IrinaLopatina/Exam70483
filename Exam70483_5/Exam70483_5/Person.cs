using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_5
{
    class Person : INotifyPropertyChanged
    {
        private string name;
        private string country;

        //Declare the events (from INotifyPropertyChanged)
        public event PropertyChangedEventHandler PropertyChanged;

        public Person()
        {
            name = string.Empty;
            country = string.Empty;
        }

        public Person(string name, string country)
        {
            this.name = name;
            this.country = country;
        }

        public string PersonName
        {
            get { return name; }
            set
            {
                if (name.CompareTo(value) == 0)
                    return;

                name = value;
                OnPropertyChanged("PersonName");
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (country.CompareTo(value) == 0)
                    return;

                country = value;
                OnPropertyChanged("Country");
            }
        }

        //Create the OnPropertyChanged method to raise the  event
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.PropertyChanged += OnPropertyChanged;

            person.PersonName = "Ira";
            person.Country = "Russia";
            person.PersonName = "Ira"; //Property PersonName is not changed
            person.PersonName = "Irina";
            person.Country = "Norway";
        }

        private static void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Person person = (Person)sender;
            switch (e.PropertyName)
            {
                case "PersonName":
                { 
                    Console.WriteLine("Property [{0}] has a new value = [{1}]", e.PropertyName, person.PersonName);
                    break;
                }

                case "Country":
                {
                    Console.WriteLine("Property [{0}] has a new value = [{1}]", e.PropertyName, person.Country);
                    break;
                }
            }
        }
    }
}
