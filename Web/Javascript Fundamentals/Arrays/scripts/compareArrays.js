function compareArrays() {
    var arrayOneAsString = jsConsole.read("#tb-start");
    var arrayTwoAsString = jsConsole.read("#tb-number");

    var firstArray = arrayOneAsString.split(',');
    var secondArray = arrayTwoAsString.split(',');
    var arraysLenght = 0;
    for (var i in firstArray) {
        arraysLenght++;
    }


    for (var i = 0; i < arraysLenght; i++) {
        if (firstArray[i] > secondArray[i]) {

            jsConsole.writeLine(firstArray[i] + " is after " + secondArray[i] + " lexicographyclly!");
        }
        else {
            jsConsole.writeLine(firstArray[i] + " is before " + secondArray[i] + " lexicographyclly!");
        }
    }

}
