namespace Bird_Watcher.Entity;

public class BirdCount
{
    public int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
        => new int[] { 0, 2, 5, 3, 7, 8, 4 };

    // public int Today()
    // {
    //     var toDay = (int)DateTime.Now.DayOfWeek - 1;
    //     return birdsPerDay[toDay];
    // }

    public int Today()
        => birdsPerDay[^1];

    public void IncrementTodaysCount()
        => birdsPerDay[^1]++;

    public bool HasDayWithoutBirds()
    {
        foreach (var day in birdsPerDay)
        {
            if (day == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int qty = 0;
        for (int i = 0; i < numberOfDays; i++)
            qty += birdsPerDay[i];

        return qty;
    }

    public int BusyDays()
    {
        int qtyBusyDays = 0;
        foreach (var day in birdsPerDay)
        {
            if (day >= 5)
                qtyBusyDays += 1;
        }

        return qtyBusyDays;
    }

}
