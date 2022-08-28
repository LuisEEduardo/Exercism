namespace Elons_Toys.Entity;

public class RemoteControlCar
{
    public int metersDriven { get; set; } = 0;
    public int totalBatery { get; set; } = 100;

    public static RemoteControlCar Buy()
        => new RemoteControlCar();

    public string DistanceDisplay()
        => $"Driven {metersDriven} meters";

    public string BatteryDisplay()
    {
        if (totalBatery > 0)
            return $"Battery at {totalBatery}%";

        return "Battery empty";
    }

    public void Drive()
    {
        if (totalBatery != 0)
        {
            metersDriven += 20;
            totalBatery -= 1;
        }
    }

}
