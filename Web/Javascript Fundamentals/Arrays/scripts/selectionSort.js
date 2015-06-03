function findNumbers() {

    var arrayString = jsConsole.read("#tb-number"),
        arrayInt = arrayString.split(',');
    for (var i in arrayInt) {
        arrayInt[i] = parseInt(arrayInt[i], 10);
    }
    var currnetSmallest = arrayInt[0];
    for (var i = 0; i < arrayInt.length; i++) {
        currnetSmallest = arrayInt[i];
        var tempIndex = i + 1,
            indexOftheSmallest = 0,
            enteredInIfInTheSecondLoop = false;
        while (tempIndex<arrayInt.length) {
            if (currnetSmallest > arrayInt[tempIndex]) {
                currnetSmallest = arrayInt[tempIndex];
                indexOftheSmallest = tempIndex;
                tempIndex++;
                enteredInIfInTheSecondLoop = true;
            }
            else {
                tempIndex++;
            }
        }
        if (enteredInIfInTheSecondLoop) {
            var tempVar = arrayInt[i];
            arrayInt[i] = currnetSmallest;
            arrayInt[indexOftheSmallest] = tempVar;
        }
    }
    
    if (arrayInt.length==1) {
        jsConsole.write("{" + arrayInt[0] + "}");
    }
    else {
        for (var i = 0; i < arrayInt.length; i++) {
            if (i == 0) {
                jsConsole.write("{" + arrayInt[i] + ",");
            }
            else if (i < arrayInt.length - 1) {
                jsConsole.write(arrayInt[i] + ",");
            }

            else {
                jsConsole.write(arrayInt[i] + "}");
                jsConsole.writeLine();
            }
        }
    }
}
