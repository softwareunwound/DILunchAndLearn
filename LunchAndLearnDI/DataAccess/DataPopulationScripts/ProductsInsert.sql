USE [Northwind];
SET NOCOUNT ON;
SET XACT_ABORT ON;
GO

SET IDENTITY_INSERT [dbo].[Products] ON;

BEGIN TRANSACTION;
INSERT INTO [dbo].[Products]([ProductID], [ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [ReorderLevel], [Discontinued])
SELECT 1, N'Chai', 1, 1, N'10 boxes x 20 bags', 18.0000, 39, 0, 10, 0 UNION ALL
SELECT 2, N'Chang', 1, 1, N'24 - 12 oz bottles', 19.0000, 17, 40, 25, 0 UNION ALL
SELECT 3, N'Aniseed Syrup', 1, 2, N'12 - 550 ml bottles', 10.0000, 13, 70, 25, 0 UNION ALL
SELECT 4, N'Chef Anton''s Cajun Seasoning', 2, 2, N'48 - 6 oz jars', 22.0000, 53, 0, 0, 0 UNION ALL
SELECT 5, N'Chef Anton''s Gumbo Mix', 2, 2, N'36 boxes', 21.3500, 0, 0, 0, 1 UNION ALL
SELECT 6, N'Grandma''s Boysenberry Spread', 3, 2, N'12 - 8 oz jars', 25.0000, 120, 0, 25, 0 UNION ALL
SELECT 7, N'Uncle Bob''s Organic Dried Pears', 3, 7, N'12 - 1 lb pkgs.', 30.0000, 15, 0, 10, 0 UNION ALL
SELECT 8, N'Northwoods Cranberry Sauce', 3, 2, N'12 - 12 oz jars', 40.0000, 6, 0, 0, 0 UNION ALL
SELECT 9, N'Mishi Kobe Niku', 4, 6, N'18 - 500 g pkgs.', 97.0000, 29, 0, 0, 1 UNION ALL
SELECT 10, N'Ikura', 4, 8, N'12 - 200 ml jars', 31.0000, 31, 0, 0, 0 UNION ALL
SELECT 11, N'Queso Cabrales', 5, 4, N'1 kg pkg.', 21.0000, 22, 30, 30, 0 UNION ALL
SELECT 12, N'Queso Manchego La Pastora', 5, 4, N'10 - 500 g pkgs.', 38.0000, 86, 0, 0, 0 UNION ALL
SELECT 13, N'Konbu', 6, 8, N'2 kg box', 6.0000, 24, 0, 5, 0 UNION ALL
SELECT 14, N'Tofu', 6, 7, N'40 - 100 g pkgs.', 23.2500, 35, 0, 0, 0 UNION ALL
SELECT 15, N'Genen Shouyu', 6, 2, N'24 - 250 ml bottles', 15.5000, 39, 0, 5, 0 UNION ALL
SELECT 16, N'Pavlova', 7, 3, N'32 - 500 g boxes', 17.4500, 29, 0, 10, 0 UNION ALL
SELECT 17, N'Alice Mutton', 7, 6, N'20 - 1 kg tins', 39.0000, 0, 0, 0, 1 UNION ALL
SELECT 18, N'Carnarvon Tigers', 7, 8, N'16 kg pkg.', 62.5000, 42, 0, 0, 0 UNION ALL
SELECT 19, N'Teatime Chocolate Biscuits', 8, 3, N'10 boxes x 12 pieces', 9.2000, 25, 0, 5, 0 UNION ALL
SELECT 20, N'Sir Rodney''s Marmalade', 8, 3, N'30 gift boxes', 81.0000, 40, 0, 0, 0 UNION ALL
SELECT 21, N'Sir Rodney''s Scones', 8, 3, N'24 pkgs. x 4 pieces', 10.0000, 3, 40, 5, 0 UNION ALL
SELECT 22, N'Gustaf''s Kn�ckebr�d', 9, 5, N'24 - 500 g pkgs.', 21.0000, 104, 0, 25, 0 UNION ALL
SELECT 23, N'Tunnbr�d', 9, 5, N'12 - 250 g pkgs.', 9.0000, 61, 0, 25, 0 UNION ALL
SELECT 24, N'Guaran� Fant�stica', 10, 1, N'12 - 355 ml cans', 4.5000, 20, 0, 0, 1 UNION ALL
SELECT 25, N'NuNuCa Nu�-Nougat-Creme', 11, 3, N'20 - 450 g glasses', 14.0000, 76, 0, 30, 0 UNION ALL
SELECT 26, N'Gumb�r Gummib�rchen', 11, 3, N'100 - 250 g bags', 31.2300, 15, 0, 0, 0 UNION ALL
SELECT 27, N'Schoggi Schokolade', 11, 3, N'100 - 100 g pieces', 43.9000, 49, 0, 30, 0 UNION ALL
SELECT 28, N'R�ssle Sauerkraut', 12, 7, N'25 - 825 g cans', 45.6000, 26, 0, 0, 1 UNION ALL
SELECT 29, N'Th�ringer Rostbratwurst', 12, 6, N'50 bags x 30 sausgs.', 123.7900, 0, 0, 0, 1 UNION ALL
SELECT 30, N'Nord-Ost Matjeshering', 13, 8, N'10 - 200 g glasses', 25.8900, 10, 0, 15, 0 UNION ALL
SELECT 31, N'Gorgonzola Telino', 14, 4, N'12 - 100 g pkgs', 12.5000, 0, 70, 20, 0 UNION ALL
SELECT 32, N'Mascarpone Fabioli', 14, 4, N'24 - 200 g pkgs.', 32.0000, 9, 40, 25, 0 UNION ALL
SELECT 33, N'Geitost', 15, 4, N'500 g', 2.5000, 112, 0, 20, 0 UNION ALL
SELECT 34, N'Sasquatch Ale', 16, 1, N'24 - 12 oz bottles', 14.0000, 111, 0, 15, 0 UNION ALL
SELECT 35, N'Steeleye Stout', 16, 1, N'24 - 12 oz bottles', 18.0000, 20, 0, 15, 0 UNION ALL
SELECT 36, N'Inlagd Sill', 17, 8, N'24 - 250 g  jars', 19.0000, 112, 0, 20, 0 UNION ALL
SELECT 37, N'Gravad lax', 17, 8, N'12 - 500 g pkgs.', 26.0000, 11, 50, 25, 0 UNION ALL
SELECT 38, N'C�te de Blaye', 18, 1, N'12 - 75 cl bottles', 263.5000, 17, 0, 15, 0 UNION ALL
SELECT 39, N'Chartreuse verte', 18, 1, N'750 cc per bottle', 18.0000, 69, 0, 5, 0 UNION ALL
SELECT 40, N'Boston Crab Meat', 19, 8, N'24 - 4 oz tins', 18.4000, 123, 0, 30, 0 UNION ALL
SELECT 41, N'Jack''s New England Clam Chowder', 19, 8, N'12 - 12 oz cans', 9.6500, 85, 0, 10, 0 UNION ALL
SELECT 42, N'Singaporean Hokkien Fried Mee', 20, 5, N'32 - 1 kg pkgs.', 14.0000, 26, 0, 0, 1 UNION ALL
SELECT 43, N'Ipoh Coffee', 20, 1, N'16 - 500 g tins', 46.0000, 17, 10, 25, 0 UNION ALL
SELECT 44, N'Gula Malacca', 20, 2, N'20 - 2 kg bags', 19.4500, 27, 0, 15, 0 UNION ALL
SELECT 45, N'Rogede sild', 21, 8, N'1k pkg.', 9.5000, 5, 70, 15, 0 UNION ALL
SELECT 46, N'Spegesild', 21, 8, N'4 - 450 g glasses', 12.0000, 95, 0, 0, 0 UNION ALL
SELECT 47, N'Zaanse koeken', 22, 3, N'10 - 4 oz boxes', 9.5000, 36, 0, 0, 0 UNION ALL
SELECT 48, N'Chocolade', 22, 3, N'10 pkgs.', 12.7500, 15, 70, 25, 0 UNION ALL
SELECT 49, N'Maxilaku', 23, 3, N'24 - 50 g pkgs.', 20.0000, 10, 60, 15, 0 UNION ALL
SELECT 50, N'Valkoinen suklaa', 23, 3, N'12 - 100 g bars', 16.2500, 65, 0, 30, 0
COMMIT;
RAISERROR (N'[dbo].[Products]: Insert Batch: 1.....Done!', 10, 1) WITH NOWAIT;
GO

BEGIN TRANSACTION;
INSERT INTO [dbo].[Products]([ProductID], [ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [ReorderLevel], [Discontinued])
SELECT 51, N'Manjimup Dried Apples', 24, 7, N'50 - 300 g pkgs.', 53.0000, 20, 0, 10, 0 UNION ALL
SELECT 52, N'Filo Mix', 24, 5, N'16 - 2 kg boxes', 7.0000, 38, 0, 25, 0 UNION ALL
SELECT 53, N'Perth Pasties', 24, 6, N'48 pieces', 32.8000, 0, 0, 0, 1 UNION ALL
SELECT 54, N'Tourti�re', 25, 6, N'16 pies', 7.4500, 21, 0, 10, 0 UNION ALL
SELECT 55, N'P�t� chinois', 25, 6, N'24 boxes x 2 pies', 24.0000, 115, 0, 20, 0 UNION ALL
SELECT 56, N'Gnocchi di nonna Alice', 26, 5, N'24 - 250 g pkgs.', 38.0000, 21, 10, 30, 0 UNION ALL
SELECT 57, N'Ravioli Angelo', 26, 5, N'24 - 250 g pkgs.', 19.5000, 36, 0, 20, 0 UNION ALL
SELECT 58, N'Escargots de Bourgogne', 27, 8, N'24 pieces', 13.2500, 62, 0, 20, 0 UNION ALL
SELECT 59, N'Raclette Courdavault', 28, 4, N'5 kg pkg.', 55.0000, 79, 0, 0, 0 UNION ALL
SELECT 60, N'Camembert Pierrot', 28, 4, N'15 - 300 g rounds', 34.0000, 19, 0, 0, 0 UNION ALL
SELECT 61, N'Sirop d''�rable', 29, 2, N'24 - 500 ml bottles', 28.5000, 113, 0, 25, 0 UNION ALL
SELECT 62, N'Tarte au sucre', 29, 3, N'48 pies', 49.3000, 17, 0, 0, 0 UNION ALL
SELECT 63, N'Vegie-spread', 7, 2, N'15 - 625 g jars', 43.9000, 24, 0, 5, 0 UNION ALL
SELECT 64, N'Wimmers gute Semmelkn�del', 12, 5, N'20 bags x 4 pieces', 33.2500, 22, 80, 30, 0 UNION ALL
SELECT 65, N'Louisiana Fiery Hot Pepper Sauce', 2, 2, N'32 - 8 oz bottles', 21.0500, 76, 0, 0, 0 UNION ALL
SELECT 66, N'Louisiana Hot Spiced Okra', 2, 2, N'24 - 8 oz jars', 17.0000, 4, 100, 20, 0 UNION ALL
SELECT 67, N'Laughing Lumberjack Lager', 16, 1, N'24 - 12 oz bottles', 14.0000, 52, 0, 10, 0 UNION ALL
SELECT 68, N'Scottish Longbreads', 8, 3, N'10 boxes x 8 pieces', 12.5000, 6, 10, 15, 0 UNION ALL
SELECT 69, N'Gudbrandsdalsost', 15, 4, N'10 kg pkg.', 36.0000, 26, 0, 15, 0 UNION ALL
SELECT 70, N'Outback Lager', 7, 1, N'24 - 355 ml bottles', 15.0000, 15, 10, 30, 0 UNION ALL
SELECT 71, N'Flotemysost', 15, 4, N'10 - 500 g pkgs.', 21.5000, 26, 0, 0, 0 UNION ALL
SELECT 72, N'Mozzarella di Giovanni', 14, 4, N'24 - 200 g pkgs.', 34.8000, 14, 0, 0, 0 UNION ALL
SELECT 73, N'R�d Kaviar', 17, 8, N'24 - 150 g jars', 15.0000, 101, 0, 5, 0 UNION ALL
SELECT 74, N'Longlife Tofu', 4, 7, N'5 kg pkg.', 10.0000, 4, 20, 5, 0 UNION ALL
SELECT 75, N'Rh�nbr�u Klosterbier', 12, 1, N'24 - 0.5 l bottles', 7.7500, 125, 0, 25, 0 UNION ALL
SELECT 76, N'Lakkalik��ri', 23, 1, N'500 ml', 18.0000, 57, 0, 20, 0 UNION ALL
SELECT 77, N'Original Frankfurter gr�ne So�e', 12, 2, N'12 boxes', 13.0000, 32, 0, 15, 0
COMMIT;
RAISERROR (N'[dbo].[Products]: Insert Batch: 2.....Done!', 10, 1) WITH NOWAIT;
GO

SET IDENTITY_INSERT [dbo].[Products] OFF;

