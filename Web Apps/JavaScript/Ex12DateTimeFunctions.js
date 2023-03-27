const months = [
    "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" , "Aug", "Sep", "Oct", "Nov", "Dec"
];
const currentDate = new Date();
const dateFormat = `${currentDate.getDate()}/${currentDate.getMonth() + 1}/${currentDate.getFullYear()}`;
console.log(dateFormat);
console.log(currentDate);
console.log(currentDate.getMonth()+ 1)//0-11
console.log(currentDate.getFullYear())//Year of the date
console.log(currentDate.getDate())//1-31
console.log(currentDate.getDay() + 1)//0-6
console.log(`The Current time is ${currentDate.getHours()}:${currentDate.getMinutes()}`)

//How to display month as String instead of a Number?

function displayDate(date){
    const div = document.createElement("div");
    const year = date.getFullYear();
    const month = months[date.getMonth()];
    const dt = date.getDate();
    div.innerHTML = `${dt} - ${month} - ${year}`;
    document.body.appendChild(div);
}


function displayTime(time){
    const hr = time.getHours();
    const min = time.getMinutes();
    const sec = time.getSeconds();
    const div = document.getElementById("divTime");
    div.innerHTML = `<b>${hr}: ${min} : ${sec}</b>`;
}


function createDate(){
    year = parseInt(prompt("Enter the Year of the date"));
    month = parseInt(prompt("Enter the month of the date as 0 to 11"));
    dt = parseInt(prompt("Enter the date of the month"));
    return new Date(year, month, dt);
}

const date = createDate();
displayDate(date);