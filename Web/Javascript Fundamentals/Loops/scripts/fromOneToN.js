function CountToN() {
    var n = jsConsole.readInteger("#number");
    var i;
    for (i = 1; i <= n; i+= 1) {
        jsConsole.writeLine(i);
    }
}
