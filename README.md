![Loyiha videosi](Assets/NorthWindSurfer.gif)
# NorthWindSurfer Console Application

**NorthWindSurfer** — bu konsol ilovasi bo‘lib, **Northwind** ma’lumotlar bazasidagi mahsulotlar, kategoriyalar, buyurtmalar va buyurtma tafsilotlarini boshqarish imkonini beradi. Ilova **C#**, **Dapper** va **SQL Server** (LocalDB) texnologiyalaridan foydalangan holda ishlab chiqilgan.

---

## 📌 Talablar

- .NET 6 yoki undan yuqori
- SQL Server LocalDB yoki boshqa SQL Server instansiyasi
- Dapper NuGet paketi

---

## 🛠 O‘rnatish va ishga tushirish

1. **Kod nusxasini yuklab oling**:

   ```bash
   git clone <repository-url>

NuGet paketlarini o‘rnating:

dotnet add package Dapper

Connection string ni o‘zingizning SQL Server konfiguratsiyangizga moslashtiring:

string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=master;Integrated Security=True;TrustServerCertificate=True;";

Ilovani ishga tushiring:

dotnet run
🖥 Ilova funksiyalari
1️⃣ Main Menu

Konsol oynasida foydalanuvchi quyidagi bo‘limlardan birini tanlashi mumkin:

Product — mahsulotlarni boshqarish

Categories — kategoriyalarni ko‘rish

Order — buyurtmalarni boshqarish (hozircha faqat bo‘lim ko‘rsatilgan)

OrderDetails — buyurtma tafsilotlarini boshqarish (hozircha faqat bo‘lim ko‘rsatilgan)

2️⃣ Product bo‘limi

Mahsulotlar bo‘limida quyidagi amallar mavjud:

Mahsulot qo‘shish — yangi mahsulotni kiritish

Mahsulotlarni ko‘rish — barcha mahsulotlar ro‘yxatini chiqarish

Mahsulotni o‘zgartirish — mavjud mahsulot ma’lumotlarini yangilash

Mahsulotni o‘chirish — mahsulotni ma’lumotlar bazasidan o‘chirish

Ma’lumotlar strukturası (ProductsService.Product):

Maydon	Tavsif
ProductID	Mahsulot ID
ProductName	Mahsulot nomi
SupplierID	Ta’minotchi ID
CategoryID	Kategoriya ID
3️⃣ Categories bo‘limi

Kategoriyalar bo‘limida barcha kategoriyalar ro‘yxati chiqariladi.

Ma’lumotlar strukturası (CategoriesService.Category):

Maydon	Tavsif
CategoryID	Kategoriya ID
CategoryName	Kategoriya nomi
Description	Kategoriya tavsifi
4️⃣ Orders va OrderDetails bo‘limlari

Ilovada buyurtmalar va buyurtma tafsilotlarini boshqarish uchun quyidagi ma’lumotlar mavjud:

OrdersService.Order:

Maydon	Tavsif
OrderID	Buyurtma ID
CustomerID	Mijoz ID
EmployeeID	Xodim ID

OrderDetailsService.OrderDetail:

Maydon	Tavsif
OrderID	Buyurtma ID
ProductID	Mahsulot ID
UnitPrice	Narx
🔧 Texnologiyalar va paketlar

C# 10 / .NET 6

Dapper — ma’lumotlar bazasi bilan ishlash uchun

SQL Server (LocalDB) — ma’lumotlar bazasi

Console UI — foydalanuvchi interfeysi uchun rangli konsol oynasi

⚡ Foydalanish bo‘yicha ko‘rsatmalar

Konsol oynasida raqamli menyu orqali bo‘limni tanlang.

Kerakli amalni tanlang (masalan, mahsulot qo‘shish, ko‘rish, o‘zgartirish yoki o‘chirish).

So‘rovga mos ma’lumotlarni kiriting.

Har bir amal yakunida “Davom etasizmi? (yes/no)” degan so‘rov paydo bo‘ladi.

📂 Kodingizdagi xizmatlar (Services)

ProductsService — mahsulotlar bilan ishlash

CategoriesService — kategoriyalar bilan ishlash

OrdersService — buyurtmalar bilan ishlash

OrderDetailsService — buyurtma tafsilotlari bilan ishlash


Muallif: Isomiddinov Tohir
Loyiha nomi: NorthWindSurfer
