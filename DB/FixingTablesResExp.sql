use ResturantDBProject
drop table FoodItem

drop table expenses 
drop table resources
drop table theorderrelation
delete Order_
--use ResturantDBProject
--drop table Expenses
create table Expenses
(
ExpName VARCHAR(15) not null, --What name? prehaps "Type"
ExpDate varchar(20) not null,  
Cost int,
ExpDescription VARCHAR(50),
ExpBranchID int,
primary key (ExpName, ExpBranchID,ExpDate),
foreign key(ExpBranchID) references Branch
ON DELETE CASCADE
on update CASCADE
)

insert into Expenses
Values
('electricty' , 'may-22' , 15000 , 'Elctricity bill' , 1),
('Water' , 'may-22' , 5000 , 'Water bill' , 1),
('Food resources' , 'may-22' , 10000 , 'Total amount spent on food' , 1),
('electricty' , 'may-22' , 13000 , 'Elctricity bill' , 2),
('Water' , 'may-22' , 4000 , 'Water bill' , 2),
('Food resources' , 'may-22' , 11000 , 'Total amount spent on food' , 2)

drop table Resources
create table Resources
(
ResName VARCHAR(15) not null,
Amount int,
Price float,
ResBranchID int,
primary key (ResName,ResBranchID),
foreign key (ResBranchID) references Branch
On DELETE CASCADE
on update CASCADE
)

insert into Resources
Values
('chicken' , 70 , 57.5 , 1),
('chocolate' , 10 , 7.5 , 1),
('meat' , 30 , 157.5 , 1),
('milk' , 70 , 17 , 1),
('bread' , 130 , 5 , 1),
('chicken' , 30 , 57.5 , 2),
('chocolate' , 15 , 7.5 , 2),
('meat' , 50 , 157.5 , 2),
('milk' , 90 , 17 , 2),
('bread' , 30 , 5 , 2)



create table FoodItem
(
ID int IDENTITY(1,1) not null,
primary key (ID),
Price int,
Name VARCHAR(10),
inMenu VARCHAR(15),
foreign key (inMenu) references Menu
on DELETE set NULL
on update cascade
)

create table TheOrderRelation   --Needs to be changed.
(
CustomerPhone int not null, 
FoodID int not null,   --Order Can have more than an item..
OrderID int not null,
primary key (FoodID, OrderID,CustomerPhone),
Rate int,
Comment VARCHAR(100),
foreign key (FoodID) references FoodItem,
foreign key (OrderID) references Order_,
--foreign key (CustomerPhone) references Customer(PhoneNum)
)
