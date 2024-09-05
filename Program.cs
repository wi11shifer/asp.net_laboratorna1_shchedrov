/*
 
//Завдання 1

var builder = WebApplication.CreateBuilder();

var app = builder.Build();

var company = new Company
{
    Name = "CHNU Petra Mohyly",
    Address = "Soborna str. 29",
    Phone = "+3809812345",
    Email = "helloworld@gmail.com"
};

app.Run(async (context) =>
{
    await context.Response.WriteAsync($"Company Name: {company.Name}\n" +
                                      $"Address: {company.Address}\n" +
                                      $"Phone: {company.Phone}\n" +
                                      $"Email: {company.Email}");
});

app.Run();

public class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}
*/

//Завдання 2

var builder = WebApplication.CreateBuilder();

var app = builder.Build();

var random = new Random(); 

app.Run(async (context) =>
{
    int randomNumber = random.Next(0, 101);
    await context.Response.WriteAsync($"Random Number from 0 to 100: {randomNumber}");
});

app.Run();
