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