function CalculateArea() {
	var width = jsConsole.readFloat("#width");
	var height = jsConsole.readFloat("#height");
	console.log(width);
	console.log(height);

	if ((width <= 0) || (height <= 0)) {
		jsConsole.writeLine('Widht or height cannot be equal or less than zero.');
	}
	else {
		jsConsole.writeLine('Area is :' + ' ' + (width * height));
	}
}