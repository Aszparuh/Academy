function solve() {
	
	function validatePresentation(presentation) {
		if (!(presentation.length > 0)) {
			throw 'Presentation is empty';
		}
		if (!presentation.every(validateTitle)) {
			throw 'There is invalid title in the presentation';
		}
	}
	
	function validateTitle(title) {
		if (/^\s/.test(title)) {
			throw 'White space at the begining of title';
		}
		if(!title) {
			throw 'Title empty or undefined';
		}
		if (/\s$/.test(title)) {
			throw 'White space at the end of title';
			
		}
		if (/\s{2,}/.test(title)) {
			throw 'Consecutive white spaces';
		}
		
		return title;
	}
	
	function validateStudentName(name) {
		var names = name.split(' ');
		
		if (typeof name !== 'string') {
			throw 'Name is not a string';
		}
		if (names.length !== 2) {
			throw 'Name does not contain first and second name';
		}
	}
	
	function isValidName(name) {
		if (!(/[A-Z]/.test(name))) {
			throw 'Names does not statrts with capital letter';
		}
	}
	
	function validateIds(studentId, homeworkId, numberOfStudents, numberOfHomeworks) {
		if (studentId % 1 !== 0 || studentId <= 0) {
			throw 'Not valid student ID';
		}
		if (homeworkId % 1 !== 0 || homeworkId <= 0) {
			throw 'Not valid homework ID';
		}
		if (studentId > numberOfStudents) {
			throw 'Wrong Student ID';
		}
		if (homeworkId > numberOfHomeworks) {
			throw 'Wrong homework Id';
		}
	}
	
	var Course = {
		init: function(title, presentation) {
			validatePresentation(presentation);
			
			this._title = validateTitle(title);
			this._presentation = presentation;
			this._students = [];
			this._studentID = 0;
			
			return this;
		},
		addStudent: function(name) {
			var names = name.split(' ');
			validateStudentName(name);
			isValidName(names[0]);
			isValidName(names[1]);
			this._students.push({firstname: names[0], lastname: names[1], id: ++this._studentID});
			return this._studentID;		
		},
		getAllStudents: function() {
			return this._students.slice();
		},
		submitHomework: function(studentId, homeworkId) {
			this._homework = [];
			validateIds(studentId, homeworkId, this._students.length, this._presentation.length);
		
			this._homework[studentId] = [].push(homeworkId);
			return this;
		},
		pushExamResults: function(result) {
			
		},
		getTopStudents: function() {
			
		}
	};
	
	return Course;
}

module.exports = solve;