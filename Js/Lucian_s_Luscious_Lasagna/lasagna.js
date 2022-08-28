const PREPARATION_MINUTES_PER_LAYER = 2;
const EXPECTED_MINUTES_IN_OVEN = 40;

function remainingMinutesInOven(actualMinutesInOven) {
    return EXPECTED_MINUTES_IN_OVEN - actualMinutesInOven;
}

function preparationTimeInMinutes(numberOfLayers) {
    return PREPARATION_MINUTES_PER_LAYER * numberOfLayers;
}

function totalTimeInMinutes(numberOfLayers, actualMinutesInOven) {
    return preparationTimeInMinutes(numberOfLayers) + actualMinutesInOven;
}


console.log(`remaining minutes in oven => ${remainingMinutesInOven(30)}`);
console.log(`preparation time in minutes => ${preparationTimeInMinutes(2)}`);
console.log(`total Time In Minutes => ${totalTimeInMinutes(3, 20)}`);

