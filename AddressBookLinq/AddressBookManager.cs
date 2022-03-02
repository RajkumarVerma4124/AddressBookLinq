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
        //Creating the object of datatable
        public static DataTable dataTable;

        //Method to create datatable with addressbook columns(UC1)
        public static void CreateDataTable()
        {
            //Initializing the datatable
            dataTable = new DataTable("AddressBookLinq");
            DataColumn dtColumn;

            //Creating column addressbookid
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);
            dtColumn.ColumnName = "AddressBookId";
            dtColumn.Caption = "AddressBook Id";
            dtColumn.AutoIncrement = true;
            dtColumn.Unique = true;
            // Adding column to the DataColumnCollection 
            dataTable.Columns.Add(dtColumn);

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

            //Creating email column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "EmailId";
            dtColumn.Caption = "Email Id";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dtColumn);

            //Creating phone number column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(long);
            dtColumn.ColumnName = "PhoneNumber";
            dtColumn.Caption = "Phone Number";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dtColumn);

            //Creating zipcode column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(long);
            dtColumn.ColumnName = "ZipCode";
            dtColumn.Caption = "Zip Code";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dtColumn);
            Console.WriteLine("Created the datatable successfuly");
        }
    }
}
