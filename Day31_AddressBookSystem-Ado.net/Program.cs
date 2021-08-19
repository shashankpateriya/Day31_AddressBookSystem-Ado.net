using System;

namespace Day31_AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AddressBook_Using_Ado.Net ");
            AddressBookRepo abrepo = new AddressBookRepo();
            //abrepo.CheckConnection();
            AddressBookModel abmodel = new AddressBookModel();
            AddressBookModel abmodel1 = new AddressBookModel();
            AddressBookModel delmodel = new AddressBookModel();
            while (true)
            {
                Console.WriteLine("\nEnter Choice  \n1.AddContact \n2.EditContact \n3.DeleteContact \n4.RetriveStateorCity" +
                                  "\n5.SizeofBook\n6.SortPersonNameByCity\n7.identifyEachAddressbook\n8.CountByBookType\n9.Exit ");
                int choice = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            //AddressBookModel abmodel = new AddressBookModel();
                            abmodel.First_Name = "Shashank";
                            abmodel.Last_Name = "Pateriya";
                            abmodel.Address = "Leeds";
                            abmodel.City = "Indore";
                            abmodel.State = "Madhya Pradesh";
                            abmodel.Zip = "452014";
                            abmodel.Phone_Number = "7974146706";
                            abmodel.Email = "shashankpateriya4@gmail.com";
                            abmodel.BookName = "Shashank";
                            abmodel.AddressbookType = "family";
                            bool result = abrepo.AddContact(abmodel);

                            if (result)
                                Console.WriteLine("Record added successfully...");
                            else
                                Console.WriteLine("Some problem is there...");
                            Console.ReadKey();
                            break;
                        case 2:
                            // Update recods
                            //AddressBookModel abmodel1 = new AddressBookModel();
                            abmodel1.First_Name = "Shash";
                            abmodel1.Last_Name = "Pateriya";
                            abmodel1.City = "Sagar";
                            abmodel1.State = "Mp";
                            abmodel1.Email = "sp@gmail.com";
                            abmodel1.BookName = "Shashank1";
                            abmodel1.AddressbookType = "Friends";
                            abrepo.EditContactUsingFirstName(abmodel1);
                            Console.ReadKey();
                            break;
                        case 3:
                            delmodel.First_Name = "Pooja";
                            abrepo.DeleteContactUsingName(delmodel);
                            Console.ReadKey();
                            break;
                        case 4:
                            abrepo.RetrieveContactFromPerticularCityOrState();
                            Console.ReadKey();
                            break;
                        case 5:
                            abrepo.AddressBookSizeByCityANDState();
                            Console.ReadKey();
                            break;
                        case 6:
                            abrepo.SortPersonNameByCity();
                            Console.ReadKey();
                            break;
                        case 7:
                            abrepo.identifyEachAddressbooktype();
                            Console.ReadKey();
                            break;
                        case 8:
                            abrepo.GetNumberOfContactsCountByBookType();
                            Console.ReadKey();
                            break;

                        case 9:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter The Valid Choise");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please enter integer options only");
                }
            }
        }
    }
}
