﻿
using System;
using System.Data;
using ContactsBusinessLayer;

namespace ContactsConsolApp
{
    internal class Program
    {

        //------------------------------------------------------------------------//
        //--------------------------- Contact ------------------------------------//
        //------------------------------------------------------------------------//


        static void testFindContact(int ID)

        {
            clsContact Contact1 = clsContact.Find(ID);

            if (Contact1 != null)
            {
                Console.WriteLine(Contact1.FirstName+ " " + Contact1.LastName);
                Console.WriteLine(Contact1.Email);
                Console.WriteLine(Contact1.Phone);
                Console.WriteLine(Contact1.Address);
                Console.WriteLine(Contact1.DateOfBirth);
                Console.WriteLine(Contact1.CountryID);
                Console.WriteLine(Contact1.ImagePath);
            }
            else 
            {
                Console.WriteLine("Contact [" + ID + "] Not found!");   
            }
        }

        static void testAddNewContact()


        {
            clsContact Contact1 = new clsContact();
            Contact1.FirstName = "Fadi";
            Contact1.LastName = "Maher";
            Contact1.Email = "A@a.com";
            Contact1.Phone = "010010";
            Contact1.Address = "address1";
            Contact1.DateOfBirth = new DateTime(1977, 11, 6, 10, 30, 0);
            Contact1.CountryID = 1;
            Contact1.ImagePath = "";
          
           if (Contact1.Save())
            {

                Console.WriteLine("Contact Added Successfully with id = " + Contact1.ID);
            }

        }

        static void testUpdateContact(int ID)

        {
            clsContact Contact1 = clsContact.Find(ID);

            if (Contact1 != null)
            {
                //update whatever info you want
                Contact1.FirstName = "Fadi2";
                Contact1.LastName = "Maher2";
                Contact1.Email = "A2@a.com";
                Contact1.Phone = "2222";
                Contact1.Address = "222";
                Contact1.DateOfBirth = new DateTime(1977, 11, 6, 10, 30, 0);
                Contact1.CountryID = 1;
                Contact1.ImagePath = "";

                if (Contact1.Save())
                {

                    Console.WriteLine("Contact updated Successfully ");
                }

            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }

        static void testDeleteContact(int ID)
        {
            if (clsContact.isContactExist(ID))
            {
                if (clsContact.DeleteContact(ID))
                {
                    Console.WriteLine("Contact Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Faild To Delete Contact.");
                }
            }
            else
            {
                Console.WriteLine("The Contact with id = " + ID + " is not found");
            }
           
        }

        static void testIsContactExist(int ID)
        {
            if (clsContact.isContactExist(ID))
            {
                Console.WriteLine("Yes, Contact is there");
            }
            else
            {
                Console.WriteLine("No, Contact is not there");
            }
        }

        static void ListContacts()
        {

            DataTable dataTable = clsContact.GetAllContacts();
           
            Console.WriteLine("Contacts Data:");

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"{row["ContactID"]}- Full Name     : {row["FirstName"]} {row["LastName"]}");
                Console.WriteLine($"   Email         : {row["Email"]}");
                Console.WriteLine($"   Phone         : {row["Phone"]}");
                Console.WriteLine($"   Address       : {row["Address"]}");
                Console.WriteLine($"   Date of Birth : {row["DateOfBirth"]}");
                Console.WriteLine($"   Country       : {row["CountryID"]}");
                Console.WriteLine($"   Image         : {row["ImagePath"]}\n\n");
            }

        }


        //------------------------------------------------------------------------//
        //--------------------------- Country ------------------------------------//
        //------------------------------------------------------------------------//

        static void testFindCountryByID(int ID)

        {
            clsCountry Country1 = clsCountry.Find(ID);

            if (Country1 != null)
            {
                Console.WriteLine(Country1.CountryName);

            }

            else
            {
                Console.WriteLine("Country [" + ID + "] Not found!");
            }
        }


        static void testFindCountryByName(string CountryName)

        {
            clsCountry Country1 = clsCountry.Find(CountryName);

            if (Country1 != null)
            {
                Console.WriteLine("Country [" + CountryName + "] isFound with ID = " + Country1.ID);

            }

            else
            {
                Console.WriteLine("Country [" + CountryName + "] Is Not found!");
            }
        }


        static void testIsCountryExistByID(int ID)

        {

            if (clsCountry.isCountryExist(ID))

                Console.WriteLine("Yes, Country is there.");

            else
                Console.WriteLine("No, Country Is not there.");

        }

        static void testIsCountryExistByName(string CountryName)

        {

            if (clsCountry.isCountryExist(CountryName))

                Console.WriteLine("Yes, Country is there.");

            else
                Console.WriteLine("No, Country Is not there.");

        }


        static void testAddNewCountry()


        {
            clsCountry Country1 = new clsCountry();

            Country1.CountryName = "Lebanon";


            if (Country1.Save())
            {

                Console.WriteLine("Country Added Successfully with id=" + Country1.ID);
            }

        }

        static void testUpdateCountry(int ID)

        {
            clsCountry Country1 = clsCountry.Find(ID);

            if (Country1 != null)
            {
                //update whatever info you want
                Country1.CountryName = "Lebanon2";


                if (Country1.Save())
                {

                    Console.WriteLine("Country updated Successfully ");
                }

            }
            else
            {
                Console.WriteLine("Country is you want to update is Not found!");
            }
        }

        static void testDeleteCountry(int ID)

        {

            if (clsCountry.isCountryExist(ID))

                if (clsCountry.DeleteCountry(ID))

                    Console.WriteLine("Country Deleted Successfully.");
                else
                    Console.WriteLine("Faild to delete Country.");

            else
                Console.WriteLine("Faild to delete: The Country with id = " + ID + " is not found");

        }

        static void ListCountries()
        {

            DataTable dataTable = clsCountry.GetAllCountries();

            Console.WriteLine("Coutries Data:");

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["CountryID"]},  {row["CountryName"]}");
            }

        }


        static void Main(string[] args)
        {

            //testFindContact(1);
            //testAddNewContact();
            //testUpdateContact(1);
            //testDeleteContact(10);
            //ListContacts();
            //testIsContactExist(1);
            //testIsContactExist(100);

            //------------------------------------------------------------------------//

            //testFindCountryByID(1);
            //testFindCountryByID(100);
            //testFindCountryByName("United States");
            //testFindCountryByName("UK");

            //testIsCountryExistByID(1);
            //testIsCountryExistByID(100);

            //testIsCountryExistByName("United States");
            //testIsCountryExistByName("UK");

            //testAddNewCountry();
            //testUpdateCountry(6);
            //testDeleteCountry(6);
            //ListCountries();

            Console.ReadKey();

        }
    }
}
