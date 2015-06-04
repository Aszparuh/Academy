function CheckNeighbors(){
    var pos = parseInt(jsConsole.readFloat("#search")),
        arrayString = jsConsole.read("#tb-number"),
        arr = arrayString.split(',');

	if (pos < 1) {
		jsConsole.writeLine('Position is too small');
	} else if (pos > arr.length - 2 ) {
        jsConsole.writeLine('Position is too big');
	} else {
		if (arr[pos] > arr[pos + 1] && arr[pos] > arr[pos - 1]) {
            jsConsole.writeLine('Element is bigger than neighbours.')
		}
        else {
            jsConsole.writeLine('Element is not bigger than neighbours.')
        }
	}
}
