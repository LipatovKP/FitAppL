using FitnessAppL.BL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAppL.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// ПОльзователь приложения.
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Создание контроллера пользователя.
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height) 
        {
            // TODO: Проверка
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDay, weight, height);

            //User = user ?? throw new ArgumentNullException("Пользователь не может быть равен NULL.", nameof(user));
        }

        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }

                // TODO: Что делать, если не прочитали пользователя?
            }
        }

        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// Получить данные пользователя.
        /// </summary>
        /// <returns>Пользователь.</returns>       
        
    }
}
