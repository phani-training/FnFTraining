const express = require('express');
const app = express();

const root  = __dirname;
app.get("/", (req, res)=> res.send("Welcome to Express Programming"))
app.get("/Employees", (req, res)=> res.send("Emp List will be shared shortly"))
app.get("/Client", (req, res)=> res.sendFile(root + "/Client.html"));
app.listen(1234, ()=>console.log("Server is available at 1234"));