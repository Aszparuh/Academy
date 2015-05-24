function isInCircle() {
	var x = jsConsole.readFloat("#pointX");
	var y = jsConsole.readFloat("#pointY");
	var radius = 5;
	var isItInCircle = ((x * x) + (y * y)) <= radius * radius;
	console.log(isItInCircle); 

	if (isItInCircle) {
		jsConsole.writeLine("true");
	}
	else {
		jsConsole.writeLine("false");
	}
}