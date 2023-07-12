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

            var userController = new UserController(name);

            if (userController.IsNewUser)
            {
                Console.Write("Укажите пол: ");
                var gender = Console.ReadLine();
                DateTime birthDate = ParsDateTime();
                double weight = ParseDouble("вес");
                double heigth = ParseDouble("рост");
                

                userController.SetNewUserDate(gender, birthDate, weight, heigth);

            }
            Console.WriteLine(userController.CurrentUser);


        }

        private static DateTime ParsDateTime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.Write("Укажите дату рождения (dd.MM.yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Не верный формат даты рождения");
                }
            }

            return birthDate;
        }

        private static double ParseDouble(string name)
        {
            while (true)
            {
                Console.Write($"Введите {name}): ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Не верный формат {name}");
                }
            }
        }
    }
}
