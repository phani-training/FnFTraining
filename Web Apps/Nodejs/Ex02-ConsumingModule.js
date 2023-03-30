const externalModule = require('./CustomModule');

const bookClass = externalModule.bookComponent;

console.log(externalModule);
externalModule.simpleFunc();
externalModule.mathTable();

const empObj = new externalModule.empClass(123, "Phaniraj", "Bangalore");

const cstObj = new externalModule.customer(111, "TestName", 5600);
console.log(cstObj.display()); 
console.log(JSON.stringify(empObj));
console.log(JSON.stringify(cstObj));

const book = new bookClass(11, "2 States", 500);
console.log(JSON.stringify(book));
// const data = [empObj, cstObj];
// console.table(data);