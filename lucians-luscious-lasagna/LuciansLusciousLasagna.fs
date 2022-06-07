module LuciansLusciousLasagna

let expectedMinutesInOven = 40

let elapsedTimeByLayer = 2
let remainingMinutesInOven timeInOven = expectedMinutesInOven - timeInOven

let preparationTimeInMinutes countLayers = elapsedTimeByLayer * countLayers


let elapsedTimeInMinutes countLayers elapsedInOven =
    preparationTimeInMinutes countLayers
    + elapsedInOven
