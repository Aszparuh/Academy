function wordCount(text, termToCount, isCaseSensitive) {
    var wordsArr = text.split(' ');
    var count = 0;

    for (var i = wordsArr.length - 1; i >= 0; i -= 1) {
        if (isCaseSensitive) {
            count = count + (termToCount === wordsArr[i]);
        }
        else {
            count = count + (termToCount.toUpperCase() === wordsArr[i].toUpperCase());
        }
    }
    return count;
}

function PrintCount() {
    var input = jsConsole.read("#text");
    var term = jsConsole.read("#term");

    jsConsole.writeLine('Case Sensitive:');
    jsConsole.writeLine(wordCount(input, term, true));
    jsConsole.writeLine('Case Insensitive:')
    jsConsole.writeLine(wordCount(input, term, false));
}
