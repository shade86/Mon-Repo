using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mon_Repo;

namespace Mon_RepoTests
    
{
    [TestClass]
    public class SignUpTests
    {
        [TestMethod]
        public void SignUpTestRight()
        {
            var suvm = new SignUpViewModel();
            suvm.username = "Próba";
            suvm.password = "2222";
            bool result = suvm.SignUpValidate();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SignUpTestWrong()
        {
            var suvm = new SignUpViewModel();
            suvm.username = "";
            suvm.password = "";
            bool result = suvm.SignUpValidate();
            Assert.IsFalse(result);
        }
    }
}
