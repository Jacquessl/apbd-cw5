using WebApplication1.Model;

namespace WebApplication1.DataBase;

public static class StaticData
{
    private static List<Animal> animals = new List<Animal>();

    public static void AddAnima(Animal animal)
    {
        bool Exists = false;
        foreach (var VARIABLE in animals)
        {
            if (VARIABLE.Id == animal.Id)
            {
                Exists = true;
            }
        }
        if(!Exists)
            animals.Add(animal);
    }

    public static List<Animal> GetAnimals()
    {
        return animals;
    }

    public static Animal GetAnimal(int id)
    {
        foreach (var animal in animals)
        {
            if (animal.Id == id)
            {
                return animal;
            }
        }

        return null;
    }

    public static void DeleteAnimal(int id)
    {
        Animal AnimalToRemove = null;
        foreach (var VARIABLE in animals)
        {
            if (VARIABLE.Id == id)
            {
                AnimalToRemove = VARIABLE;
            }
        }
        if(AnimalToRemove != null)
            animals.Remove(AnimalToRemove);
    }

    public static void EditAnimal(int id, Animal animal)
    {
        Animal AnimalToRemove = null;
        bool Exists = false;
        foreach (var VARIABLE in animals)
        {
            if (VARIABLE.Id == id)
            {
                AnimalToRemove = VARIABLE;
            }
            else if (VARIABLE.Id == animal.Id)
            {
                Exists = true;
            }
        }

        if (AnimalToRemove != null && !Exists)
        {
            animals.Remove(AnimalToRemove);
            animals.Add(animal);
        }
    }
}