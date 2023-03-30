//Working on FileSystem..
const fs = require('fs');
//fs module contains APIs for File IO operations. Nodejs supports both Sync and Async Functions  to perform IO ops. 

const filename = "./Ex04-FsModule.js"
// const contents = fs.readFileSync(filename, 'utf-8');
// console.log(contents)

/////////////////////Example on Async File Reading//////////////
// fs.readFile(filename, 'utf-8', (err, data)=>{
//     if(err)console.log(err)
//     else{
//         console.log(data)
//     }
// })
// console.log("first line of the code")
/////////////////////Example on Sync File Writing//////////////
// const obj = { };
// obj.id = 123; obj.name = "testName"; obj.address ="testAddress";

// fs.writeFileSync("SampleTextFile.txt", JSON.stringify(obj), 'utf-8');
// console.log("The file is written completely")
///////////////////Exampleon Sync File Appending///////////////////
const obj = { };
obj.id = 123; obj.name = "testName"; obj.address ="testAddress";
let data = `, ${JSON.stringify(obj)}`;
fs.appendFileSync("SampleTextFile.txt", data, 'utf-8');
console.log("The file is written completely")
/////////////Try URSELF->async version of file Writing and file appending//
//Assignment: Create a Nodejs App that stores the data in the form of Comma seperated Value file(CSV). 

