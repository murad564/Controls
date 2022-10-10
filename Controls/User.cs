

namespace Ex_WinFormsApp2;

public class User : Person
{
    public string Country { get; set; }
    public string City { get; set; }
    public string Telephone { get; set; }

    public User(string Name, string Surname, string Patronymic, DateTime Brithday, string Gender, string Country, string City, string Telephone)
        : base(Name, Surname, Patronymic, Brithday, Gender)
    {
        this.Country = Country;
        this.City = City;
        this.Telephone = Telephone;
    }

}