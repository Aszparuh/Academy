function Reverse(input) {
    var result='';
    for (var i = input.length - 1; i >= 0; i -= 1) {
        result += input[i];
    }

    return result;
}
function Print() {
    var input = jsConsole.read("#number");
    jsConsole.writeLine(Reverse(input));
}
