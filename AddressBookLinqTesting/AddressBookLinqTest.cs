using AddressBookLinq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressBookLinqTesting
{
    [TestClass]
    public class AddressBookLinqTest
    {
        //Testing to check the data table is created or not(UC1-TC1.1)
        [TestMethod]
        [DataRow("AddressBookLinq")]
        public void TestCreateDataTable(string expected)
        {
            var actual = AddressBookManager.CreateDataTable();
            Assert.AreEqual(actual.TableName, expected);
        }

        //Testing to check the data is inserted into datatable or not(UC2-TC2.1)
        [TestMethod]
        [DataRow("Ankit", "Varma", "Nerul", "NaviMumbai", "Maharashtra", 854697, 9658742130, "abc112@gmail.com", "Added The Data Successfully Into The Table")]
        [DataRow("Yash", "Sarjekar", "Nanded", "Pune", "Maharashtra", 741258, 9547861320, "abc705@gmail.com", "Added The Data Successfully Into The Table")]
        public void TestInsertNewContactTable(string fname, string lname, string address, string city, string state, int zipcode, long phoneNum, string emailId, string expected)
        {
            AddressBookManager.CreateDataTable();
            AddressBook addressBook = new AddressBook();
            addressBook.FirstName = fname;
            addressBook.LastName = lname;
            addressBook.Address = address;
            addressBook.City = city;
            addressBook.State = state;
            addressBook.ZipCode = zipcode;
            addressBook.PhoneNumber = phoneNum;
            addressBook.EmailId = emailId;
            var actual = AddressBookManager.InsertNewContactTable(addressBook);
            Assert.AreEqual(actual, expected);
        }

        //Testing to check the data is edited or not in the datatable(UC3-TC3.1)
        [TestMethod]
        [DataRow("Aman", "Address", "Dombivali", "Modified DataTable Successfully")]
        [DataRow("Aman", "Addresss", "Dombivali", "Column 'Addresss' does not belong to table AddressBookLinq.")]
        public void TestEditContactTable(string fname,  string columnName, string cValue, string expected)
        {
            AddressBookManager.CreateDataTable();
            AddressBookManager.InsertDefaultValuesIntoTable();
            var actual = AddressBookManager.EditAddressBookDataTable(fname, columnName, cValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
