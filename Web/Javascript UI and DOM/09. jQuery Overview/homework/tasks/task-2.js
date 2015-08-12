/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {
    var $selectedElement = $(selector),
        $buttons = $selectedElement.find('.button');
    if (typeof selector !== 'string') {
       throw new Error();
    }
    
    if (!$selectedElement.length) {
       throw new Error();
    }
    
    $selectedElement.on('click', function(ev) {
      var clickedButton = ev.target;
				var nextContent = clickedButton.nextElementSibling;
				while (nextContent && nextContent.className.indexOf('content') < 0) {
					nextContent = nextContent.nextElementSibling;
				}

				var isContentVisible = nextContent.style.display === '';
				if (isContentVisible) {
					nextContent.style.display = 'none';
					clickedButton.innerHTML = 'show';
				} else {
					nextContent.style.display = ''; // <=> display: block;
					clickedButton.innerHTML = 'hide';
				}
    });
    
//     for (var i = 0; i < $buttons.length; i++) {
//         var $currentElement = $($buttons[i]);
//         $currentElement.text('hide');
//         $currentElement.on('click', function() {
//           var $this = $(this);
// 
//           var $nextContent = $this.nextAll('.content').first(),
//               $nextBtn = $nextContent.nextAll('.button').first();
// 
//         if ($nextBtn.length && $nextContent.length) {
//             if ($nextContent.css('display') === 'none') {
//                 $nextContent.css('display', '');
//                 $this.text('hide');
//             } else {
//                 $nextContent.css('display', 'none');
//                 $this.text('show');
//             }
//         }
//         });
      

  };
};

module.exports = solve;