namespace Annalyns_Infiltration.Entities;

public class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
        => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        => knightIsAwake || prisonerIsAwake || archerIsAwake;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        => !archerIsAwake && prisonerIsAwake;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        => (!knightIsAwake && !archerIsAwake && prisonerIsAwake) || (!archerIsAwake && petDogIsPresent);

}
