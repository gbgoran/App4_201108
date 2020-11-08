CREATE TABLE Customers (
CustomerID int not null identity(1,1) primary key,
[ContactNameFullName] nvarchar(100) not null,
[ContactNumber] int not null,
[CompanyName] nvarchar(100) not null,
)

CREATE TABLE Issues (
IssueID int not null primary key,
FK_CustomerID int not null FOREIGN KEY REFERENCES Customers(CustomerID),
Title nvarchar(100) not null,
Description nvarchar(2000) not null,
Created DateTime not null
)

CREATE TABLE Comments (
CommentID int not null primary key,
FK_IssueID int not null FOREIGN KEY REFERENCES Issues(IssueID),
Description  nvarchar(2000) not null,
Created DateTime
)