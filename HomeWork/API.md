# Express.js API Summary

## Imports

```javascript
const express  = require("express")
require("dotenv/config")
const bp = require("body-parser")
const cors = require("cors")
const DB = require("./config/config-database.js")
const moment = require("moment")
```

เริ่มต้นด้วยการ import และใช้งาน modules หลายๆ ตัว เช่น express, dotenv, body-parser, cors, config-database, และ moment ซึ่งเป็นการโหลดโมดูลที่จำเป็นสำหรับการสร้างและใช้งาน API ด้วย Express.js

## Export 

```javascript
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
```

ส่วนนี้เป็นการสร้าง Express app และกำหนดการใช้ middleware เช่น express.json(), cors() และการจัดการ timeout สำหรับ response ที่ใช้เวลานาน และสุดท้ายคือการเริ่มต้น server ที่ port 5000

## User Routes

จากนั้นเริ่มทำการสร้าง API routes สำหรับการทำงานกับ user data:

### Get Users

```javascript
app.get("/getUser", async (req, res) => {
    const qry = "SELECT * from user";
    DB.query(qry, function (error, results, fields) {
        return res.json(results);
    });
})
```

การเรียก endpoint /getUser จะดึงข้อมูลของ users ทั้งหมดจาก database

### Create User

```javascript
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
```
// โค้ดสำหรับสร้าง user ใหม่และบันทึกลง database

API endpoint /createUser ใช้สำหรับการสร้าง user ใหม่และบันทึกข้อมูลลงใน database

### Get User by ID

```javascript
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
```
// โค้ดสำหรับการดึงข้อมูล user จาก ID ที่ระบุ

API endpoint /getUserByID/:id ใช้สำหรับการดึงข้อมูลของ user โดยระบุ ID ที่ต้องการ

### Update User

```javascript
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
```
// โค้ดสำหรับการอัปเดตข้อมูลของ user จาก ID ที่ระบุ

API endpoint /updateUser/:id ใช้สำหรับการอัปเดตข้อมูลของ user โดยระบุ ID ที่ต้องการ

### Delete User by ID

```javascript
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
```
// โค้ดสำหรับการลบข้อมูล user จาก ID ที่ระบุ

API endpoint /deleteUserByID/:id ใช้สำหรับการลบข้อมูล user โดยระบุ ID ที่ต้องการลบออกจาก database

