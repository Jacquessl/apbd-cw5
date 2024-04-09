namespace WebApplication1.Model;

public class Animal
{
    public Animal(int id, string name, string category, double mass, string color)
    {
        Id = id;
        Name = name;
        Category = category;
        Mass = mass;
        Color = color;
    }

    public int Id { get; set; }
    string Name { get; set; }
    string Category { get; set; }
    double Mass { get; set; }
    string Color { get; set; }
}