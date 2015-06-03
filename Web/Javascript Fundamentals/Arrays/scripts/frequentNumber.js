function findNumbers() {

    var arrayString = jsConsole.read("#tb-number");
    var arrayInt = arrayString.split(',');
    for (var i in arrayInt) {
        arrayInt[i] = parseInt(arrayInt[i], 10);
    }
    var count = 1,
        finalCount = 1,
        element = arrayInt[0],
        finalElement = 0;
    for (var i = 0; i < arrayInt.length; i++) {
        count = 1;
        element = arrayInt[i];
        var tempIndex = i + 1;
        while (tempIndex < arrayInt.length) {
            if (arrayInt[tempIndex] == element) {
                count++;
            }
            tempIndex++;
        }
        if (count > finalCount) {
            finalCount = count;
            finalElement = element;
        }
    }
    if (finalCount > 1) {
        jsConsole.writeLine("The most frequent number is " + finalElement + " and it appears " + finalCount + " times!");
    }
    else {
        jsConsole.writeLine("The most frequent number is " + arrayInt[0] + " and it appears 1 time!");
    }
}
