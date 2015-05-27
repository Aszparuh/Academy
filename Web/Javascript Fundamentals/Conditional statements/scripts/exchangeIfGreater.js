function ExchangeIfGreater() {
    var a = jsConsole.readFloat("#numberA");
    var b = jsConsole.readFloat("#numberB");
    jsConsole.writeLine();
    jsConsole.writeLine('a = ' + a);
    jsConsole.writeLine('b = ' + b);

    if (a > b) {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    jsConsole.writeLine();
    jsConsole.writeLine('a = ' + a);
    jsConsole.writeLine('b = ' + b);
}
