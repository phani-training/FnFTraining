let data =[];

function addItem(item){
    data.push(item)
}

const getAll = () => data;

const removeItem =(item) =>{
    let index = data.indexOf(item);
    if(index == -1){
        alert("Item not found to remove");
    }else{
        data.splice(index, 1);
    }
}

