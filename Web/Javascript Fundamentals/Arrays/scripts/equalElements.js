function findNumbers() {

    var arrayString = jsConsole.read("#tb-number"),
        arrayInt = arrayString.split(',');
    for (var i in arrayInt) {
        arrayInt[i] = parseInt(arrayInt[i], 10);
    }
    var count = 1,
        lastCount = 1,
        element = 0,
        lastElement = 0;
    for (var i = 0; i < arrayInt.length - 1;) {
        count = 1;
        var currentIndex = i;
        while (arrayInt[currentIndex] == arrayInt[currentIndex + 1]) {
            count++;
            currentIndex++;
            element = arrayInt[i];
        }
        i += count;
        if (count > lastCount) {
            lastCount = count;
            lastElement = element;
        }
    }
    if (lastCount == 1) {
        jsConsole.writeLine("{" + arrayInt[0] + "}");
    }
    else {
        for (var i = 0; i < lastCount; i++) {
            if (i == 0) {
                jsConsole.write("{" + lastElement + ",");
            }
            else if (i < lastCount - 1) {
                jsConsole.write(lastElement + ",");
            }
            else {
                jsConsole.write(lastElement + "}");
            }
        }
    }
}
