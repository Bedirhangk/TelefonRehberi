namespace TelefonRehberi;

class Person
{
    private string? name ;
    private string? surname;
    private string? number;

    public Person(){}

    public Person(string Nme,string Surnme, string Nbr)
    {
        this.name=Nme;
        this.surname=Surnme;
        this.number=Nbr;
    }

    public string? Name { get => name; set => name = value; }
    public string? Surname { get => surname; set => surname = value; }
    public string? Number { get => number; set => number = value; }
}