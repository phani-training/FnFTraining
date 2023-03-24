//Arrays in JS. 
let array = [];//blank array in JS creation
//Arrays in JS is dynamic. U can add elements to the array after it is created. 
array.push(123);//adds the element to the bottom of the array..
array.push(234);
array.push(345);
array.push(456);
array.push(678);
array.push(789);

//Other ways of adding items to the array:
array.unshift(111);//Add the element to the top of the Array...

//array = [array, 654, 543, 432];//Replaces the elements with new data. 

array.shift(111);//Remove the element from the array and returns.. 
///////Iterating thru for loop
for(let i =0; i < array.length; i++)
   console.log(array[i]);

///////////Iterating using for..of loop, similar to foreach of C#.
for (const value of array) {
    console.log(value);
} 
//////////////////Iterating using for..in where U can access it with index.
for(const index in array){
    //Interpolation in Js
    let msg = `The index: ${index} and the value: ${array[index]}`
    console.log(msg);
}  

console.log("Display the array elements without iterating:");
console.log(array);
console.log("Removing an element from the Array");
array.splice(3, 1);//Splice is used to add, remove or replace the element in the array. 
console.log(array);

