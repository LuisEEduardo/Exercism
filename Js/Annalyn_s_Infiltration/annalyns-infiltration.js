const knightIsAwake = true;

function canExecuteFastAttack(knightIsAwake) {
    return !knightIsAwake;
}

function canSpy(knightIsAwake, archerIsAwake, prisonerIsAwake) {
    return knightIsAwake || archerIsAwake || prisonerIsAwake;
}

function canSignalPrisoner(archerIsAwake, prisonerIsAwake) {
    return !archerIsAwake && prisonerIsAwake;
}

function canFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent) {
    return (!knightIsAwake && !archerIsAwake && prisonerIsAwake) || (!archerIsAwake && petDogIsPresent);
}


console.log(canExecuteFastAttack(true));



