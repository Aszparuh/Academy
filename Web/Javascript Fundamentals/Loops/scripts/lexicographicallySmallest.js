function FindSmallest() {
    var smallest = 'z',
        largest = '',
        property;


    for(property in document) {
        if (property < smallest) {
            smallest = property;
        }
        if (property > largest) {
            largest = property
        }
    }
    jsConsole.writeLine('document - smallest: ' + smallest);
    jsConsole.writeLine('document - largest: ' + largest);

    smallest = 'z',
    largest = '';

    for(property in window) {
        if (property < smallest) {
            smallest = property;
        }
        if (property > largest) {
            largest = property
        }
    }
    jsConsole.writeLine('window - smallest: ' + smallest);
    jsConsole.writeLine('window - largest: ' + largest);

    smallest = 'z',
    largest = '';

    for(property in navigator) {
        if (property < smallest) {
            smallest = property;
        }
        if (property > largest) {
            largest = property
        }
    }
    jsConsole.writeLine('navigator - smallest: ' + smallest);
    jsConsole.writeLine('navigator- largest: ' + largest);
}
