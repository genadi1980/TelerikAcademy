'use strict'

const examPoints = 300;
const totalPoints = 90;

const hasExcellence = examPoints >= 250 || totalPoints >= 60;
const passing = totalPoints >= 30 && examPoints > 70;

console.log(`Pass: ${passing}`);
console.log(hasExcellence);