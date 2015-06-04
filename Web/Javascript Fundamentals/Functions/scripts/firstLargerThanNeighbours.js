function PrintResult() {
    var arrayString = jsConsole.read("#tb-number"),
    arr = arrayString.split(',');

    if (CheckNeighbors(arr) > 0) {
        jsConsole.writeLine("The first element bigger than its neigbours is on " + CheckNeighbors(arr) + ' position');
    }
    else {
        jsConsole.writeLine('There is no such element.')
    }
}

function CheckNeighbors(arr) {
    for (var i = 1; i < arr.length - 1; i+=1) {
        if (arr[i] > arr[i - 1] && (arr[i] > arr[i + 1])) {
            return i;
        }
    }

    return -1;
}
