using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAppL.BL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    [Serializable]
    public class Gender
    {
        /// <summary>
        /// Имя пола.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name">Имя пола.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Gender(string name) 
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Строка пола не может быть пустым или NULL", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
