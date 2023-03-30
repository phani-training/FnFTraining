//Nodejs is a Platform where U can execute on the normal machines, behaving like Server side Application environment.
//U may need actions to be performed on the objects. These are called as EVENTS.
//Events need to be registere, then triggered at appropriate time where an event handler would be invoked after the event is triggered. 
const events = require('events');//Module for event handling in Nodejs

const button = new events();

button.on("test", (msg)=> console.log(msg));
button.on("Click", ()=> console.log("Click event has occured"));

button.emit("test", "Testing has happened once")//emit method is used to trigger the event....

button.emit("Click");