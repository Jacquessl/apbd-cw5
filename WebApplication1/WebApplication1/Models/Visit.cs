namespace WebApplication1.Model;

public class Visit
{
    public Visit(int id, DateTime date, int animalId, string describtion, double price)
    {
        Id = id;
        Date = date;
        AnimalId = animalId;
        Describtion = describtion;
        Price = price;
    }

    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int AnimalId { get; set; }
    public string Describtion { get; set; }
    public double Price { get; set; }
}