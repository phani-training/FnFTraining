//Os module contains the APIs to get the info about the OS that the NODEJS environment is running. It gets the system info to the user. 
const os = require('os');
console.log(os.userInfo())
console.log(os.hostname());
console.log(os.arch());
console.log(os.platform());
console.log(os.version())
console.log("The Uptime of the OS is " + os.uptime()/3600 + " hrs")
console.log("The No CPUs this machine has " + os.cpus().length)
console.log("The System memory is " + os.totalmem())
