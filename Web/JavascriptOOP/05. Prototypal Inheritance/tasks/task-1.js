/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/

function solve() {
	var domElement = (function () {

	function checkTypeName(value, itemToCheck) {
		if (typeof value !== 'string') {
			throw 'Type should be string';
		}
		if (value === '') {
			throw 'Type should not be empty string';
		}
		if (itemToCheck === 'type') {
			if (!(/^[a-zA-Z0-9]+$/.test(value))) {
				throw 'Type contains bad characters';
			}
		}
		else {
			if (/\d/.test(value)) {
				throw 'Name contains digits'
			}
		}
	}

	var domElement = {
		//Properties
		get type() {
			return this._type;
		},
		set type(value) {
			checkTypeName(value, 'type');
			this._type = value;
		},
		get attributes() {
			return this._attributes;
		},
		set attributes(value) {
			this._attributes = value;
			return this;
		},
		get children() {
			return this._children;
		},
		set children(value) {
			this._children = value;
		},
		get parent() {
			return this._parent;
		},
		set parent(value) {
			this._parent = value;
		},
		get content() {
			return this._content;
		},
		set content(value) {
			this._content = value;
		},
		get innerHTML() {
			var html = '<' + this.type,
				keys = [],
				k,
				i,
				len,
				childrenLen,
				children;
				
			for (k in this.attributes) {
				if (this.attributes.hasOwnProperty(k)) {
					keys.push(k);
				}
			}
			
			keys.sort();
			len = keys.length;
			
			for ( i = 0; i < len; i += 1) {
				html += ' ';
				html += keys[i];
				html += '="';
				html += this.attributes[keys[i]];
				html += '"';
			}
			
			html += '>';
			if (this.children.length > 0) {
				childrenLen = this.children.length;
				children = this.children;
				for (i = 0; i < childrenLen; i += 1) {
					if (typeof children[i] === 'string') {
						html += children[i];
					}
					else {
						html += children[i].innerHTML;
					}
				}
			}
			else if(this.content) {
				html += this.content;
			}
			html += '</' + this.type + '>';
			return html;
			//return '<' + this.type + '></' + this.type + '>';
		},
		
		//Methods
		init: function (type) {
			this.type = type,
			this.attributes = {},
			this.parent,
			this.content,
			this.children = [];
			return this;
		},
		appendChild: function (child) {
			this.children.push(child);
			child.parent = this;
			return this;
		},
		addAttribute: function (name, value) {
			checkTypeName(name, 'name');
			this.attributes[name] = value;
			return this;
		},
		removeAttribute: function (name) {
			if (this.attributes[name]) {
				delete this.attributes[name];
				return this;
			}
			
			throw 'Attribute does not exist';
		}
	};
	
	return domElement;
} ());
	return domElement;
}

module.exports = solve;