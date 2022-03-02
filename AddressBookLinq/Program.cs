using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    public class Program
    {
        //Decalring variable and object 
        public static string resStr;
        public static AddressBook contact = new AddressBook();

        //Entry of the main program
        public static void Main(string[] args)
        {
            //Displaying welcome message
            Console.WriteLine("Welcome To The AddressBook Program Using Linq And DataTable");
            try
            {
                while(true)
                {
                    Console.WriteLine("1: Create DataTable And Insert Default Contact Into DataTable \n2: Insert New Contact Into DataTable \n3: Display DataTable \n4: Edit Contact"+
                        "\n5: Deleted Contact \n6: Retrieve Contact Based On City Or State \n7: Count Or Size Based On City Or State \n8: Sorted Records \n9: Exit");
                    Console.Write("Enter a choice from above : ");
                    bool flag = int.TryParse(Console.ReadLine(), out int choice);
                    if(flag)
                    {
                        switch(choice)
                        {
                            case 1:
                                //Calling the method to createtable and insert default contact in addressbook table(UC1 && UC2)
                                AddressBookManager.CreateDataTable();
                                break;
                            case 2:
                                //Calling the method to insert new contact in addressbook table(UC2)
                                //Creating a contact with person details(UC1)
                                Console.Write("Enter Your First Name : ");
                                contact.FirstName = Console.ReadLine();
                                Console.Write("Enter Your Last Name : ");
                                contact.LastName = Console.ReadLine();
                                Console.Write("Enter Your Home Address : ");
                                contact.Address = Console.ReadLine();
                                Console.Write("Enter Your City Name : ");
                                contact.City = Console.ReadLine();
                                Console.Write("Enter Your State Name : ");
                                contact.State = Console.ReadLine();
                                Console.Write("Enter Your Area Zip Code : ");
                                contact.ZipCode = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Your Phone Number : ");
                                contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                                Console.Write("Enter Your EmailId : ");
                                contact.EmailId = Console.ReadLine();
                                Console.Write("Enter Your AddressBook Name : ");
                                contact.AddressBookName = Console.ReadLine();
                                Console.Write("Enter The Contact Type : ");
                                contact.ContactType = Console.ReadLine();
                                resStr = AddressBookManager.InsertNewContactTable(contact);
                                Console.WriteLine(resStr);
                                break;
                            case 3:
                                //Calling the method to all values from addressbook table(UC2)
                                AddressBookManager.DisplayDataTable();
                                break;
                            case 4:
                                //Calling the method to edit addressbook table(UC3)
                                Console.Write("Enter The First Name Of The Contact To Modify : ");
                                string fName = Console.ReadLine();  
                                Console.Write("Enter The Column Name Exactly To Modify : ");
                                string cName = Console.ReadLine();
                                Console.Write("Enter The New Value For The Coulumn : ");
                                string cValue = Console.ReadLine();
                                resStr = AddressBookManager.EditAddressBookDataTable(fName, cName, cValue);
                                Console.WriteLine(resStr);
                                break;
                            case 5:
                                //Calling the method to delete a contact from addressbook table(UC4)
                                Console.Write("Enter The First Name Of The Contact To Delete : ");
                                string firstName = Console.ReadLine();
                                resStr = AddressBookManager.DeleteContactInDataTable(firstName);
                                Console.WriteLine(resStr);
                                break;
                            case 6:
                                //Calling the method to retrieve records based on city and state from addressbook table(UC5)
                                Console.Write("Enter The City Name Of The Contact : ");
                                string city = Console.ReadLine();
                                Console.Write("Enter The State Name Of The Contact : ");
                                string state = Console.ReadLine();
                                resStr = AddressBookManager.RetrieveContactBasedOnCityorState(city, state);
                                Console.WriteLine(resStr);
                                break;
                            case 7:
                                //Calling the method to count by city or state from addressbook table(UC6)
                                resStr = AddressBookManager.RetrieveCountBasedOnCityorState();
                                Console.WriteLine(resStr);
                                break;
                            case 8:
                                //Calling the method to retrieve sorted records based on name when given city(UC7)
                                Console.Write("Enter The City Name Of The Contact : ");
                                string cityName = Console.ReadLine();
                                resStr = AddressBookManager.GivenCitySortContactBasedOnName(cityName);
                                Console.WriteLine(resStr);
                                break;
                            case 9:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Wrong choice");
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter some choice");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
