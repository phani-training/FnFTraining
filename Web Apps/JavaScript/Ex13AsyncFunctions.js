//2 types of functions: Sync and Async Functions. 
//Sync Function-> Execution of the function where the next statment has to wait till the function completes. 
const boilWater = () => console.log("Water is boiling");
const addTea = () => console.log("Tea is added to boiled water");
const addMilk = () => console.log("Milk is added to boiling Tea Decoction");
const drinkTea = () => console.log("Tea is being drunk after the previous 3 tasks are completed");

// boilWater();
//addTea();
//addMilk();
//drinkTea();
function doAsyncOperation(callBack, func){
    setTimeout(()=>{
        callBack(func)
    }, 5000);
}

//setTimeout(boilWater, 5000);
// setTimeout(addTea, 5000);
// setTimeout(addMilk, 5000);
// setTimeout(drinkTea, 5000);

// doAsyncOperation(boilWater, addTea);
// doAsyncOperation(addMilk, drinkTea);

///////////////////////////Using Promise object////////////////////////
// const boilingOperation = new Promise(function(resolve,reject){
//     console.log("This statement executes immediately");
//     setTimeout(()=>{
//         const value = prompt("Enter a value from 1 to 10");
//         if (value < 6) {
//             boilWater();
//             resolve("Water boiling is done!!!");
//         } else {
//             reject("OOPS! Something went wrong")
//         }
//     }, 5000);
// })
// console.log("Some other operations are going on!!!");
// boilingOperation.then((data)=>{
//     alert(data);
// }).catch((msg)=>{
//     alert(msg)
// }).finally(()=>{
//     console.log("Last of the operation");
// })
////////////////////Using async and await///////////////////////////////////////
async function doAsyncOperation(){
    //function with async will always return Promise object. 
    const someOp = new Promise((resolve, reject)=>{
        setTimeout(() => {
            alert("Some big task is going on!!!");
            resolve("The task is completed")
        }, 5000);
    })
    const status =  await someOp;//The system will wait till the someOp is completed. 
    alert(status);
    return "REturning some value";
}

doAsyncOperation().then((result)=>{
    alert(result)
});
console.log("Is this going to execute first?")