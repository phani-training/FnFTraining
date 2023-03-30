const http = require('http');
const fs = require('fs');
const currDir = __dirname;
const data = require('./MyData.json');
const empList = [
    {},{},{},{},{},{}
]
function errorPage(res){
    fs.createReadStream(currDir + "//ErrorPage.html").pipe(res);
}
http.createServer((req, res)=>{
    switch (req.url) {
        case "/Employees":
          res.write(JSON.stringify(empList));
          break;
        case "/Data":
            res.write(JSON.stringify(data));
            break;
        default:
            errorPage(res);
            return;
    }
    res.end();
}).listen(1234);