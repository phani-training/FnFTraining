const shoppingApp = require('./CartIIFE');
console.log(shoppingApp);

shoppingApp.addItem({"id" : 11, "itemName" : "Apples", "price" : 200});
shoppingApp.addItem({"id" : 11, "itemName" : "Apples", "price" : 200});
shoppingApp.addItem({"id" : 11, "itemName" : "Apples", "price" : 200});
shoppingApp.addItem({"id" : 11, "itemName" : "Apples", "price" : 200});

const items = shoppingApp.getAll();

const foundItem = shoppingApp.findItem(11);
console.log(foundItem)
console.table(items);