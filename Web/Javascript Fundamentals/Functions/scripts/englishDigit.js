function FindDigit(input) {
    var englishDigits = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
    return englishDigits[parseInt(input % 10)];
}

function PrintDigit() {
    var number = jsConsole.readFloat("#number");
    jsConsole.writeLine('The last digit is: ' + FindDigit(number));
}
