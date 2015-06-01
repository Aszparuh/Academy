function Convert() {
    var number = jsConsole.readFloat("#number");

    if (isNaN(number) || (number > 999) || (number < 0)) {
        jsConsole.writeLine('Wrong input');
    }

    var hundreds = Math.floor( number / 100);
    var tens = Math.floor(number / 10)% 10;
    var digit = number % 10;
    var teen = 10 + digit;
    var teenCase = "";
    var hundredsText = "";
    var tensText = "";
    var digitText;

    switch (teen) {
        case 11:
            teenCase = "eleven";
            break;
        case 12:
            teenCase = "twelve";
            break;
        case 13:
            teenCase = "thirteen";
            break;
        case 14:
            teenCase = "fourteen";
            break;
        case 15:
            teenCase = "fifteen";
            break;
        case 16:
            teenCase = "sixteen";
            break;
        case 17:
            teenCase = "seventeen";
            break;
        case 18:
            teenCase = "eighteen";
            break;
        case 19:
            teenCase = "nineteen";
            break;
    }

    switch (hundreds) {
        case 1:
            hundredsText = 'one hundred';
            break;
        case 2:
            hundredsText = 'two hundred';
            break;
        case 3:
            hundredsText = 'three hundred';
            break;
        case 4:
            hundredsText = 'four hundred';
            break;
        case 5:
            hundredsText = 'five hundred';
            break;
        case 6:
            hundredsText = 'six hundred';
            break;
        case 7:
            hundredsText = 'seven hundred';
            break;
        case 8:
            hundredsText = 'eight hundred';
            break;
        case 9:
            hundredsText = 'nine hundred';
            break;
        case 0:
            hundredsText = '';
            break;
    }
    if (number % 100 !== 0 && number >= 100) {
        hundredsText = hundredsText + ' and ';
    }
    if (tens === 1 && digit > 0) {
        jsConsole.writeLine(hundredsText + teenCase);
        console.log(hundredsText + teenCase);
        hundredsText = '';
        tensText = '';
    }

    switch (tens) {
        case 1:
            tensText = 'ten';
            break;
        case 2:
            tensText = 'twenty';
            break;
        case 3:
            tensText = 'thirty';
            break;
        case 4:
            tensText = 'forty';
            break;
        case 5:
            tensText = 'fifty';
            break;
        case 6:
            tensText = 'sixty';
            break;
        case 7:
            tensText = 'seventy';
            break;
        case 8:
            tensText = 'eighty';
            break;
        case 9:
            tensText = 'ninety';
            break;
        case 0:
            tensText = '';
            break;
    }

    switch (digit) {
        case 1:
            digitText = 'one';
            break;
        case 2:
            digitText = 'two';
            break;
        case 3:
            digitText = 'three';
            break;
        case 4:
            digitText = 'four';
            break;
        case 5:
            digitText = 'five';
            break;
        case 6:
            digitText = 'six';
            break;
        case 7:
            digitText = 'seven';
            break;
        case 8:
            digitText = 'eight';
            break;
        case 9:
            digitText = 'nine';
            break;
        default:
            digitText = '';
            break;
    }

    if (number === 0) {
        jsConsole.writeLine('Zero');
        console.log('Zero');
        hundredsText = '';
        tensText = '';
        digitText = '';
    }
    if (number <= 10 || number >= 20) {
        jsConsole.writeLine(hundredsText + tensText + ' ' + digitText);
        console.log(hundredsText + tensText + ' ' + digitText);
    }
}
