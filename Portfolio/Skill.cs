namespace Portfolio;

// create Skill class
public class Skill
{
    // initialize name and proficiency level properties
    public string Name {get; set;}
    public int ProficiencyLevel {get; set;}

    // create constructor to make an object using the class as a blueprint
        public Skill(string name, int proficiencyLevel)
        {
            // set the values of the attributes for the new user
            Name = name;
            ProficiencyLevel = proficiencyLevel;
        }
}