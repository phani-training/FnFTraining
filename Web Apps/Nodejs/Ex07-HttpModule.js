//http module is a very important module that is used for creating server side programming in Nodejs. 
//With this, it allows to process web pages(HTML) using HttpRequest and HttpResponse objects. 
//With Http Module, we can create Web Apps, Web APIs and other kinds of Internet based Applications. Http is the std protocol for all internet activities. 
const http = require('http');
const fs = require("fs");
const currDir = __dirname;//Current directory..

function processUrl(request, response){
    const url = request.url;
    const content = url + " and its contents are processed and sent";
    response.write(content);
    response.end();
}
http.createServer((request, response)=>{
    if(request.url != "/favicon.ico"){
        if(request.url == "/Client"){
            fs.createReadStream(currDir + "\\Client.html").pipe(response);
            return;
        }else{
            processUrl(request, response);
            return;
        }
    }
        
    // response.write("hello from Web server");
    // response.end();//Send the response to the Request.    
}).listen(1234);
//Access this web App as http://localhost:1234