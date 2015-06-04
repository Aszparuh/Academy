function CountNumbers(arr, val) {
    var count = 0;
	for (var i = arr.length - 1; i >= 0; i -= 1) {
		count = count + (arr[i] == val);
	}

	return count;
}

function PrintResult() {
    var search = jsConsole.readFloat("#search"),
        arrayString = jsConsole.read("#tb-number"),
        arr = arrayString.split(',');

        jsConsole.writeLine('The numbers appears ' + CountNumbers(arr, search) + ' times.')
}
