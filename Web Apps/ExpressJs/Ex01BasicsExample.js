const express = require('express');
const parser = require('body-parser');

const app = express();

const root  = __dirname;

//Middleware to be provided. 
app.use(parser.urlencoded({extended : false}))

app.get("/", (req, res)=> res.send("Welcome to Express Programming"))
app.get("/Employees", (req, res)=> res.send("Emp List will be shared shortly"))
app.get("/Client", (req, res)=> res.sendFile(root + "/Client.html"));
app.get("/Register", (req, res)=> res.sendFile(root + "/RegistrationForm.html"));

app.get("/AfterRegister", (req, res)=>{
    const name = req.query.userName;
    const email = req.query.userEmail;
    const msg = `Mr.${name}, Thanks for joining us, <br/>U will be contacted using ${email} as UR official Email Address`;
    res.send(msg);
})

app.post("/AfterRegister", (req, res)=>{
    if(req.body == undefined){
        console.log("No body is formed while the Form is posted")
    }else{
        const name = req.body.userName;
        const email = req.body.userEmail;
        const msg = `Mr.${name}, Thanks for posting to us, <br/>U will be contacted using ${email} as UR official Email Address`;
        res.send(msg);
    }
})


app.listen(1234, ()=>console.log("Server is available at 1234"));