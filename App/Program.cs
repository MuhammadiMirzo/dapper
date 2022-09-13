
using Domain.Entities;
using Services.Services;

var contactService = new ContactService();

var students = new Students()
{
    Name = Console.ReadLine(),
    Massage = Console.ReadLine(),
    Phone = Console.ReadLine()
};
var response = contactService.AddContact(students);
if (response == 1)
{
    System.Console.WriteLine("Contact added");
}
else
{
    System.Console.WriteLine("Contact not added");
}
