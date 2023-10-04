create table Roles
(
  ID int primary key IDENTITY(1,1),
  RoleName varchar(100) not null
);
create table Users
(
  [ID] int primary key IDENTITY(1,1),
  [Surname] varchar(100) not null,
  [Name] varchar(100) not null,
  [Patronymic] varchar(100) not null,
  [Login] text not null,
  [Password] text not null,
  [Role] int not null,
  foreign key ([Role]) references [Roles](ID)
);
create table PickupPoints
(
	[ID] int primary key IDENTITY(1,1),
	[Address] varchar(150)
);
create table [Orders]
(
  ID int primary key IDENTITY(1,1),
  OrderDate datetime not null,
  DeliveryDate datetime not null,
  PickupPointID int not null,
  UserID int not null,
  ReceivingCode int not null,
  [Status] varchar(50)
  foreign key (PickupPointID) references [PickupPoints](ID),
  foreign key (UserID) references [Users](ID) 
);

create table Products
(
  ProductArticleNumber nvarchar(100) primary key,
  Title text not null,
  MeasuremenUnit varchar(50) not null,
  Cost decimal(19,4) not null,
  MaximumDiscount int not null,
  Manufacturer varchar(150) not null,
  Supplier varchar(150) not null,
  Category varchar(200) not null,
  CurrentDiscount int not null,
  QuantityInStock int not null,
  [Description] text not null,
  Photo varchar(200)
);
create table OrderProduct
(
  OrderID int not null,
  ProductArticleNumber nvarchar(100)  not null,
  Primary key (OrderID,ProductArticleNumber),
  foreign key (OrderID) references Orders(ID),
  foreign key (ProductArticleNumber) references Products(ProductArticleNumber)
);