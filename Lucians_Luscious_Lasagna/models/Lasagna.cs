namespace Lucians_Luscious_Lasagna.Models;

public class Lasagna
{
    public int ExpectedMinutesInOven()
        => 40;

    public int RemainingMinutesInOven(int actualMinutes)
        => ExpectedMinutesInOven() - actualMinutes;

    public int PreparationTimeInMinutes(int layers)
        => layers * 2;

    public int ElapsedTimeInMinutes(int layers, int minutes)
        => PreparationTimeInMinutes(layers) + minutes;

}
