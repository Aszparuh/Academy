function countDivs(element, count){
	if (element.toString() === '[object HTMLDivElement]') {
		count++;
		for (var i = 0; i < element.children.length; i++) {
			count = countDivs(element.children[i], count);
		}
	}
	return count;
}

var count = 0;
for (var i in document.body.children) {
	count = countDivs(document.body.children[i], count);
}

jsConsole.writeLine('The divs on the page are: ' + count);
