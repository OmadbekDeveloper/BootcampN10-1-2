using UsingMapster;
using Sharprompt;
using UsingMapSter.DTos;
using Microsoft.Extensions.DependencyInjection;
using UsingMapSter;

var services = new ServiceCollection();
services.MapsterConfigRegistration();





var service = new UserService();

while (true)
{
    var choose = Prompt.Select("Tanlang: ", new[] { "User yaratish", "Get users" });

    if (choose == "User yaratish")
    {
        var firstName = Prompt.Input<string>("Ism Kiriting:");
        var lastName = Prompt.Input<string>("Familiya Kiriting:");
        var email = Prompt.Input<string>("Email Kiriting:");
        var password = Prompt.Input<string>("Password Kiriting:");
        var username = Prompt.Input<string>("Username Kiriting:");


        var user = new UserForCreation()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password,
            UserName = username
        };


        service.Create(user);
    }
    else if (choose == "Get users")
    {
        var users = service.GetUsers();

        foreach (var user in users)
        {
            Console.WriteLine($"{user.Id} {user.FullName} {user.UserName} {user.CreatedAt}");
            Prompt.Input<string>(" ");
        }
    }

    Console.Clear();
}