//3 ways of creating classes and objects in JavaScript
//Singleton objects
const emp = {};
emp.id = 123;
emp.empName ="Phaniraj";
emp.empAddress ="Bangalore";
emp.empSalary = 67000;
console.log(emp);

let temp = emp;
temp.empSalary =56000;
console.log(emp);
console.log(temp);
const book = {
    bookId: 123, bookTitle : "2 States", Author : "Chetan Bhagat"
}
console.log(book);

for (const attr in book) {
  let msg = `${attr} is the attributename and its value is ${book[attr]}`;
  console.log(msg);
}
//////////////////////Function based Classes/////////////////////////////
const employee = function(id, name, address){
    this.empId = id;
    this.empName = name;
    this.empAddress = address;   
}

const empObj = new employee(123, "Phaniraj", "Bangalore");
console.log(empObj);

const tempObj = new employee(124, "Suresh", "Mysore");
console.log(tempObj);

//////////////////////Using ES6 Syntax of class//////////////////
class Customer{
    constructor(id, name, address, billAmount){
        this.cstId = id;
        this.cstName = name;
        this.cstAddress = address;
        this.billAmount = billAmount
    }

    display(){
        return `${this.cstName} spent an amount of Rs.${this.billAmount} and the products were shipped to ${this.cstAddress}. For further corresponse, the Customer should use the id ${this.cstId}`
    }
}

const cst = new Customer(123, "Phaniraj", "Bangalore", 1000);
console.log(cst.display());