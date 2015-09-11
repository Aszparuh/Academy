/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(args) {
	if (args === undefined) {
		throw new Error();
	}
	if (args.length === 0) {
		return null;
	}
	
	var sumAll = args.reduce(function (total, num) {
		num = +num;
		if (isNaN(num)) {
			throw new Error();	
		}
		
		return total + num;
	}, 0);
	return sumAll;
}

module.exports = sum;