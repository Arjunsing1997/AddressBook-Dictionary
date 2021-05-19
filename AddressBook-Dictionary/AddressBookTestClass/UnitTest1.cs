using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AddressBook_Dictionary;

namespace AddressBookTestClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddPerson_TestCase()
        {
            bool Expected = true;
            bool Actual = Program.AddPerson();

            Assert.AreEqual(Actual, Expected);
            
        }
    }
}
