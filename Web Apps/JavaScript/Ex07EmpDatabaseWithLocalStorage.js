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

    getData =() => {
        if(localStorage.getItem("empList") !=undefined)
            this.data = JSON.parse(localStorage.getItem("empList"));
    }
    setData = () => localStorage.setItem("empList", JSON.stringify(this.data));
    
    addEmployee = (emp) => {
        this.getData();
        this.data.push(emp);
        this.setData();
    }
    getAllEmployees = () => {
        this.getData();
        return this.data;
    }

    //findEmployee = (id) => this.data.find((e)=>e.id === id);
    findEmployee = (id)=>{
        this.getData();
        for(let e of this.data){
            if(e.id === id)
               return e;
        }
    }
    updateEmployee = (emp) =>{
        this.getData();
        const index = this.data.findIndex(function(e){
            return e.id == emp.id;
        })    
        if(index === -1)
          throw "Employee not found";
        this.data.splice(index, 1, emp);
        this.setData();  
    }
}
///////////////////Helper Functions////////////////
function $get(id){
    return document.getElementById(id)
}