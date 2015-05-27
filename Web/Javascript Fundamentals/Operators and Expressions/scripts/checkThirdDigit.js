function CheckThird() {
	var chosenNumber = jsConsole.readFloat("#number");
	var isSeven = Math.abs((~~(chosenNumber / 100))) % 10 === 7;
	console.log(isSeven);
	
	if (isSeven) {
		jsConsole.writeLine('true');
	}
	else {
		jsConsole.writeLine('false');
	}
}