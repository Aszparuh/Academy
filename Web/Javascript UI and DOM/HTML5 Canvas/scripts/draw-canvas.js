// (function(){
// 	var canvas = document.getElementById('canvas'),
// 		ctx = canvas.getContext('2d'),
// 		CONSTANTS = {
// 		FACE_COLOR: 'rgb(144, 202, 215)',
// 		FACE_BORDER: 'rgb(34, 84, 95)',		
// 	}
// 	
// 	function drawCircle(x, y, radius, startAngle, endAngle) {
// 		ctx.arc(x, y, radius, startAngle, endAngle);
// 		ctx.stroke();
// 		ctx.fill();
// 	}
// 	
// }());
// 



var canvas = document.getElementById('canvas'),
	canvasCtx = canvas.getContext('2d');


canvasCtx.fillStyle = 'rgb(144, 202, 215)';
canvasCtx.strokeStyle = 'rgb(34, 84, 95)';
canvasCtx.save();
canvasCtx.lineWidth = 10;
canvasCtx.scale(1, 0.9);
canvasCtx.arc(200, 300, 110, 0, 2 * Math.PI);
canvasCtx.stroke();
canvasCtx.fill();


canvasCtx.restore();
canvasCtx.lineWidth = 5;
canvasCtx.beginPath();
canvasCtx.save();
canvasCtx.scale(1, 0.6);
canvasCtx.arc(130, 400, 20, 0, 2 * Math.PI);
canvasCtx.stroke();
canvasCtx.beginPath();
canvasCtx.arc(230, 400, 20, 0, 2 * Math.PI);
canvasCtx.stroke();
canvasCtx.restore();
//eyes
canvasCtx.beginPath();
canvasCtx.save();
canvasCtx.scale(0.6, 1);
canvasCtx.arc(210, 240, 10, 0, 2 * Math.PI);
canvasCtx.fillStyle = 'rgb(34, 84, 95)';
canvasCtx.fill();
canvasCtx.beginPath();
canvasCtx.arc(375, 240, 10, 0, 2 * Math.PI);
canvasCtx.fill();
canvasCtx.restore();
//mouth
canvasCtx.save();
canvasCtx.beginPath();
canvasCtx.rotate(Math.PI / 18);
canvasCtx.scale(1, 0.3);
canvasCtx.arc(230, 950, 40, 0, 2 * Math.PI);
canvasCtx.restore();
canvasCtx.stroke();
//nose
canvasCtx.moveTo(180, 285);
canvasCtx.lineTo(155, 285);
canvasCtx.lineTo(175, 245);
canvasCtx.stroke();
//hat
canvasCtx.save();
canvasCtx.beginPath();
canvasCtx.scale(1, 0.2);
canvasCtx.arc(200, 900, 130, 0, 2 * Math.PI);
canvasCtx.restore();
canvasCtx.fillStyle = 'rgb(57, 102, 147)';
canvasCtx.strokeStyle = 'rgb(26, 26, 26)';
canvasCtx.fill();
canvasCtx.stroke();
canvasCtx.save();
canvasCtx.beginPath();
canvasCtx.scale(1, 0.2);
canvasCtx.arc(210, 850, 70, 0, 1 * Math.PI);
canvasCtx.restore();
canvasCtx.lineTo(140, 40);
canvasCtx.fill();
canvasCtx.stroke();
canvasCtx.beginPath();
canvasCtx.save();
canvasCtx.scale(1, 0.2);
canvasCtx.arc(210, 200, 70, 2 * Math.PI, 0);
canvasCtx.restore();
canvasCtx.fill();
canvasCtx.stroke();
canvasCtx.lineTo(280, 175);
canvasCtx.stroke();
canvasCtx.fill();
