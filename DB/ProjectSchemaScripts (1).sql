CREATE DATABASE ResturantDBProject
GO
use ResturantDBProject

create table User_
(
LoginName VARCHAR(75) not null,
Password int,
Priv int,
primary key (LoginName)
)

create table BranchSupervisor
(
Name VARCHAR(75),
SSN int not null,
primary key (SSN),
PhoneNumber int,
LoginName VARCHAR(75),
foreign key (LoginName) references User_

	ON UPDATE CASCADE
)

create table Branch
(
BranchName VARCHAR(15),
BranchID int not null,
primary key (BranchID),
Location VARCHAR(15),
BranchTax int,
BranchSupSSN int,
foreign key (BranchSupSSN) references BranchSupervisor
	ON DELETE SET NULL
	ON UPDATE CASCADE
)

create table Expenses
(
ExpName VARCHAR(15) not null, --What name? prehaps "Type"
ExpDate DATE not null, 
primary key (ExpName, ExpDate),
Cost int,
ExpDescription VARCHAR(50),
ExpBranchID int,
foreign key(ExpBranchID) references Branch
ON DELETE CASCADE
on update CASCADE
)

create table Resources
(
ResName VARCHAR(15) not null,
primary key (ResName),
Amount int,
Price float,
ResBranchID int,
foreign key (ResBranchID) references Branch
On DELETE CASCADE
on update CASCADE
)

create table Order_
(
OrderID int not null,
OrderDate date
primary key (OrderID),
--OrderNum int, --WHAT'S THE DIFFERENCE?

)

create table Employee
(
EmpName VARCHAR (75),
EmpID int not null,
primary key (EmpID),
Role VARCHAR (10),
Salary int,
Performance int, --Rev
EmpBranchID int,
foreign key (EmpBranchID) references Branch
on delete set NULL
on update cascade
)

create table Menu
(
MenName VARCHAR(15) not null,
Primary key (MenName),   --Why don't we add a number as a primary key instead?
NumOfItems int,
)

create table Customer
(
CustAddress VARCHAR(100) not null,
PhoneNum int not null,   --If in resturant, Why the phone num??
CustName VARCHAR (75),
primary key (PhoneNum),  --Whu?
)

create table FoodItem
(
ID int not null,
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
