use ResturantDBProject

--modyifying schema to have date as a string 
--could be modified if needed
drop table Expenses
create table Expenses
(
ExpName VARCHAR(15) not null, --What name? prehaps "Type"
ExpDate varchar(20) not null, 
primary key (ExpName, ExpDate),
Cost int,
ExpDescription VARCHAR(50),
ExpBranchID int,
foreign key(ExpBranchID) references Branch
ON DELETE CASCADE
on update CASCADE
)

--deleting old data that i had 
delete from Menu
delete from FoodItem

insert into Menu(MenName,NumOfItems)
	Values
	('Main course',5),
	('Drinks' , 3),
	('appetizers'  , 2),
	('desserts',3)


insert into FoodItem
Values
(1,25,'shawerma' , 'Main course'),
(2,30 , 'pizza' , 'Main course'),
(3,50,'Ramen' , 'Main course'),
(4,50,'Rice' , 'Main course'),
(5,100,'sushi' , 'Main course'),
(101,10,'Tea','Drinks'),
(102,20,'Latte','Drinks'),
(103,30,'MilkShake','Drinks'),
(201,15,'Bread','appetizers'),
(202,25,'Potatos','appetizers'),
(301,20,'Pancake' , 'desserts'),
(302,5,'chocolate' , 'desserts'),
(303,30,'Cake' , 'desserts')


insert into User_
values
('admin' , 1234 , 2),
('Mahmoud' , 2002 , 1),
('Noone' , 1313 , 2)

insert into BranchSupervisor
Values
('Neumann' , '123456789' , '0123' , 'admin'),
('Elon musk' , '311142222' , '010234' , 'Noone')

insert into Branch
Values
('FlatLand' , 1 , 'Cairo' , 1 , '123456789'),
('Eat Here' , 2 , 'Giza' , 3 , '311142222')


insert into Employee
Values
('Feynman' , 1 , 'waiter' , 5000 , 5 , 1 ),
('Euler' , 2 , 'cashier' , 10000 , 4 , 1 ),
('Messi' , 3 , 'waiter' , 5000 , 3 , 1 ),
('Gordon Ramsey' , 4 , 'chef' , 15000 , 4 , 1 ),
('Einstien' , 5 , 'waiter' , 5000 , 1 , 2 ),
('Schrodinger' , 6 , 'waiter' , 25000 , 4 , 2 ),
('Claude Shanon' , 7 , 'cashier' , 4000 , 5 , 2 ),
('Ronaldo' , 8 , 'chef' , 2000 , 1 , 2 )

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


insert into Expenses
Values
('electricty' , 'may-22' , 15000 , 'Elctricity bill' , 1),
('Water' , 'may-22' , 5000 , 'Water bill' , 1),
('Food resources' , 'may-22' , 10000 , 'Total amount spent on food' , 1),
('electricty' , 'may-22' , 13000 , 'Elctricity bill' , 2),
('Water' , 'may-22' , 4000 , 'Water bill' , 2),
('Food resources' , 'may-22' , 11000 , 'Total amount spent on food' , 2)

