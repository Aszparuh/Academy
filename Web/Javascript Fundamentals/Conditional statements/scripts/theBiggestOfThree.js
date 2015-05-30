function FindGreatest() {
    var a = jsConsole.readFloat("#numberA");
    var b = jsConsole.readFloat("#numberB");
    var c = jsConsole.readFloat("#numberC");

    if (a > b) {
        if (a > c) {
            jsConsole.writeLine('The first number is biggest' + ' ' + a);
        }
        else if (a === c){
            jsConsole.writeLine('The third and first numbers are equal and bigger than the second:' + ' ' + a + ' ' + b);
        }
        else {
            jsConsole.writeLine('The third number is the greatest:' + ' ' + c)
        }
    }
    if (a < b) {
        if (b > c) {
            jsConsole.writeLine('The second number is greatest:' + ' ' + b);
        }
        else if (c === b) {
            jsConsole.writeLine('the second and the third numbers are equal and bigger than the first:' + ' ' + b + ' ' + c);
        }
        else {
            jsConsole.writeLine('The third number is the greatest:' + ' ' + c)
        }
    }
    if (a === b) {
        if (a === c) {
            jsConsole.writeLine('All numbers are equal.');
        }
        else if (a > c) {
            jsConsole.writeLine('First and second are equal and greater than the third:' + ' ' + a);
        }
        else {
            jsConsole.writeLine('First and second number are equal, the third is the greatest:' + ' ' + c);
        }
    }
}
