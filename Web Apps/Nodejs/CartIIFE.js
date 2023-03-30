module.exports = (function(){
    let cart = [];

    function addItem(item) {
        cart.push(item)
    }
    function getAll(){
        return cart;
    }

    function findItem(id){
        return cart.find((i)=>i.id == id);
    }
    return {
     addItem, getAll, findItem
    }
})(); 


//IIFE stands for Immediately Invoked Function expressions where the created Function will be invoked immediately after creating it to give the object to the caller. 