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

            addressBookModel.FirstName = "Mr";
            addressBookModel.LastName = "Haltung";
            addressBookModel.Address = "AAAAA";
            addressBookModel.City = "CCCCC";
            addressBookModel.State = "MMMMM";
            addressBookModel.Zipcode = 44444;
            addressBookModel.PhoneNumber = 999999999;
            addressBookModel.Email = "mrhaltung@gmail.com";
            addressBookModel.AddressBookName = "MyBook";
            addressBookModel.AddressBookType = "family";
            bool result = addressBookRepo.AddContact(addressBookModel);
            // addressBookRepo.DatabaseConnection();

            //addressBookRepo.GetAllContact();

              addressBookRepo.AddDataToTable(addressBookModel);
        }
    }
}
