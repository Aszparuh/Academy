function Convert() {
    var number = jsConsole.readFloat("#number");

    if (isNaN(number) || (number > 999) || (number < 0)) {
        jsConsole.writeLine('Wrong input');
    }

    var digit = number % 10;
    var teens = 
}
