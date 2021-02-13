using System;

namespace Sql
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Select : 
            group by : 
            where : 
            order by : 
            asc :
            desc : 
            join :
            inner join : sadece iki tabloları da eşleşenleri getirir. Eşleşmeyen data varsa onu getirmez.
            left join : sol tarafta olan sağ tarafta olmayanları da getirir.
            riht join : sağda olup solda olmayanları da getirir.

            **  * : Kolonların tamamı anlamına gelir.
            örn1: 
            Select * from Customers 
            örn2:
            Select ContactName Adi, CompanyName Sirket Adi, City Sehir from Customers
               -- örn2'de ki kolon isimlerinden sonra verilen isimler Alias'tır. 

            örn3:
            Select * from Customers where City ='London'
               -- Customers tablosunda, City'si 'London' olanları getirir.
               -- where: koşul.

            ** Sql Case Insensetive'dir. Yani büyük-küçük harf duyarlı değildir.

            örn4:
            select * from Products where categoryId=1 or categoryId=3
               -- or: Verilen değerlerin hepsini verir. categoryId'si hem 1 hem de 3 olanları getirir.
            
            örn5:
            select * from Products where categoryId=1 and UnitPrice>=10
               -- and : Verilen şartların tamamı tutulur.
               -- örn5'te categoryId'si 1 ve UnitPrice'ı 10'dan büyük olanlar gelir.

            örn6:
            select* from Products order by ProductName
               -- order by : sıralama. 
               -- Products'ta ProductName'e göre sıralar.

            örn7: 
            select* from Products order by CategoryID, ProductName
               -- Bu örneğimizde öncelikle CategoryID'yi sıralar. Ardırndan ProductName'leri de CategoryID'ye göre sıralar.

            örn8:
            select * from Products order by UnitPrice asc
               -- asc: ascending: artan sıralama(düşükten yükseğe)
               -- desc: descending: azalan sıralama(yüksekten düşüğe)

            örn9:
            select* from Products where categoryID=5 order by UnitPrice desc
               -- Products table^'ında categoryID'si 5 olanları azalan sıralamada sıralar.

            örn10:
            select count(*) from Products
               -- count : say.
               -- Bu örnekte, Products'ta kaç adet ürün olduğunu sayar ve gösterir.

            örn11:
            select count(*) Adet from Products where categoryID=1
               -- categoryID'si 1 olanları sayar ve Alias olarak "Adet" verir.
            
            örn12:
            categoryID'leri listeleyelim: 

            select categoryID from Products group by CategoryID
               -- buradaki "categoryID" Alias'tır. 

            örn13: 
            Hangi kategoriden kaç adet var onları listeleyelim:
            
            select categoryID, count(*) Adet from Products group by CategoryID
               -- "categoryID" ve "Adet" Alias'lardır. 
            
            örn14:
            Ürün sayısı 10'dan az olan kategorileri listeleyelim:

            select categoryID, count(*) Adet from Products group by CategoryID having count(*)<10
               -- having : kümülatif sorgular için kullanılır.
            
            örn15:
            Ürün fiyatı 20'den büyük olan ve 10 adetten az olan ürünleri listeleyelim:

            select categoryID, count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10 

               -- önce her zaman "where" çalışır.

            örn16:
            Products ve Categories tablolarında, CategoryID'leri aynı olanları getirelim:

            select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID
               -- inner join : " *** inner join *** on *** " şeklinde kullanılır.

            örn17: 
            Products ve Categories tablolarının, ProductID, ProductName, CategoryName ve UnitPrice'ları getirerek, CategoryID'leri aynı olanları getiren sorguyu yazalım:

            select Products.ProductID, Products.ProductName, Categories.CategoryID, Categories.CategoryName 
            from Products inner join Categories on Products.CategoryID = Categories.CategoryID

            örn18:
            select * from Customers c inner join Orders o 
            on c.CustomerID = o.CustomerID // çıktı:830

            select * from Customers c left join Orders o 
            on c.CustomerID = o.CustomerID // çıktı:832

            örn19:
            Customers ve Orders tablolarında data olmayan "null" olanları getirelim:

            select * from Customers c left join Orders o 
            on c.CustomerID = o.CustomerID where o.CustomerID is null

            örn20:
            Birden fazla tabloyu birleştirmek için:

            select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID
            inner join Orders o on o.OrderID=od.OrderID

            */

            /* 
             
            DTO : Data Transformation Object 

            select ContactName, CompanyName, City from Customers
select * from Products

select * from Products where categoryId=1 or categoryId=3

select * from Products where categoryId=1 and UnitPrice>=10

select* from Products order by ProductName

select* from Products order by CategoryID, ProductName

select * from Products order by UnitPrice asc
select * from Products order by UnitPrice desc

select* from Products where categoryID=5 order by UnitPrice desc

select count(*) from Products

select count(*) Adet from Products where categoryID=1

select categoryID from Products group by CategoryID

select categoryID, count(*) Adet from Products group by CategoryID

select categoryID, count(*) Adet from Products group by CategoryID having count(*)<10

select categoryID, count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10

select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID

select Products.ProductID, Products.ProductName, Categories.CategoryID, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID

select* from Products p inner join [Order Details] od
on p.ProductID = od.ProductID

select* from Products p left join [Order Details] od
on p.ProductID = od.ProductID

select * from Customers c inner join Orders o 
on c.CustomerID = o.CustomerID

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID
inner join Orders o on o.OrderID=od.OrderID

             */
        }
    }
}
