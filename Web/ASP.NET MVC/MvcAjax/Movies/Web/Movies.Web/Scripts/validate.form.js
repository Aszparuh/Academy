//then in your parent page handle the form submission
$(function () {
	$("#submit-button").click(function () {
		if (!$("#form").valid()) {
			return false;
		}
	});
});