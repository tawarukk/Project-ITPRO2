
////////////////////////////////////////////////////////////////imports////////////////////////////////
const express  = require("express")
require("dotenv/config")
const bp = require("body-parser")
const cors = require("cors")
const DB = require("./config/config-database.js")
const moment = require("moment")
////////////////////////////////export////////////////////////////////
const app = express();
app.use(express.json());
app.use(cors());
app.use(function (req, res, next) {
    res.setTimeout(120000, function () {
        res.send(408);

    });
    next();
})
app.listen(5000, () => console.log(`Listening on port${5000}...`));

app.get("/getUser",async (req, res) =>{
    const qry = "SELECT * from user";
    DB.query(qry, function (error,results,fields)  {
       return res.json(results);
    });
})

app.post("/createUser",async (req, res) =>{
    try {
    const qry = `INSERT INTO user (id,username,password,create_date) 
    values (NULL,'${req.body.username}','${req.body.password}','${moment().format("YYYY-MM-DD")}')
    `;

        DB.query(qry, function (error,results,fields)  {
    if (error) {
        return res.send({message: "failed", erroes: error});
    }
        return res.send("Pass");
    });
    } catch (error) {
        return res.send("failed");
    }
    
})

// start path
app.post("/getUserByID/:id", async (req, res) => {
    const user_id = req.params.id; 
    const qry = "SELECT * from user where id = ?"; 
    DB.query(qry, [user_id], function (error, results, fields) {
        if (error) {
            return res.status(500).json({ error: "failed" });
        }
        return res.json(results);
    });
});
// end path

// start query
app.post("/getUserByID",async (req, res) =>{
    const user_id =  req.query.id; 
    const qry = "SELECT * from user where id = ?"; 
    DB.query(qry, [user_id], function (error, results, fields) {
        if (error) {
            return res.status(500).json({ error: "failed" });
        }
        return res.json(results);
    });
})

app.post("/updateUser/:id",async (req, res) =>{
    const user_id =  req.params.id; 
    const {username,password} = req.body
    const qry = `update user SET username='${username}', password='${password}' where id = ?`; 
    DB.query(qry, [user_id], function (error, results, fields) {
        if (error) {
            // return res.send({message: "failed", erroes: error});
            return res.status(500).json({ error: "failed" });
        }
        return res.json(results);
    });
})

app.post("/deleteUserByID/:id", async (req, res) => {
    const user_id = req.params.id; 
    const qry = "DELETE FROM user WHERE id = ?"; 
    DB.query(qry, [user_id], function (error, results, fields) {
        if (error) {
            return res.status(500).json({ error: "failed" });
        }
        return res.json({ message: "pass" });
    });
});