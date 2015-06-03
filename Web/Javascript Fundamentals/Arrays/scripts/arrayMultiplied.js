function findNumbers() {
    var arr = new Array(20);
    for (var i = 0; i < arr.length; i++) {
        arr[i] = (i + 1) * 5;
        jsConsole.writeLine(arr[i]);
    }
}
