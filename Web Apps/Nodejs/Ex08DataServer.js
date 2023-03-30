const http = require('http');
const fs = require('fs');
const parse = require("url").parse;//For handling HTTP GET Operations.
const qs =require("querystring");//For Handling HTTP POST Operations.

const currDir = __dirname;
const data = require('./MyData.json');
const empList = [
    {},{},{},{},{},{}
]
function errorPage(res){
    fs.createReadStream(currDir + "//ErrorPage.html").pipe(res);
}

function processGet(req, res){
    let data = parse(req.url, true).query;
    const msg = `<p>Thanks Mr. ${data.userName} for registering with us`;
    res.write(msg);
    //addRecordToFile(data);
    res.end();
}

function processPost(req, res){
    let inputValues = "";
    req.on("data", function(result){//Form is posted....
       inputValues += result;
    })

    req.on("end", function(){//Triggered when the form is posted and reaches the server
        let postedData = qs.parse(inputValues);
        const msg = `<p>Thanks Mr. ${postedData.userName} for registering with us<p>U will recieve Email to UR registered Email Address ${postedData["userEmail"]}`;
        res.write(msg);
        res.end();
    })
}
http.createServer((req, res)=>{
    if(req.method == "GET"){
        const query = parse(req.url).query;
        if(query !=null){
            processGet(req, res);
            return;
        }
    }else if(req.method =="POST"){
        processPost(req, res);
        return;
    }
    switch (req.url) {
        case "/Employees":
          res.write(JSON.stringify(empList));
          break;
        case "/Data":
            res.write(JSON.stringify(data));
            break;
        case "/Register":
            fs.createReadStream(currDir + "//RegistrationForm.html").pipe(res);
            return;
        default:
            errorPage(res);
            return;
    }
    res.end();
}).listen(1234);