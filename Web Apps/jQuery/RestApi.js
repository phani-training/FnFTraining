const apiUrl = "http://localhost:3000/employees"

function onEdit(id){
    //jQuery has 3 methods for making Ajax requests: $.get, $.post, $.ajax
    const tempUrl = apiUrl + "/" + id;
    console.log(tempUrl);
    $.get(tempUrl, function(data){
        $("#txtId").val(data.id);
        $("#txtName").val(data.empName);
        $("#txtAddress").val(data.empAddress);
        $("#txtSalary").val(data.empSalary);
    })
}
function getAllRecords(){
    $.get(apiUrl, function(data){
        $("table").find("tr:gt(0)").remove();
        for(let emp of data){
            const row = `<tr><td>${emp.id}</td><td>${emp.empName}</td><td>${emp.empAddress}</td><td>${emp.empSalary}</td>
            <td><a href="#" onclick="onEdit(${emp.id})">Edit</td></tr>`;
            $("table").append(row);
        }
    })
}

function deleteEmployee(id){
    const tempUrl = apiUrl + "/" + id;
    $.ajax({
        "method" : "DELETE",
        "url" : tempUrl,
        "success" : function(){
            alert("Employee deleted successfully")
            getAllRecords();
        }
    })
}
function updateEmployee(id, emp){
    const tempUrl = apiUrl + "/" + id;
  $.ajax({
    "method": "PUT",
    "url": tempUrl,
    "data" : emp,
    "success": function(response){
        alert("Employee is updated successfully")
        getAllRecords();
    }
  })
}

function addNewEmployee(emp){
    $.post(apiUrl, emp, function(res){
        alert("Employee added successfully to the database")
    });    
}