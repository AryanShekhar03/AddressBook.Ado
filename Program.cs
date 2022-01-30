using System;

namespace AddressBook.ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");

            AddressBookRepo addressBookRepo = new AddressBookRepo();
            AddressBookModel addressBookModel = new AddressBookModel();

            addressBookRepo.DatabaseConnection();
            addressBookRepo.GetAllContact();
        }
    }
}
