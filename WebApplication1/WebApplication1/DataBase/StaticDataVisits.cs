using WebApplication1.Model;

namespace WebApplication1.DataBase;

public class StaticDataVisits
{
    private static List<Visit> Visits = new List<Visit>();

    public static void AddVisit(Visit Visit)
    {
        bool Exists = false;
        foreach (var VARIABLE in Visits)
        {
            if (VARIABLE.Id == Visit.Id)
            {
                Exists = true;
            }
        }
        if(!Exists)
            Visits.Add(Visit);
    }

    public static List<Visit> GetVisits()
    {
        return Visits;
    }

    public static Visit GetVisit(int id)
    {
        foreach (var Visit in Visits)
        {
            if (Visit.Id == id)
            {
                return Visit;
            }
        }

        return null;
    }

    public static void DeleteVisit(int id)
    {
        Visit VisitToRemove = null;
        foreach (var VARIABLE in Visits)
        {
            if (VARIABLE.Id == id)
            { 
                VisitToRemove = VARIABLE;
            }
        }
        if (VisitToRemove != null)
            Visits.Remove(VisitToRemove);
    }

    public static void EditVisit(int id, Visit Visit)
    {
        Visit VisitToRemove = null;
        bool Exists = false;
        foreach (var VARIABLE in Visits)
        {
            if (VARIABLE.Id == id)
            {
                VisitToRemove = VARIABLE;
            }
            else if (VARIABLE.Id == Visit.Id)
            {
                Exists = true;
            }
        }

        if (VisitToRemove != null && !Exists)
        {
            Visits.Remove(VisitToRemove);
            Visits.Add(Visit);
        }
    }
}