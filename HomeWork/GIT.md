# เรียนรู้การใช้งาน Git & GitHub | สำหรับผู้เริ่มต้น

Version Control
- Version Control เป็นระบบที่ช่วยบันทึกการเปลี่ยนแปลงของไฟล์และประวัติการแก้ไข
- ช่วยให้ทำงานร่วมกันได้อย่างมีประสิทธิภาพและลดความขัดแย้ง

Git & GitHub
- Git เป็นระบบ Version Control ที่ใช้กันมากที่สุดและ GitHub เป็นเว็บไซต์ที่ให้บริการเกี่ยวกับ Git
- GitHub เป็นพื้นที่เก็บโค้ดและทำงานร่วมกัน

Git Basics
- `git init`: สร้าง Repository ใหม่
- `git add <file>`: เพิ่มไฟล์เข้า Staging Area
- `git commit -m "message"`: Commit การเปลี่ยนแปลง
- `git status`: แสดงสถานะปัจจุบันของไฟล์
- `git log`: แสดงประวัติการ Commit

Branching
- `git branch <branch_name>`: สร้าง Branch ใหม่
- `git checkout <branch_name>`: เปลี่ยน Branch ที่ใช้งาน
- `git merge <branch_name>`: รวม Branch กับ Branch ปัจจุบัน
- `git branch -d <branch_name>`: ลบ Branch

Remote Repositories
- `git remote add origin <remote_URL>`: เชื่อม Repository ในเครื่องไปยัง Remote Repository
- `git push origin <branch_name>`: อัปโหลดการ Commit ไปยัง Remote Repository
- `git pull origin <branch_name>`: ดึงข้อมูลจาก Remote Repository มายังเครื่อง

อื่น ๆ
- README: ไฟล์ที่อธิบายรายละเอียดของโปรเจ็กต์
- `git clone <remote_URL>`: คัดลอก Repository จาก Remote Repository มายังเครื่อง
