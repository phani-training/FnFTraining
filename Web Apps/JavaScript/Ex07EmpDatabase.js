///////////////////Entity class////////////////////
class Employee{
    constructor(id, name, email, phone) {
        this.id = id;
        this.name = name;
        this.email = email;
        this.phone = phone
    }
}
///////////////////Repo Class//////////////////////
class EmpRepo{
    data = [];//private data....

    addEmployee = (emp) => this.data.push(emp);

    getAllEmployees = () => this.data;

    //findEmployee = (id) => this.data.find((e)=>e.id === id);
    findEmployee = (id)=>{
        for(let e of this.data){
            if(e.id === id)
               return e;
        }
    }
    updateEmployee = (emp) =>{
        const index = this.data.findIndex((e)=>e.id == emp.id);
        if(index === -1)
          throw "Employee not found";
        this.data.splice(index, 1, emp);  
    }
}
///////////////////Helper Functions////////////////
function $get(id){
    return document.getElementById(id)
}