function Find() {
    var a = jsConsole.readFloat("#numberA");
    var b = jsConsole.readFloat("#numberB");
    var c = jsConsole.readFloat("#numberC");
    var d = jsConsole.readFloat("#numberD");
    var e = jsConsole.readFloat("#numberE");
    var greatestNumber;

    if ((a > b) && (a > c) && (a > d) && (a > e)) {
            greatestNumber = a;
        }
        else if ((b > a) && (b > c) && (b > d) && (b > e)) {
            greatestNumber = b;
        }
        else if ((c > a) && (c > b) && (c > d) && (c > a)) {
            greatestNumber = c;
        }
        else if ((d > a) && (d > b) && (d > c) && (d > e)) {
            greatestNumber = d;
        }
        else {
            greatestNumber = e;
        }

        jsConsole.writeLine(greatestNumber);
}
