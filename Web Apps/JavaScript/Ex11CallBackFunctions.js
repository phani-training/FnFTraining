//To develop a function that will perform an operation based on the data and the requirement passed as arg

function invokeMathOperation(v1, v2, operationType) {
  switch (operationType) {
    case "+":
        return v1 + v2;
    case "-":
        return v1 - v2;
    default:
        return 0;
  }   
}

function invokeFunc(v1, v2, func){
    const result = func(v1, v2);
    alert(result)
}


// alert(invokeMathOperation(13,12, "23"))
invokeFunc(13,12, (v1, v2)=>{
    return v1 * v2;
});