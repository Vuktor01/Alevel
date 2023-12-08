using System;
using System.Collections.Generic;
using System.Linq;

public class Contact
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class LinqExample
{
    public static void Main()
    {
        List<Contact> contacts = new List<Contact>
        {
            new Contact { Name = "Alice", Age = 25 },
            new Contact { Name = "Bob", Age = 30 },
            new Contact { Name = "Charlie", Age = 22 }
        };

        Contact firstContact = contacts.FirstOrDefault();
        Console.WriteLine("Первый контакт: " + firstContact?.Name);

        var adults = contacts.Where(c => c.Age >= 25);
        Console.WriteLine("Взрослые:");
        foreach (var adult in adults)
        {
            Console.WriteLine(adult.Name);
        }

        var names = contacts.Select(c => c.Name);
        Console.WriteLine("Имена контактов:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        var orderedContacts = contacts.OrderBy(c => c.Age);
        Console.WriteLine("Контакты по возрасту:");
        foreach (var contact in orderedContacts)
        {
            Console.WriteLine($"{contact.Name}, Возраст: {contact.Age}");
        }

        int count = contacts.Count();
        Console.WriteLine("Общее количество контактов: " + count);

        bool hasAdults = contacts.Any(c => c.Age >= 18);
        Console.WriteLine("Есть ли взрослые: " + hasAdults);
    }
}