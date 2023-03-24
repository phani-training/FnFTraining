//JS is a dynamic language that determines the data type at runtime. 
//We use const, let and var to declare the members within the program.
//Internally JS identifies 5 Data types: number, string, object, undefined, boolean. 
function dataTypesDemo() {
    let data;
    console.log(typeof (data));
    data = 123;
    console.log(typeof (data));
    data = "Some Content as string";
    console.log(typeof (data));
    data = true;
    console.log(typeof (data));
    data = { "Test": 123 }
    console.log(typeof (data));
}

dataTypesDemo();