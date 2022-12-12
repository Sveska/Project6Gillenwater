using System.DataStructures;
using System.Linq.Expressions;
///////////////////////////////////////////////////////////////////////////////
//
// Author: Zachary Sveska, Sveska@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Proj 6
// Description: Take in the csv file using Stream Reader then spliting lines to add to book class
//
///////////////////////////////////////////////////////////////////////////////
namespace Proj6
{
    internal class Program
    {
    /// <summary>
    /// Main Method will create csv filepath uses stream reader to read csv split csv file to add to book method
    /// then add to avl tree
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            string filePath = "@C:\Users\ZSv3s\Downloads\books.csv";
            
            try    
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Book book = new Book();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}