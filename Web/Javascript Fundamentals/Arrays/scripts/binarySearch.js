function Find() {
    var search = jsConsole.readFloat("#search"),
        arrayString = jsConsole.read("#tb-number"),
        arrayInt = arrayString.split(','),
        sortedArr = arrayInt.sort(function(a, b) {return a - b;});
        jsConsole.writeLine(sortedArr);
        binarySearch(sortedArr, search, 0, sortedArr.length - 1);

        function binarySearch(values, target, start, end) {
          if (start > end) { return -1; } //does not exist

          var middle = Math.floor((start + end) / 2);
          var value = values[middle];

          if (value > target) { return binarySearch(values, target, start, middle-1); }
          if (value < target) { return binarySearch(values, target, middle+1, end); }
          jsConsole.writeLine(middle)
          return middle; //found!
    }
}
