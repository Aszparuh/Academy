function Solve() {
    var a = jsConsole.readFloat("#numberA");
    var b = jsConsole.readFloat("#numberB");
    var c = jsConsole.readFloat("#numberC");

    if (isNaN(a) || isNaN(b) || isNaN(c)) {
        jsConsole.writeLine('Wrong input');
    }

    var discriminant = (b * b) - (4 * a * c);

    if (discriminant < 0) {
        jsConsole.writeLine('There are no real roots.')
    }
    else if (discriminant === 0) {
        var root = -b / (2 * a);
        jsConsole.writeLine('There is only one root: ' + root);
    }
    else {
        var sqrtDiscriminant = Math.sqrt(discriminant);
        var x1 = (-b + sqrtDiscriminant) / (2 * a);
        var x2 = (-b - sqrtDiscriminant) / (2 * a);
        jsConsole.writeLine('The roots are: ' + x1 + ', ' + x2);
    }
}
