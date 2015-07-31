
/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
	* Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
	* The provided first parameter is neither string or existing DOM element
	* The provided id does not select anything (there is no element that has such an id)
	* Any of the function params is missing
	* Any of the function params is not as described
	* Any of the contents is neight `string` or `number`
		* In that case, the content of the element **must not be** changed   
*/

	
	function validateElement(element) {
		var selectedElement;
		
		if (element instanceof HTMLElement) {
			selectedElement = element;
		} else if (typeof element === 'string') {
			selectedElement = document.getElementById(element);
		} else	{
			throw new Error('Element is not HTML element or string')
		}
		
		return selectedElement;
	}
	
	function validateContent(contents) {
		var len;
		for (var i = 0, len = contents.length; i < len; i++) {
			if (typeof contents[i] !== 'string' && typeof contents[i] !== 'number') {
				throw new Error('Content is not string or number');
			}
		}
		
		return contents;
	}
	
	function CreateFragmentWithContent(contents) {
		var documentFragment = document.createDocumentFragment(),
			emptyDiv = document.createElement('div'),
			len = contents.length,
			currentDiv;
		
		for (var i = 0; i < len; i += 1) {
			currentDiv = emptyDiv.cloneNode(true);
			currentDiv.innerHTML = contents[i];
			documentFragment.appendChild(currentDiv);
		}
		
		return documentFragment;
	}
	
	function AddDivs(element, contents) {
		var validElement = validateElement(element),
			validContent = validateContent(contents);
		
		return validElement.appendChild(CreateFragmentWithContent(validContent));
	}
	
debugger;
var el = AddDivs('div', ['ddd','ben','con']);
console.log(el);

