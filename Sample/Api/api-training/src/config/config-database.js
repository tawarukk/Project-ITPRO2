const mysql = require('mysql');
const DB = mysql.createPool({
    host: process.env.DB_Host,
    user: process.env.DB_USER,
    password: process.env.DB_PASS,
    database: process.env.DBNAME,
    //port mssql: 1433
    port: process.env.DB_PORT,

})

module.exports = DB;