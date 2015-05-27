function CheckDivision() {
	var chosenNumber = jsConsole.readFloat("#number");

	if (chosenNumber % 5 === 0 && chosenNumber % 7 === 0) {
		jsConsole.writeLine(chosenNumber + ' ' + 'can be divided by 5 and 7 without reminder.');
	}
	else {
		jsConsole.writeLine(chosenNumber + ' ' + 'cannot be divided by 5 and 7 without reminder.');
	}
}