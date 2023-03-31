const app = require("express")();
const parser = require("body-parser");
const server = require("mssql/msnodesqlv8")

const config = {
    server : '.\\SQLEXPRESS',
    database : 'FnFTraining',
    driver : 'msnodesqlv8',
    options :{
        trustedConnection : true,
        TrustServerCertificate : true
    }
}

const pool = new server.ConnectionPool(config, (err)=>{
    console.log(err)
});

app.get("/AllEmployees", (req, res) =>{
  pool.connect().then(()=>{
    pool.request().query("SELECT * FROM EMPTABLE", (err, result)=>{
        if(err)
          console.error(err);
          else{
            res.send(result.recordset);
          }
    })
  }).catch((err)=>{
    if(err)console.error(err)
  })  
})

app.listen(1234, () => console.log("Server is up and running at 1234"));