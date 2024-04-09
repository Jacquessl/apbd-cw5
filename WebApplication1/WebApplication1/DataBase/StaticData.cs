using WebApplication1.Model;

namespace WebApplication1.DataBase;

public static class StaticData
{
    private static List<Animal> animals = new List<Animal>();

    public static void AddAnima(Animal animal)
    {
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
        foreach (var VARIABLE in animals)
        {
            if (VARIABLE.Id == id)
            {
                animals.Remove(VARIABLE);
            }
        }
    }

    public static void EditAnimal(int id, Animal animal)
    {
        
        foreach (var VARIABLE in animals)
        {
            if (VARIABLE.Id == id)
            {
                animals.Remove(VARIABLE);
            }
        }
        animals.Add(animal);
    }
}