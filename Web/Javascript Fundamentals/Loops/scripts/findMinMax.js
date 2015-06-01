function Find() {
    var arr = [1 ,2 ,3 , 4, 5, 6],
        min = arr[0],
        max = arr[0],
        i;


    for (i = 0; i < arr.length; i += 1) {
        if (arr[i] > max) {
            max = arr[i];
        }
        if (arr[i] < min) {
            min = arr[i];
        }
    }

    jsConsole.writeLine('Min is: ' + min);
    jsConsole.writeLine('Max is: ' + max);
}
