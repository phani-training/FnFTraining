//New features of JS..
//////////////Default Parameters in JS//////////////////////////
function sampleFunc(message = "Good Morning"){
    console.log(message);
}

sampleFunc();
sampleFunc("Good Afternoon");

function createDiv(height ='350px', width ='400px', display ='inline-block', border ='2px solid blue'){
    const div = document.createElement('div');
    div.style.height = height;
    div.style.width = width;
    div.style.display = display;
    div.style.border = border;

    const area = document.querySelector("#divArea");
    area.appendChild(div);
}
//////////////////Spread Operator/////////////////////////////
function addNumbers(... values){
    let result = 0;
    for(let val of values)
        result += val;
    return result;
}

console.log(addNumbers(123, 23))
console.log(addNumbers(123, 23, 45, 67))
console.log(addNumbers(123, 23, 77, 8,  9, 10))
console.log(addNumbers(123))
console.log(addNumbers(123 , 23 , 34, 55, 66));

const data = [1,2,3,4];
const newData = [0, ...data];
console.log(newData);

const south = ['Kar', 'AP', 'TN', 'Ker', 'TS']
const north =['UP', 'Bihar', "UK", "JK", "HP", "HY", "DEL"];

const IndianStates = [...south, ...north];
console.log(IndianStates);
console.log(...south);


class MathClass{
    static addFunc = (v1, v2) => v1 + v2;

    callStaticFunc = () => this.constructor.addFunc(123,23);//call a static function from a non static function of the class. 
}

console.log(MathClass.addFunc(123, 23));

const cls = new MathClass();
cls.callStaticFunc();
//Call the static method from the object instance.
//Call the non static method from the static function. 







