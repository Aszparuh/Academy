//task1
var integer = 5,
	floating = 5.5,
//task2
	string = '\'How you doin\'?\', Joey said\'',
	array = ['first','second','third'],
	boolean = true,
	car = {brand:"Fiat", model:500, color:"white"},
	valueNull = null,
	valueUndefined = undefined;
//task3
jsConsole.writeLine(typeof(integer) + ' ' + integer);
jsConsole.writeLine(typeof(floating) + ' ' + floating);
jsConsole.writeLine(typeof(string) + ' ' + string);
jsConsole.writeLine(typeof(array) + ' ' + array);
jsConsole.writeLine(typeof(boolean) + ' ' + boolean);
jsConsole.writeLine(typeof(car) + ' ' + car);
jsConsole.writeLine('object brand:' + ' ' + car.brand);
jsConsole.writeLine('object model:' + ' ' + car.model);
jsConsole.writeLine('object color:' + ' ' + car.color);
//task4
jsConsole.writeLine(typeof(valueNull) + ' ' + valueNull);
jsConsole.writeLine(typeof(valueUndefined) + ' ' + valueUndefined);
