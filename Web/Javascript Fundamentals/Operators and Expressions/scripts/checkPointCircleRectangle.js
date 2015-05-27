function CheckPoint() {
	var x = jsConsole.readFloat("#pointX");
	var y = jsConsole.readFloat("#pointY");
	var radius = 3;

	//Check if the point is in the circle K( (1,1), 3).
	var xToCenter = x - 1;
	var yToCenter = y - 1;
	var isInCircle = ((xToCenter * xToCenter) + (yToCenter * yToCenter)) <= radius * radius;

	//Check if the point is outside the rectangle R(top=1, left=-1, width=6, height=2).
	var isOut = (x > 5) || (x < -1) || (y > 1) || (y < -1);

	if (isInCircle && isOut) {
		jsConsole.writeLine('yes');
	}
	else {
		jsConsole.writeLine('no');
	}
}
