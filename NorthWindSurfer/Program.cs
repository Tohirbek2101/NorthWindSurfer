using Dapper;
using Microsoft.Data.SqlClient;
using NorthWindSurfer.Services;
using System.Data;

string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=master;Integrated Security=True;TrustServerCertificate=True;";

IDbConnection connection = new  SqlConnection(connectionString);
bool choice0 = false;
while (!choice0)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;

    Console.WriteLine("╔════════════════════════════════════╗");
    Console.WriteLine("║          MAIN  MENU               ║");
    Console.WriteLine("╠════════════════════════════════════╣");
    Console.WriteLine("║  1. Product                       ║");
    Console.WriteLine("║  2. Categories                    ║");
    Console.WriteLine("║  3. Order                         ║");
    Console.WriteLine("║  4. OrderDetails                  ║");
    Console.WriteLine("╚════════════════════════════════════╝");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\nTanlovingizni kiriting (1-4): ");

    Console.ResetColor();

    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║         PRODUCT BO‘LIMI              ║");
                Console.WriteLine("╠══════════════════════════════════════╣");
                Console.WriteLine("║  1. Mahsulot qo‘shish                ║");
                Console.WriteLine("║  2. Mahsulotlarni ko‘rish            ║");
                Console.WriteLine("║  3. Mahsulotni o‘zgartirish          ║");
                Console.WriteLine("║  4. Mahsulotni o‘chirish             ║");
                Console.WriteLine("╚══════════════════════════════════════╝");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nAmalni tanlang (1-4): ");

                Console.ResetColor();

                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine("╔════════════════════════════════════════════╗");
                            Console.WriteLine("║          YANGI MAHSULOT QO‘SHISH          ║");
                            Console.WriteLine("╚════════════════════════════════════════════╝\n");

                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Mahsulot ID sini kiriting: ");
                            Console.ResetColor();
                            int productId = Convert.ToInt32(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Mahsulot nomini kiriting: ");
                            Console.ResetColor();
                            string productname = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Ta'minotchi ID sini kiriting: ");
                            Console.ResetColor();
                            int suplierid = Convert.ToInt32(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Kategoriya ID sini kiriting: ");
                            Console.ResetColor();
                            int categoryid = Convert.ToInt32(Console.ReadLine());

                            string sql =
                                """
                                   INSERT INTO Products(ProductID, ProductName, SupplierID CategoryID)
                                   VALUES (productId,productname,suplierid,categoryid)
                                """;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n╔════════════════════════════════════════════╗");
                            Console.WriteLine("║  ✔ Mahsulot muvaffaqiyatli qo‘shildi!     ║");
                            Console.WriteLine("╚════════════════════════════════════════════╝");

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nDavom etasizmi? (yes/no): ");
                            Console.ResetColor();

                            string m = Console.ReadLine();

                            if (m == "yes")
                                choice0 = false;
                            else
                                choice0 = true;

                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                     MAHSULOTLAR RO‘YXATI                    ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝\n");

                            string sql =
                                """
                                   SELECT * FROM Products;
                                """;

                            var productNames = await connection.QueryAsync<ProductsService.Product>(sql);

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("┌────────┬──────────────────────┬────────────┬────────────┐");
                            Console.WriteLine("│   ID   │        Name          │ SupplierID │ CategoryID │");
                            Console.WriteLine("├────────┼──────────────────────┼────────────┼────────────┤");

                            Console.ResetColor();

                            foreach (var productName in productNames)
                            {
                                Console.WriteLine(
                                    $"│ {productName.ProductID,-6} │ {productName.ProductName,-20} │ {productName.SupplierID,-10} │ {productName.CategoryID,-10} │");
                            }

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("└────────┴──────────────────────┴────────────┴────────────┘");

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nDavom etasizmi? (yes/no): ");
                            Console.ResetColor();

                            string m = Console.ReadLine();

                            if (m == "yes")
                                choice0 = false;
                            else
                                choice0 = true;

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;

                            Console.WriteLine("╔══════════════════════════════════════════════╗");
                            Console.WriteLine("║          MAHSULOTNI O‘ZGARTIRISH            ║");
                            Console.WriteLine("╚══════════════════════════════════════════════╝\n");

                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Eski mahsulot ID sini kiriting: ");
                            Console.ResetColor();
                            int updateidOld = Convert.ToInt32(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Yangi ID raqamini kiriting: ");
                            Console.ResetColor();
                            int updateidNew = Convert.ToInt32(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Mahsulotning yangi nomini kiriting: ");
                            Console.ResetColor();
                            string updateNameNew = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Yangi SupplierID kiriting: ");
                            Console.ResetColor();
                            int supplierIdNew = Convert.ToInt32(Console.ReadLine());

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Yangi CategoryID kiriting: ");
                            Console.ResetColor();
                            int categoryIdNew = Convert.ToInt32(Console.ReadLine());

                            string sql =
                                """
                                   UPDATE Products
                                   SET ProductID=updateidNew,
                                   ProductName=updateNameNew,
                                   SupplierID=supplierIdNew,
                                   CategoryID=categoryIdNew
                                   WHERE ProductID=updateidOld;
                                """;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n╔══════════════════════════════════════════════╗");
                            Console.WriteLine("║     ✔ Mahsulot muvaffaqiyatli o‘zgartirildi ║");
                            Console.WriteLine("╚══════════════════════════════════════════════╝");

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nDavom etasizmi? (yes/no): ");
                            Console.ResetColor();

                            string m = Console.ReadLine();

                            if (m == "yes")
                                choice0 = false;
                            else
                                choice0 = true;

                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("╔══════════════════════════════════════════════╗");
                            Console.WriteLine("║            MAHSULOTNI O‘CHIRISH              ║");
                            Console.WriteLine("╚══════════════════════════════════════════════╝\n");

                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("O‘chirmoqchi bo‘lgan mahsulot ID sini kiriting: ");
                            Console.ResetColor();

                            int deletedId = Convert.ToInt32(Console.ReadLine());

                            string sql =
                                """
                                   DELETE FROM Products
                                   WHERE ProductID=deleteId;
                                """;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n╔══════════════════════════════════════════════╗");
                            Console.WriteLine("║   ✔ O‘chirish muvaffaqiyatli bajarildi      ║");
                            Console.WriteLine("╚══════════════════════════════════════════════╝");

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nDavom etasizmi? (yes/no): ");
                            Console.ResetColor();

                            string m = Console.ReadLine();

                            if (m == "yes")
                                choice0 = false;
                            else
                                choice0 = true;

                            break;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("\n╔══════════════════════════════════════════════╗");
                            Console.WriteLine("║   ❌  NOTO‘G‘RI AMAL KIRITDINGIZ!           ║");
                            Console.WriteLine("╚══════════════════════════════════════════════╝");

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nDavom etasizmi? (yes/no): ");
                            Console.ResetColor();

                            string m = Console.ReadLine();

                            if (m == "yes")
                                choice0 = false;
                            else
                                choice0 = true;

                            break;
                        }
                }
                break;
            }
        case 2:
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║         KATEGORIYALAR BO‘LIMI              ║");
                Console.WriteLine("╠══════════════════════════════════════╣");


                string sql =
                    """
                                   SELECT * FROM Categories;
                    """;

                var productNames = await connection.QueryAsync<CategoriesService.Category>(sql);
                //var categories=await connection..QueryAsync<CategoriesService.Category>(sql, c => c.Categories);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("┌────────┬──────────────────────┬────────────┐");
                Console.WriteLine("│   ID   │        Name          │ Description │");
                Console.WriteLine("├────────┼──────────────────────┼────────────┤");

                Console.ResetColor();

                foreach (var productName in productNames)
                {
                    Console.WriteLine(
                        $"│ {productName.CategoryID,-6} │ {productName.CategoryName,-20} │ {productName.Description,-10} │");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("└────────┴──────────────────────┴────────────┴────────────┘");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nDavom etasizmi? (yes/no): ");
                Console.ResetColor();

                string m = Console.ReadLine();

                if (m == "yes")
                    choice0 = false;
                else
                    choice0 = true;
                break;  
            }
        case 3:
            {
                break;
            }
        case 4:
            {
                break;
            }
        default:
            {
                Console.WriteLine("Notog'ri ma'lumot kiritdingiz! Iltimos tekshirib qaytadan kiriting...");
                break;
            }
             

    }
    /*string input = Console.ReadLine();
    string sql =
        $"""
        SELECT * FROM Products
        """;

    var productNames = await connection.QueryAsync<ProductsService.Product>(sql);
    //var productNames=await connection.QueryAsync<string>(sql);
    foreach(var productName in productNames)
    {
        Console.WriteLine($"ID: {productName.ProductID} Name: {productName.ProductName}");
    }*/
}