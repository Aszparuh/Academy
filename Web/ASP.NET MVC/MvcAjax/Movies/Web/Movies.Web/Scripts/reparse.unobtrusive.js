//this code goes in your partialview
$(function () {
    //allow the validation framework to re-prase the DOM
    jQuery.validator.unobtrusive.parse();

    //or to give the parser some context, supply it with a selector
    //jQuery validator will parse all child elements (deep) starting
    //from the selector element supplied
    jQuery.validator.unobtrusive.parse("#form");
});