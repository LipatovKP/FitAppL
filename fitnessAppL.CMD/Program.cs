using FitnessAppL.BL.Controller;
using FitnessAppL.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAppL.CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в FitAppL!!!");
            Console.WriteLine("Введите имя пользователя.");

            var name = Console.ReadLine();

            Console.WriteLine("Укажите ваш пол.");
            var gender = Console.ReadLine();

            Console.WriteLine("Укажите вашу дату рождения.");
            var birthDate = DateTime.Parse(Console.ReadLine()); // TODO: Переписать

            Console.WriteLine("Укажите ваш вес.");
            var weight = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Укажите ваш рост.");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthDate, weight, height);
            userController.Save();

        }
    }
}
