using System;

class Program{
  public static void Main(string[] args) {
    Console.WriteLine("Enter Name:");
    string userName = Console.ReadLine();

    Console.WriteLine("Enter birthday:");
    string date = Console.ReadLine();

    Console.WriteLine("Enter work number:");
    string workNum = Console.ReadLine();

    Console.WriteLine("Enter cell number:");
    string cellNum = Console.ReadLine();
    
    Console.WriteLine(" Name: " + userName);
    Console.WriteLine(" Birthdate: " + date);
    Console.WriteLine(" Work: " + workNum);
    Console.WriteLine(" Cell: " + cellNum);
  }
}