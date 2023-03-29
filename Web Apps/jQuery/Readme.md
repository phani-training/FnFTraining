## JSON server usage
1. Download the JSON Server package from NPM
```
npm install -g json-server
```
2. Create a new Folder called json-restapi in your prefered location. 
3. Create a file called db.json with some sample data, data is shared in the git link. 
4. Run the Terminal from the folder location, and execute the below command:
```
json-server --watch db.json
```
5. Once the REST API server is ready, U can access the data from any browser using http://localhost:3000/employees. 
6. In this case, employees is the name of the Collection in the db.json file. 
