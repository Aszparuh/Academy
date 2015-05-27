function CheckBit() {
	var chosenNumber = jsConsole.readFloat("#number");
	var mask = 1 << 3;
	var bitValue = (chosenNumber & mask) >> 3;
	console.log(bitValue);
	jsConsole.writeLine('Third bit has value of ' + bitValue);
}