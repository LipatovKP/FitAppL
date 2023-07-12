using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessAppL.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAppL.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {

        [TestMethod()]
        public void SetNewUserDateTest()
        {
            var userName = Guid.NewGuid().ToString();
            var birthDate = DateTime.Now.AddYears(-18);
            var weigth = 90;
            var heigth = 190;
            var gender = "man";
            var controller = new UserController(userName);

            controller.SetNewUserDate(gender, birthDate, weigth, heigth);
            var contriller2 = new UserController(userName);

            Assert.AreEqual(userName, contriller2.CurrentUser.Name);
            Assert.AreEqual(birthDate, contriller2.CurrentUser.BirthDate);
            Assert.AreEqual(weigth, contriller2.CurrentUser.Weight);
            Assert.AreEqual(heigth, contriller2.CurrentUser.Height);
            Assert.AreEqual(gender, contriller2.CurrentUser.Gender.Name);
            


        }

        [TestMethod()]
        public void SaveTest()
        {
            var userName = Guid.NewGuid().ToString();

            var controller = new UserController(userName);

            Assert.IsNotNull(userName, controller.CurrentUser.Name);
        }
    }
}