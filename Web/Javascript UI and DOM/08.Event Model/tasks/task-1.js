function solve(){
	function validateSelector(selector) {
		var selectedElement;
		if (selector instanceof HTMLElement) {
			selectedElement = selector;
		} else if (typeof selector === 'string') {
			selectedElement = document.getElementById(selector);
			if (!selectedElement) {
				throw new Error('There is no element with ' + selector + ' id.');
			}
		} else {
			throw new Error('Selector is not string or HTML element');
		}
		
		return selectedElement;
	};
	
	function addHideContent(buttons) {
		var len = buttons.length;
		if (!buttons) {
			throw new Error('Null buttons');
		}
		
		for (var index = 0; index < len; index += 1) {
			buttons[index].innerHTML = 'hide';
		}
	};
	
	function hideExactContent(element) {
		var elementTarget = element.target,
			isContentVisible,
			nextElement;
			
		if (elementTarget.className === 'button') {
			nextElement = elementTarget.nextSibling;
			while (nextElement) {
				if (nextElement.className === 'content') {
					isContentVisible = nextElement.style.display === '';
					
					if (isContentVisible) {
						nextElement.style.display = 'none';
						elementTarget.innerHTML = 'show';
					} else {
						nextElement.style.display = '';
						elementTarget.innerHTML = 'hide';
					}
					
					break;
				}
				
				nextElement = nextElement.nextSibling;
			}
		}
	}
	
	return function (selector) {
		var element = validateSelector(selector);
		var buttons = element.getElementsByClassName('button');
		addHideContent(buttons);
		element.addEventListener('click', function(ev) {
			hideExactContent(ev);
		}, false);
	};
};

module.exports = solve;