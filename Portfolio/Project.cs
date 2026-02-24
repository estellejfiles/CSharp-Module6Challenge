namespace Portfolio;

// create Project class
public class Project
{
    // initialize Title, Description, and Year properties
    public string Title {get; set;}
    public string Description {get; set;}
    public int Year {get; set;}

    // create constructor to make an object using the class as a blueprint
        public Project(string title, string description, int year)
        {
            // set the values of the attributes for the new user
            Title = title;
            Description = description;
            Year = year;
        }
}