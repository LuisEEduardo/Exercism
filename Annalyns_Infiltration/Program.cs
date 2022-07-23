using Annalyns_Infiltration.Entities;

// CanFastAttack()
var KnightIsAwake = true;

Console.WriteLine(QuestLogic.CanFastAttack(KnightIsAwake));

// CanSpy()
var knightIsAwake = false;
var archerIsAwake = true;
var prisonerIsAwake = false;

Console.WriteLine(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));

// CanSignalPrisoner()
archerIsAwake = false;
prisonerIsAwake = true;

Console.WriteLine(QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));

// CanFreePrisoner() 
knightIsAwake = false;
archerIsAwake = true;
prisonerIsAwake = false;
var petDogIsPresent = false;

Console.WriteLine(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

