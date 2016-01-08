var http = require('http'),
fs = require('fs');

var server = http.createServer(function(request, response) {
    response.writeHead(200, {
        'Content-Type': 'text/html'
    });
    
    response.write('Zdrasti');
    response.end();
});

server.listen(80);
console.log('Server is running on port 80');