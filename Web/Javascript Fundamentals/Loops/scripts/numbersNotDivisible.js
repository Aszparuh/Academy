function FindNums() {
    var n = jsConsole.readInteger("#number");
    var i;
    for (i = 1; i <= n; i += 1) {
        if ((i % 3) && (i % 7)) {
            jsConsole.writeLine(i);
        }
    }
}
