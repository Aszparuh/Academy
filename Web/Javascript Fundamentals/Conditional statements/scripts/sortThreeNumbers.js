function SortNums() {
    var a = jsConsole.readFloat("#numberA");
    var b = jsConsole.readFloat("#numberB");
    var c = jsConsole.readFloat("#numberC");

    if (isNaN(a) || isNaN(b) || isNaN(c)) {
        jsConsole.writeLine('Wrong input');
    }
    if (b > a) {
        a = a + b;
        b = a - b;
        a = a - b;
    }
    if (c > a) {
        a = a + c;
        c = a - c;
        a = a - c;
    }
    if (c > b) {
        c = c + b;
        b = c - b;
        c = c - b;
    }

    jsConsole.writeLine(a + ' ' + b + ' ' + c);
}
