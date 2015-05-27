function CheckIfOddOrEven() {
	var chosenNumber = jsConsole.readFloat("#number");

	if (IsInt(chosenNumber)) {
		if (chosenNumber % 2) {
			jsConsole.writeLine(chosenNumber + ' ' + 'is odd.');
		}
		else {
			jsConsole.writeLine(chosenNumber + ' ' + 'is even.');
		}
	}
	else {
		jsConsole.writeLine('Oddness and evenness only applies to whole numbers (integers)');
	}
	
}

function IsInt(n) {
	return parseInt(n) === n
}