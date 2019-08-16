using SQLite.CodeFirst;
using System;
using System.Data.Entity;
using SmartInventorySystem.Model;

namespace SmartInventorySystem.DataAccess.Seed
{
    class DevelopDbInitializer : SqliteDropCreateDatabaseAlways<InventoryModel>
    {
        public DevelopDbInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder)
        {
        }

        protected override void Seed(InventoryModel context)
        {
            var aUser = new User { FirstName = "Irene", LastName = "A.", UserName = "irene", Password = "irene", Role = "Admin", Email = "irene.a@example.com", Phone = "0801" };

            context.Users.Add(aUser);

            var aSupplier1 = new Supplier { Name = "XYZ Drugs Limited", ContactPerson = "Mr Chacha Nedo", Address = "Ikeja, Lagos, Nigeria", Email = "chacha@yahoo.co.uk", Phone = "080333222" };
            var aSupplier2 = new Supplier { Name = "Makinga", ContactPerson = "Mr Toba", Address = "Iwaya Road, Yaba, Lagos", Email = "making@yahoo.com", Phone = "080000" };

            context.Suppliers.AddRange(new[] { aSupplier1, aSupplier2 });

            //`dispense_id` int(11) NOT NULL auto_increment,
            //`item_id` varchar(30) NOT NULL,
            //`group_id` varchar(11) NOT NULL,
            //`group_date` date NOT NULL,
            //`item_code` varchar(30) default NULL,
            //`item_name` varchar(100) NOT NULL,
            //`stock_level` int(11) NOT NULL,
            //`unit_price` float default NULL,
            //`dispense_quantity` int(11) NOT NULL,
            //`sub_amount` float default NULL,
            //`vat` float default NULL,
            //`total_amount` float default NULL,
            //`stock_balance` int(11) default NULL,
            //`date_dispensed` datetime default NULL,
            //`user_dispensed` varchar(45) default NULL,
            //`dispense_completed` varchar(5) default NULL,

            var aDispese1 = new Dispense { ItemId = "1", GroupId = "27695", GroupDate = new DateTime(2017, 7, 1), ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 20, UnitPrice = 5, DispenseQuantity = 1, SubAmount = 5, StockBalance = 20, DateDispensed = new DateTime(2017, 7, 1, 17, 51, 25) };
            var aDispese2 = new Dispense { ItemId = "1", GroupId = "11358", GroupDate = new DateTime(2017, 7, 1), ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 18, UnitPrice = 5, DispenseQuantity = 2, SubAmount = 10, StockBalance = 18, DateDispensed = new DateTime(2017, 7, 1, 18, 1, 29) };
            var aDispese3 = new Dispense { ItemId = "1", GroupId = "3439", GroupDate = new DateTime(2017, 7, 1), ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 15, UnitPrice = 4, DispenseQuantity = 3, SubAmount = 12, StockBalance = 15, DateDispensed = new DateTime(2017, 7, 1, 18, 6, 6) };
            var aDispese4 = new Dispense { ItemId = "1", GroupId = "85908", GroupDate = new DateTime(2017, 7, 1), ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 13, UnitPrice = 3, DispenseQuantity = 2, SubAmount = 6, StockBalance = 13, DateDispensed = new DateTime(2017, 7, 1, 18, 12, 02) };
            var aDispese5 = new Dispense { ItemId = "1", GroupId = "21550", GroupDate = new DateTime(2017, 7, 1), ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 10, UnitPrice = 3, DispenseQuantity = 3, SubAmount = 9, StockBalance = 10, DateDispensed = new DateTime(2017, 7, 1, 18, 16, 45), DispenseCompleted = "YES" };
            var aDispese6 = new Dispense { ItemId = "1", GroupId = "18689", GroupDate = new DateTime(2017, 7, 1), ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 8, UnitPrice = 5, DispenseQuantity = 2, SubAmount = 10, StockBalance = 8, DateDispensed = new DateTime(2017, 7, 1, 18, 28, 35) };
            var aDispese7 = new Dispense { ItemId = "1", GroupId = "71243", GroupDate = new DateTime(2017, 7, 1), ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 6, UnitPrice = 3, DispenseQuantity = 2, SubAmount = 6, StockBalance = 6, DateDispensed = new DateTime(2017, 7, 1, 18, 35, 20) };
            var aDispese8 = new Dispense { ItemId = "1", GroupId = "60611", GroupDate = new DateTime(2017, 7, 1), ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 5, UnitPrice = 5, DispenseQuantity = 1, SubAmount = 5, StockBalance = 5, DateDispensed = new DateTime(2017, 7, 1, 18, 39, 10), DispenseCompleted = "YES" };
            var aDispese9 = new Dispense { ItemId = "1", GroupId = "26130", GroupDate = new DateTime(2017, 7, 1), ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 4, UnitPrice = 2, DispenseQuantity = 1, SubAmount = 2, StockBalance = 4, DateDispensed = new DateTime(2017, 7, 1, 20, 9, 37) };
            var aDispese10 = new Dispense { ItemId = "2", GroupId = "88108", GroupDate = new DateTime(2017, 7, 1), ItemCode = "Asp01", ItemName = "Aspirin", StockLevel = 14, UnitPrice = 5, DispenseQuantity = 2, SubAmount = 10, StockBalance = 14, DateDispensed = new DateTime(2017, 7, 1, 20, 10, 18) };
            var aDispese11 = new Dispense { ItemId = "2", GroupId = "10657", GroupDate = new DateTime(2017, 7, 1), ItemCode = "Asp01", ItemName = "Aspirin", StockLevel = 13, UnitPrice = 5, DispenseQuantity = 1, SubAmount = 5, StockBalance = 13, DateDispensed = new DateTime(2017, 7, 1, 20, 11, 28), DispenseCompleted = "YES" };
            var aDispese12 = new Dispense { ItemId = "2", GroupId = "21132", GroupDate = new DateTime(2017, 7, 2), ItemCode = "Asp01", ItemName = "Aspirin", StockLevel = 3, UnitPrice = 10, DispenseQuantity = 1, SubAmount = 10, StockBalance = 3, DateDispensed = new DateTime(2017, 7, 2, 15, 21, 21), DispenseCompleted = "YES" };
            var aDispese13 = new Dispense { ItemId = "3", GroupId = "21132", GroupDate = new DateTime(2017, 7, 2), ItemName = "Felvin", StockLevel = 47, UnitPrice = 50, DispenseQuantity = 1, SubAmount = 50, StockBalance = 47, DateDispensed = new DateTime(2017, 7, 2, 15, 21, 21), DispenseCompleted = "YES" };
            var aDispese14 = new Dispense { ItemId = "3", GroupId = "4141", GroupDate = new DateTime(2017, 7, 2), ItemName = "Felvin", StockLevel = 46, UnitPrice = 50, DispenseQuantity = 1, SubAmount = 50, StockBalance = 46, DateDispensed = new DateTime(2017, 7, 2, 15, 25, 04), DispenseCompleted = "YES" };
            var aDispese15 = new Dispense { ItemId = "1", GroupId = "4141", GroupDate = new DateTime(2017, 7, 2), ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 3, UnitPrice = 40, DispenseQuantity = 1, SubAmount = 40, StockBalance = 3, DateDispensed = new DateTime(2017, 7, 2, 15, 25, 04), DispenseCompleted = "YES" };

            //(16,'3','42799','2017-07-11','','Felvin',43,55,1,55,NULL,NULL,43,'2017-07-11 22:07:18','',NULL),
            //(17,'3','60105','2017-07-11','','Felvin',42,55,1,55,NULL,NULL,42,'2017-07-11 22:27:23','','YES'),
            //(18,'1','60105','2017-07-11','PARA-01','Paracetamol',2,12,1,12,NULL,NULL,2,'2017-07-11 22:27:23','','YES'),
            //(19,'3','26499','2017-07-11','','Felvin',41,55,1,55,NULL,NULL,41,'2017-07-11 22:37:54','',NULL),
            //(20,'1','26499','2017-07-11','PARA-01','Paracetamol',1,12,1,12,NULL,NULL,1,'2017-07-11 22:37:54','',NULL),
            //(21,'3','71337','2017-07-16','','Felvin',17,70,1,70,NULL,NULL,17,'2017-07-16 15:48:51','',NULL),
            //(22,'3','37887','2017-07-16','','Felvin',13,70,1,0,NULL,NULL,0,'2017-07-16 20:17:35','',NULL),
            //(23,'3','66011','2017-07-16','','Felvin',13,70,1,0,NULL,NULL,12,'2017-07-16 20:52:25','',NULL),
            //(24,'3','60419','2017-07-16','','Felvin',12,70,1,70,NULL,NULL,11,'2017-07-16 20:54:54','','YES'),
            //(25,'3','84483','2017-07-16','','Felvin',11,70,1,70,NULL,NULL,10,'2017-07-16 21:19:07','','YES'),
            //(26,'2','84483','2017-07-16','Asp01','Aspirin',8,58,2,116,NULL,NULL,6,'2017-07-16 21:19:07','','YES'),
            //(27,'1','84483','2017-07-16','PARA-01','Paracetamol',10,10,1,10,NULL,NULL,9,'2017-07-16 21:19:07','','YES'),
            //(28,'1','84269','2017-07-16','PARA-01','Paracetamol',9,10,1,10,NULL,NULL,8,'2017-07-16 21:35:23','','YES'),
            //(29,'1','84269','2017-07-16','PARA-01','Paracetamol',8,10,1,10,NULL,NULL,7,'2017-07-16 21:35:23','',NULL),
            //(30,'1','74996','2017-07-16','PARA-01','Paracetamol',7,10,1,10,NULL,NULL,6,'2017-07-16 21:36:32','','YES'),
            //(31,'2','74996','2017-07-16','Asp01','Aspirin',7,58,1,58,NULL,NULL,6,'2017-07-16 21:36:32','','YES'),
            //(32,'2','74996','2017-07-16','Asp01','Aspirin',6,58,1,58,NULL,NULL,5,'2017-07-16 21:36:32','',NULL),
            //(33,'3','11913','2017-07-16','','Felvin',10,70,1,70,NULL,NULL,9,'2017-07-16 21:41:06','','YES'),
            //(34,'2','11913','2017-07-16','Asp01','Aspirin',5,58,1,58,NULL,NULL,4,'2017-07-16 21:41:06','','YES'),
            //(35,'2','11913','2017-07-16','Asp01','Aspirin',4,58,1,58,NULL,NULL,3,'2017-07-16 21:41:06','','YES'),
            //(36,'1','11913','2017-07-16','PARA-01','Paracetamol',6,10,1,10,NULL,NULL,5,'2017-07-16 21:41:06','','YES'),
            //(37,'3','31610','2017-07-22','','Felvin',9,80,1,80,NULL,NULL,8,'2017-07-22 11:40:06','','YES'),
            //(38,'2','31610','2017-07-22','Asp01','Aspirin',2,60,2,120,NULL,NULL,0,'2017-07-22 11:40:06','','YES'),
            //(39,'3','31610','2017-07-22','','Felvin',8,80,1,80,NULL,NULL,7,'2017-07-22 11:40:06','','YES'),
            //(40,'2','2304','2017-07-22','Asp01','Aspirin',19,60,1,60,NULL,NULL,18,'2017-07-22 20:03:00','','YES'),
            //(41,'1','2304','2017-07-22','PARA-01','Paracetamol',19,20,1,20,NULL,NULL,18,'2017-07-22 20:03:00','','YES'),
            //(42,'3','2304','2017-07-22','','Felvin',19,80,1,80,NULL,NULL,18,'2017-07-22 20:03:00','','YES');

            context.Dispenses.AddRange(new[] { aDispese1, aDispese2, aDispese3, aDispese4, aDispese5, aDispese6, aDispese7, aDispese8, aDispese9, aDispese10, aDispese11, aDispese12, aDispese13, aDispese14, aDispese15 });

            var stockUpdate1 = new StockUpdate { ItemId = "1", ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 21, QuantityAdded = 20, StockBalance = 21, UpdatedAt = new DateTime(2017, 7, 1, 17, 50, 14) };
            var stockUpdate2 = new StockUpdate { ItemId = "2", ItemCode = "Asp01", ItemName = "Aspirin", StockLevel = 20, QuantityAdded = 20, StockBalance = 20, UpdatedAt = new DateTime(2017, 7, 1, 20, 0, 21) };
            var stockUpdate3 = new StockUpdate { ItemId = "2", ItemCode = "Asp01", ItemName = "Aspirin", StockLevel = 20, QuantityAdded = 20, StockBalance = 20, UpdatedAt = new DateTime(2017, 7, 1, 20, 0, 21) };
            var stockUpdate4 = new StockUpdate { ItemId = "3", ItemCode = string.Empty, ItemName = "Felvin", StockLevel = 50, QuantityAdded = 50, StockBalance = 50, UpdatedAt = new DateTime(2017, 7, 2, 10, 59, 47) };
            var stockUpdate5 = new StockUpdate { ItemId = "2", ItemCode = "Asp01", ItemName = "Aspirin", StockLevel = 10, QuantityAdded = 10, StockBalance = 10, UpdatedAt = new DateTime(2017, 7, 11, 22, 39, 12) };
            var stockUpdate6 = new StockUpdate { ItemId = "1", ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 11, QuantityAdded = 10, StockBalance = 11, UpdatedAt = new DateTime(2017, 7, 11, 22, 48, 53) };
            var stockUpdate7 = new StockUpdate { ItemId = "1", ItemCode = "PARA-01", ItemName = "Paracetamol", StockLevel = 20, QuantityAdded = 14, StockBalance = 20, UpdatedAt = new DateTime(2017, 7, 22, 11, 41, 36) };
            var stockUpdate8 = new StockUpdate { ItemId = "2", ItemCode = "Asp01", ItemName = "Aspirin", StockLevel = 20, QuantityAdded = 18, StockBalance = 20, UpdatedAt = new DateTime(2017, 7, 22, 11, 41, 36) };
            var stockUpdate9 = new StockUpdate { ItemId = "3", ItemCode = string.Empty, ItemName = "Felvin", StockLevel = 20, QuantityAdded = 12, StockBalance = 20, UpdatedAt = new DateTime(2017, 7, 22, 11, 41, 36) };

            context.StockUpdates.AddRange(new[] { stockUpdate1, stockUpdate2, stockUpdate3, stockUpdate4, stockUpdate5, stockUpdate6, stockUpdate7, stockUpdate8, stockUpdate9 });

            var item1 = new Item { Code = "PARA-01", Name = "Paracetamol", Description = "500mg tablet", Manufacturer = "Emzor", MajorSupplier = "Emzor Distributor", PackQuantity = "10", PackDescription = "Sachet", AlternativeItem = "2", StandardIssueQuantity = "Aspirin", EconomicOrderQuantity = "100", PurchasePrice = 10, MarkupPercent = 0, SellingPrice = 20, StockLevel = 19, MinimumLevel = 40, ReOrderLevel = 500, MaximumLevel = 50, LeadDays = 3, CreatedAt = new DateTime(2017, 6, 26, 19, 49, 1), ModifiedAt = new DateTime(2017, 7, 22, 20, 3, 0) };
            var item2 = new Item { Code = "Asp01", Name = "Aspirin", Description = "300mg", Manufacturer = "Emzor", MajorSupplier = "Emzor Distributor", PackQuantity = "20", PackDescription = "Sachet", AlternativeItem = "2", StandardIssueQuantity = "Aspirin", EconomicOrderQuantity = "100", PurchasePrice = 55, MarkupPercent = 15, SellingPrice = 65, StockLevel = 19, MinimumLevel = 100, ReOrderLevel = 200, MaximumLevel = 2000, LeadDays = 3, CreatedAt = new DateTime(2017, 7, 1, 19, 57, 12), ModifiedAt = new DateTime(2017, 7, 22, 22, 03, 47) };
            var item3 = new Item { Code = "", Name = "Felvin", Description = "pain killer, 2mg", AlternativeName = "Piroxicam", MajorSupplier = "Nich", PackQuantity = "10", PackDescription = "Pack", StandardIssueQuantity = "Ricam", EconomicOrderQuantity = "5", PurchasePrice = 70, MarkupPercent = 0, SellingPrice = 80, StockLevel = 19, MinimumLevel = 10, ReOrderLevel = 5, MaximumLevel = 0, LeadDays = 1, CreatedAt = new DateTime(2017, 7, 2, 10, 43, 40), ModifiedAt = new DateTime(2017, 7, 22, 20, 3, 0) };

            context.Items.AddRange(new[] { item1, item2, item3 });

            var dis1 = new DispenseSummary { GroupId = "21550", GroupDate = new DateTime(2017, 7, 1), SubAmount = 9, Discount = 1, Vat = 5, Total = 8, DateDispensed = new DateTime(2017, 7, 1, 18, 16, 45) };
            var dis2 = new DispenseSummary { GroupId = "60611", GroupDate = new DateTime(2017, 7, 1), SubAmount = 5, Discount = 2, Vat = 4.5f, Total = 8, DateDispensed = new DateTime(2017, 7, 1, 18, 39, 10) };
            var dis3 = new DispenseSummary { GroupId = "10657", GroupDate = new DateTime(2017, 7, 1), SubAmount = 5, Discount = 1, Vat = 5, Total = 4, DateDispensed = new DateTime(2017, 7, 1, 20, 11, 28) };

            //(3,'10657','2017-07-01',5,1,5,4,'2017-07-01 20:11:28',''),
            //(4,'21132','2017-07-02',60,10,0,50,'2017-07-02 15:21:21',''),
            //(5,'60105','2017-07-11',67,7,0,60,'2017-07-11 22:27:23',''),
            //(6,'60419','2017-07-16',70,0,0,70,'2017-07-16 20:54:54',''),
            //(7,'84269','2017-07-16',10,0,0,10,'2017-07-16 21:35:23',''),
            //(8,'74996','2017-07-16',68,0,0,68,'2017-07-16 21:36:32',''),
            //(9,'11913','2017-07-16',196,0,0,196,'2017-07-16 21:41:06',''),
            //(10,'31610','2017-07-22',280,50,0,230,'2017-07-22 11:40:06',''),
            //(11,'2304','2017-07-22',160,0,0,160,'2017-07-22 20:03:00','');

            context.DispenseSummaries.AddRange(new[] { dis1 });

            base.Seed(context);
        }
    }
}
