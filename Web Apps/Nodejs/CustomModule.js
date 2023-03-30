module.exports.simpleFunc = function(){
    console.log("Simple Function implemented here. ");
}

module.exports.mathTable = function(num = 5){
    console.log(`Multiplication Table for ${num}`);
    for(let i = 1; i <= 10; i++){
        console.log(`${num} X ${i} = ${num * i}`);
    }
    console.log("--------------------------------");
}

module.exports.bookComponent = class{
    constructor(id, title, price) {
    this.bookId =id;
    this.bookTitle = title;
    this.price = price
    }
};

module.exports.empClass = function(id, name, address){
    this.id = id; this.name = name; this.address = address;
}

module.exports.customer = class{
    constructor(id , name, billAmount){
        this.id = id
        this.name = name
        this.amount = billAmount
    }

    display = () => `${this.name} has billed an amount of Rs. ${this.amount} and has an Id ${this.id}`
}