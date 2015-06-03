function findNumbers() {

    var arrayString = jsConsole.read("#tb-number");
    var arrayInt = arrayString.split(',');
    for (var i in arrayInt) {
        arrayInt[i] = parseInt(arrayInt[i], 10);
    }
    var count = 1,
        lastCount = 1;
    for (var i = 0; i < arrayInt.length - 1;) {
        var tempArr = [];
        tempArr.push(arrayInt[i]);
        count = 1,
        tempIndex = i;
        while (arrayInt[tempIndex] < arrayInt[tempIndex + 1]) {
            count++;
            tempIndex++;
            tempArr.push(arrayInt[tempIndex]);
        }

        i += count;
        if (count > lastCount) {
           lastCount = count;
            var finallArr = [].concat(tempArr);
        }
    }
    
    if (lastCount == 1) {
        jsConsole.writeLine("{" + arrayInt[0] + "}");
    }
    else {
        for (var i = 0; i < finallArr.length; i++) {
            if (i == 0) {
                jsConsole.write("{" + finallArr[i] + ",");
            }
            else if (i < finallArr.length - 1) {
                jsConsole.write(finallArr[i] + ",");
            }
            else {
                jsConsole.writeLine(finallArr[i] + "}");
            }
        }
    }
}
