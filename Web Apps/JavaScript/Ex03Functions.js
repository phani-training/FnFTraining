//3 ways of creating functions in JS. 
//Named function
function sayGreeting(msg){
    console.log(msg)
}

sayGreeting("Good Morning!");
//Anonymous Function...
const addFunc = function(v1, v2){
    const intVal1 = parseInt(v1);
    const intVal2 = parseInt(v2);
    return (intVal1 + intVal2)
}

const res = addFunc(123, 234);
console.log(res);

//Improvised version of Anonymous method called as Arrow Function/Lambda Expression. Most of the time, Arrow functions are single line statements. 
const subFunc = (v1, v2) => v1 -v2;

const divFunc = (v1, v2) =>{
    if(v2 ==0){
      alert("Division by Zero is not allowed");
      return 0;
    }
    else{
        return v1 / v2;
    }    
}
const divValue = divFunc(123, 0);
console.log(divValue);

//Rest parameter is created using ... operator. This is called as Rest parameter. U can have only one rest parameter for a function. It should be the last of the parameter list.  
function addNumbers(...args){
    let res = 0;
    for(const val of args){
        res += val;
    }
    return res;
}
const addedVal = addNumbers(123,23,23,45,3,5);
console.log(addedVal);