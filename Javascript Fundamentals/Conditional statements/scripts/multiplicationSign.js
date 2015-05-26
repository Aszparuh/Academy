function ShowSign() {
    var a = jsConsole.readFloat("#numberA")
    var b = jsConsole.readFloat("#numberB");
    var c = jsConsole.readFloat("#numberC");

    if (a === 0 || b === 0 || c === 0) {
        jsConsole.writeLine('The product is 0.');
    }
    else if (a < 0 ^ b < 0 ^ c < 0) {
        jsConsole.writeLine('The sign of the product is minus.');
    }
    else {
        jsConsole.writeLine('The sign of the product is plus.');
    }
}
