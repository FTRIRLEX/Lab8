using System;
using System.Xml.Serialization;

namespace Lab5
{
    public class PrimerBall
    {
        internal string material; //материал
        internal int year_of_create; //дата создания
        internal string brand; //бренд
        public string Brand { get { return brand; } } ////////////свойства
        public int Year_of_create { get { return year_of_create; } }
        public string Material { get { return material; } }

        public PrimerBall()
        {


            material = "";
            year_of_create = 0;
            brand = "";
        }


        public PrimerBall(string _material, int _year_of_create, string _brand, int _quantity, int _price)
        {

            material = _material;
            year_of_create = _year_of_create;
            brand = _brand;

        }


        //public string GetInfo()
        //{
        //    return "Количество: " + Quantity + "\nЦена: " + Price + "\nМатериал: " + material + "\nДата создания: " + year_of_create + "\nБренд: " + brand;
        //}

        public override string ToString()////////переопределение tostring
        {
            return "Мячи: " +
                "\n Материал: " + material.ToString() +
                "\n Бренд: " + brand.ToString() +
                "\n Год создания: " + year_of_create.ToString() + "\n------------------------------------------------";
        }
        public override int GetHashCode() ///////переопределение gethashcode
        {
            return  material.GetHashCode() + brand.GetHashCode() + year_of_create.GetHashCode();
        }
        public virtual void Virtual_For_Ball()
        {
            Console.WriteLine("Виртуальный метод мяча............");
        }
        public override bool Equals(object obj) ////Переопределение equals
        {
            if (obj.GetType() != GetType())
                return false;
            if (obj.GetHashCode() != GetHashCode())
                return false;
            return true;
        }
    }
}

