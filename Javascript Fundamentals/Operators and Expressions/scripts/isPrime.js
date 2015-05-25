function CheckPrime() {
	var chosenNumber = jsConsole.readFloat("#number");
	var isPrime = true;

	if (isInt(chosenNumber)) {

		if (chosenNumber > 100) {
			jsConsole.writeLine('The number is out of range.');
			return;
		}
		if ((chosenNumber % 2 === 0) || (chosenNumber % 3 === 0) || (chosenNumber % 5 === 0) || (chosenNumber % 7 === 0)) {
			isPrime = false;
		}

		if ((chosenNumber === 2) || (chosenNumber === 3) || (chosenNumber === 5) || (chosenNumber === 7)) {
			isPrime = true;
		}

		if (isPrime) {
			jsConsole.writeLine(chosenNumber + " is prime.");
		}
		else {
			jsConsole.writeLine(chosenNumber + " is not prime.");
		}
	
		console.log(isPrime);
	}
	else {
		jsConsole.writeLine('Invalid input');
	}


	function isInt(n) {
		return Math.round(n) === n;
	}
}