public class StudentList
{
public List<string> Students;
public StudentList()
{
Students = new List<string> {
        "Max Baykowski",
        "Ashley Berna",
        "William Boes",
        "Joshua Burgenmeyer",
        "Adryann Cleveland",
        "Case Cnossen",
        "Adelynn Crandle",
        "Jacob Daniel",
        "Hayden Flick",
        "Madaline Fowler",
        "Chase Frikken",
        "Nicholas Fultz",
        "Jeremiah Guerra",
        "Ashley Haltenhoff",
        "Joel Hoppe",
        "Xavier Ickes",
        "Amin Jafarov",
        "Tyler Kerkstra",
        "Kevin Kosturik",
        "Joanna Leal",
        "Jackson Mangum",
        "Dakota McDaniel",
        "Ryan Michael",
        "Kamren Moomey",
        "Keegan Ohlman",
        "Ari Osorio",
        "Isaac Pontier",
        "Eli Robinson",
        "Marcus Ruiz",
        "Angelina Saeteurn",
        "Zoe Sample",
        "Nolan Sarber",
        "Brady Schoemaker",
        "Isaac Siertsma",
        "Alec Tackitt",
        "Jaelynn VanderSyde",
        "Maximilian Wallace",
        "Samuel Walters",
        "Keagan Ziemann-Bell"

};

}


public string this[int index]{
    get { return Students[index]; }
    set { Students[index] = value; }
}
}