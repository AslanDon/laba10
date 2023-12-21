using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students Student1 = new Students("Фельдман Г.И", 2023, "г. Пенза", "89998285698", 1, "Информационные технологии");
            Students Student2 = new Students("Исаев И.Н", 2021, "г. Москва", "89998896452", 3, "Экономика");
            Students Student3 = new Students("Петров Н.В", 2022, "г. Рязань", "88005553535", 2, "Агрономия");
            Students[] massiv = new Students[3] { Student1, Student2, Student3 };

            for (int i = 0; i < massiv.Length; i++)
            {
                Console.WriteLine(massiv[i].FIO_Property);
            }

            Console.WriteLine("Vvedite fakultet:");
            string fakulte = Console.ReadLine();
            Console.WriteLine("Vvedite qod postupleniya:");
            int qod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("spisok studentov zadannoko fakulteta");
            
            for (int i = 0;i < massiv.Length; i++)
            {
                if (massiv[i].fakultet_property.Equals(fakulte))
                {
                    Console.WriteLine(massiv[i].FIO_Property);
                }
            }

            Console.WriteLine("Spisok studentov postupivsix posle zadannoqo qoda");

            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i].data_property.Equals(qod))
                {
                    Console.WriteLine(massiv[i].FIO_Property);
                }
            }
            Console.ReadLine();



        }
    }

    class Students
    {
        private string FIO;
        private int data;
        private string adress;
        private string telefon;
        private int curs;
        private string fakultet;

        public string FIO_Property
        {
            get { return FIO; } //ЧТЕНИЕ
            set { FIO = value; } //ЗАПИСЬ
        }

        public int data_property
        {
            get { return data; }
            set { data = value; }
        }

        public string adress_property
        {
            get { return adress; }
        }

        public string telefon_property
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public int curs_property
        {
            set { curs = value; }
        }

        public string fakultet_property
        {
            get { return fakultet; }
        }
        public Students(string FIO, int data, string adress, string telefon, int curs, string fakultet)
        {
            this.FIO = FIO;
            this.data = data;
            this.adress = adress;
            this.telefon = telefon;
            this.curs = curs;
            this.fakultet = fakultet;
        }
    }

}
