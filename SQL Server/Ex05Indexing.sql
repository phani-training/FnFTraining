Create Table Cars(Id int, BrandName varchar(100))

INSERT INTO Cars VALUES(1,'Ford')
INSERT INTO Cars VALUES(2,'Fiat')
INSERT INTO Cars VALUES(3,'Mini')
INSERT INTO Cars VALUES(4,'Jaguar')
INSERT INTO Cars VALUES(5,'Kia')
INSERT INTO Cars VALUES(6,'Nissan')
INSERT INTO Cars VALUES(7,'BMW')
INSERT INTO Cars VALUES(8,'Mercedes')
INSERT INTO Cars VALUES(9,'Mazda')
INSERT INTO Cars VALUES(10,'Volvo')
INSERT INTO Cars VALUES(11,'Lexus')
INSERT INTO Cars VALUES(12,'Buick')
INSERT INTO Cars VALUES(13,'GMC')
INSERT INTO Cars VALUES(14,'Honda')
INSERT INTO Cars VALUES(15,'Lotus')
INSERT INTO Cars VALUES(16,'Opel')
INSERT INTO Cars VALUES(17,'Bentley')
INSERT INTO Cars VALUES(18,'Dodge')
INSERT INTO Cars VALUES(19,'Tesla')
INSERT INTO Cars VALUES(20,'Porche')
INSERT INTO Cars VALUES(21,'Ferrari')
INSERT INTO Cars VALUES(22,'Audi')
GO
Drop table Cars

Create Unique Clustered Index IX_001 On Cars(Id)
Select * from Cars where Id = 12;

Delete From Cars where id > 100