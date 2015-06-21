/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {
	//debugger;
	//console.log(findPrimes.arguments);
	if (arguments.length !== 2) {
		throw new Error();
	}
	if (isNaN(+to) || isNaN(+from)) {
		throw new Error();
	}
	var divisor,
		i,
		maxDivisor,
		isPrime,
		resultArr = [];
		
	for (i = +from; i <= +to; i += 1) {
		maxDivisor = Math.sqrt(i);
		isPrime = true;
		for (divisor = 2; divisor <= maxDivisor; divisor += 1) {
			if (!(i % divisor)) {
				isPrime = false;
				break;
			}
		}
		
		if (isPrime && i > 1) {
			resultArr.push(i);
		}
	}
	
	return resultArr;
}

//console.log(findPrimes(258, 262));

module.exports = findPrimes;
