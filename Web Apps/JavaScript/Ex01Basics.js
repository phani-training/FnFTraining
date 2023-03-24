//3 APIs for interacting with User interface
function UIRelatedFunc() {
    const name = prompt("Enter the Name");
    alert("The Name entered is " + name);
    const status = confirm("Are U sure?");
    if(status)
        console.log("True");
    else
       console.log("False");
}

//UIRelatedFunc();

//3 ways to declare variables in JS
function VariablesDeclaration(){
    const data = "Testing code";//Once created, cannot be modified. 
    var test ="Variable creation in JS(Old Style)";
    let example = "New way of variable creation which is more scope based";
    alert(data);
    alert(test);
    alert(example);
}

//VariablesDeclaration();

///////////////////Difference b/w var and let////////////////////////
let test = 123;
console.warn(window.test)//undefined for let but accessible for var. 
function testFunc(){
    let test = 234;
    console.log("The Value of test: " + test);
    {
        let test = 345;//scoped to this block only whereas var will allow U to access even after the scope is closed. 
    }
    console.log("The Value of test: " + test);
}
console.log("The Value of test: " + test);
testFunc();