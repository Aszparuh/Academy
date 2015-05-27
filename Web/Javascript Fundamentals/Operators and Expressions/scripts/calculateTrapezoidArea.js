function CalculateArea() {
	var base1 = jsConsole.readFloat("#base1");
	var base2 = jsConsole.readFloat("#base2");
	var height = jsConsole.readFloat("#height");

	jsConsole.writeLine(((base1 + base2) * height) / 2);
}