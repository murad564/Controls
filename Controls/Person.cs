namespace Ex_WinFormsApp2;

public class Person
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Patronymic { get; set; }
    public DateTime Brithday { get; set; }
    public string? Gender { get; set; }

    public Person(string Name, string Surname, string Patronymic, DateTime Brithday, string Gender)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Patronymic = Patronymic;
        this.Brithday = Brithday;
        this.Gender = Gender;
    }
}