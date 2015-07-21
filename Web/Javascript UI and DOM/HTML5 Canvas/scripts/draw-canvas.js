var canvas = document.getElementById('canvas'),
	canvasCtx = canvas.getContext('2d');

canvasCtx.lineWidth = 5;
canvasCtx.fillStyle = 'rgb(144, 202, 215)';
canvasCtx.strokeStyle = 'rgb(34, 84, 95)';
canvasCtx.save();
canvasCtx.scale(1, 0.9);
canvasCtx.arc(200, 300, 110, 0, 2 * Math.PI);
canvasCtx.stroke();
canvasCtx.fill();

canvasCtx.restore();
canvasCtx.scale(1, 0.6);
canvasCtx.arc(130, 400, 20, 0, 2 * Math.PI);
canvasCtx.stroke();