using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mon_Repo;
using Mon_Repo.Dal;

namespace Mon_RepoTests
{
    [TestClass]
    public class DataManagerTests
    {
        static Random R = new Random();

        [TestMethod]
        public void AddProductTest()
        {
            var manager = new Mon_Repo.Dal.DataManager();
                bool result = manager.AddProductDb("Teszt_termék", 10, 10);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RegisterUserAlreadyExists()
            //asdf felhasználónak létezni kell a "sikeres" messageboxhoz
        {
            var manager = new Mon_Repo.Dal.DataManager();
            string username = "asdf";
            manager.Register(username, "asdf");
        }

        [TestMethod]
        public void RegisterUserDoesNotExists()
        {
            var manager = new Mon_Repo.Dal.DataManager();
            string username = R.Next(0, 100000).ToString();
            string password = R.Next(0, 100000).ToString();
            manager.Register(username, password);
        }
    }
}





