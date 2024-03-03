using System;

interface IClub
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Methods
    public string FullName();
}

class ClubMember : IClub
{
    // Fields
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }

    // Default constructor
    public ClubMember()
    {
    }

    // Parameterized constructor
    public ClubMember(int id, string firstName, string lastName, string email, string address, int age)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Address = address;
        Age = age;
    }

    // Method to display member information
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Age: {Age}");
    }

    // Method required by the IClub interface
    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt user to input information
        Console.WriteLine("Enter Member ID:");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter Email:");
        string email = Console.ReadLine();

        Console.WriteLine("Enter Address:");
        string address = Console.ReadLine();

        Console.WriteLine("Enter Age:");
        int age = Convert.ToInt32(Console.ReadLine());

        // Create a new ClubMember object with user-provided information
        ClubMember member = new ClubMember(id, firstName, lastName, email, address, age);

        // Display member information
        Console.WriteLine("\nMember Information:");
        member.DisplayInfo();
        Console.WriteLine($"Full Name: {member.FullName()}");
    }
}
