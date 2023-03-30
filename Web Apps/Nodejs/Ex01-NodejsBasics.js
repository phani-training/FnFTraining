console.log("Sample Test or Hello world from Nodejs");

const addFunc = (v1,v2) => v2 + v1;
const subFunc = (v1,v2) => v1 - v2;
const mulFunc = (v1,v2) => v2 * v1;
const divFunc = (v1,v2) => v1 / v2;

console.log(addFunc(123, 23));
console.log(subFunc(123, 23));
console.log(mulFunc(123, 23));
console.log(divFunc(123, 23));

const data = [
    {"id": 123, "name": "Phaniraj", "address" : "Bangalore"},
    {"id": 124, "name": "Andrew", "address" : "Bangalore"},
    {"id": 125, "name": "Bnil Philips", "address" : "Mysore"},
    {"id": 126, "name": "Cassendra", "address" : "Hubli"},
    {"id": 127, "name": "David", "address" : "Dharwad"}
]
for(const emp of data)
  console.log(emp.name);
console.table(data);    