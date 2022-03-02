using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    /// <summary>
    /// Created AddressBook Manager To Manage The AddressBook Contacts(UC1)
    /// </summary>
    public class AddressBookManager
    {
        //Creating the object of datatable and addressbook
        public static DataTable dataTable;
        public static AddressBook contact;

        //Method to create datatable with addressbook columns(UC1)
        public static DataTable CreateDataTable()
        {
            //Initializing the datatable
            dataTable = new DataTable("AddressBookLinq");
            DataColumn dtColumn;

            //Creating first name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "FirstName";
            dtColumn.Caption = "First Name";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dtColumn);

            //Creating last name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "LastName";
            dtColumn.Caption = "Last Name";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dtColumn);

            //Creating address column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Address";
            dtColumn.Caption = "Address";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dtColumn);

            //Creating city column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "City";
            dtColumn.Caption = "City";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dtColumn);

            //Creating state column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "State";
            dtColumn.Caption = "State";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dtColumn);

            //Creating zipcode column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(long);
            dtColumn.ColumnName = "ZipCode";
            dtColumn.Caption = "Zip Code";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dtColumn);

            //Creating phone number column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(long);
            dtColumn.ColumnName = "PhoneNumber";
            dtColumn.Caption = "Phone Number";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dtColumn);

            //Creating email column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "EmailId";
            dtColumn.Caption = "Email Id";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dtColumn);
            Console.WriteLine("Created the datatable successfuly");
            return dataTable;
        }

        //Method to insert default values into the addressbook table(UC2)
        public static string InsertDefaultValuesIntoTable()
        {
            if (dataTable != null)
            {
                List<AddressBook> addressBooks = new List<AddressBook>()
                {
                    new AddressBook() {FirstName="Raj", LastName="Verma", Address="Ghansoli", City="NaviMumbai", State="Maharashta", EmailId="abc123@gmail.com", PhoneNumber=9874562130, ZipCode=745821},
                    new AddressBook() {FirstName="Yash", LastName="Verma", Address="Ghansoli", City="NaviMumbai", State="Maharashta", EmailId="abc12@gmail.com", PhoneNumber=9876542130, ZipCode=400789},
                    new AddressBook() {FirstName="Mansi", LastName="Verma", Address="Ghansoli", City="NaviMumbai", State="Maharashta", EmailId="abc13@gmail.com", PhoneNumber=9875462130, ZipCode=400965},
                    new AddressBook() {FirstName="Ajay", LastName="Matkar", Address="Chembur", City="Mumbai", State="Maharashta", EmailId="abc143@gmail.com", PhoneNumber=9874563120, ZipCode=400456},
                    new AddressBook() {FirstName="Aman", LastName="Nikam", Address="Borivai", City="Mumbai", State="Maharashta", EmailId="abc183@gmail.com", PhoneNumber=9874561230, ZipCode=400159},
                    new AddressBook() {FirstName="Omkar", LastName="Kondvilkar", Address="Andheri", City="Mumbai", State="Maharashta", EmailId="abc173@gmail.com", PhoneNumber=9478562130, ZipCode=400258},
                    new AddressBook() {FirstName="Vaibhav", LastName="Patil", Address="Kalyan", City="Mumbai", State="Maharashta", EmailId="abc133@gmail.com", PhoneNumber=9748562130, ZipCode=400426},
                    new AddressBook() {FirstName="Apurva", LastName="Puran", Address="Andheri", City="Mumbai", State="Maharashta", EmailId="abc113@gmail.com", PhoneNumber=9874265130, ZipCode=400705},
                    new AddressBook() {FirstName="Amit", LastName="Pawar", Address="Govandi", City="NaviMumbai", State="Maharashta", EmailId="abc103@gmail.com", PhoneNumber=9726562130, ZipCode=400706},
                };
                //Adding values to datatable
                foreach (var contact in addressBooks)
                {
                    //adding rows from addressbook to data table rows
                    dataTable.Rows.Add(contact.FirstName, contact.LastName, contact.Address, contact.City, contact.State, contact.ZipCode, contact.PhoneNumber, contact.EmailId);
                }
                return "Added The Data Successfully Into The Table";
            }
            else
                return "No DataTable Found";   
        }

        //Method to insert new values into the addressbook table(UC2)
        public static string InsertNewContactTable(AddressBook contact)
        {
            if(dataTable != null)
            {
                //Adding to the table datarow 
                dataTable.Rows.Add(contact.FirstName, contact.LastName, contact.Address, contact.City, contact.State, contact.ZipCode, contact.PhoneNumber, contact.EmailId);
                return "Added The Data Successfully Into The Table";
            }
            else
                return "No DataTable Found";           
        }

        //Method to edit existing contact from datatable(UC3)
        public static string EditAddressBookDataTable(string firstName, string columnName, string columnValue)
        {
            try
            {
                if (dataTable != null)
                {
                    var contactList = (from contact in dataTable.AsEnumerable() where contact.Field<string>("FirstName") == firstName select contact).FirstOrDefault();
                    if (contactList != null)
                    {
                        contactList[columnName] = columnValue;
                        DisplayDataTable();
                        return $"Modified DataTable Successfully";
                    }
                    else return default;
                }
                else
                    return "No DataTable Found";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Method to delete exsiting contact from datatable(UC4)
        public static string DeleteContactInDataTable(string FirstName)
        {
            if(dataTable != null)
            {
                InsertDefaultValuesIntoTable();
                var contactList = (from contact in dataTable.AsEnumerable() where contact.Field<string>("FirstName") == FirstName select contact).FirstOrDefault();
                if (contactList != null)
                {
                    contactList.Delete();
                    DisplayDataTable();
                    return $"Deleted The Given Contact {FirstName} Successfully";
                }
                else 
                    return "The Given Contact Is Not Found";
            }
            else
                return "No DataTable Found";          
        }

        //Method to display all datatable values(UC2)
        public static void DisplayDataTable()
        {
            if(dataTable != null)
            {
                foreach (DataColumn dtColumns in dataTable.Columns)
                {
                    Console.Write(dtColumns + "    \t");
                }
                Console.WriteLine();
                foreach (DataRow dtRows in dataTable.Rows)
                {
                    Console.WriteLine($"{dtRows["FirstName"]}\t\t{dtRows["LastName"]}   \t{dtRows["Address"]}  \t{dtRows["City"]}  \t{dtRows["State"]} \t{dtRows["ZipCode"]}  \t{dtRows["PhoneNumber"]} \t{dtRows["EmailId"]}");
                }
            }
            else
                Console.WriteLine("No DataTable Found");            
        }
    }
}
