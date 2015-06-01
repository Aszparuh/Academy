function CountToN() {
    var n = jsConsole.readInteger("#number");
    var i;

    if (n >= 1) {
        for (i = 1; i <= n; i += 1) {
            jsConsole.writeLine(i);
        }
    }
    else {
        for (i = 1; i >= n; i -= 1) {
            jsConsole.writeLine(i);
        }
    }
}
