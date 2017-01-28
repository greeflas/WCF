USE master

if DB_ID('TestWcfMaster') IS NOT NULL
   drop database TestWcfMaster;
GO
create database TestWcfMaster;
GO
USE TestWcfMaster
GO

CREATE TABLE Test
( 
  id int not null identity primary key,
  name nvarchar(24)
)
insert into Test(name)
VALUES ('test1'), ('test2');
if DB_ID('TestWcfDetail') IS NOT NULL
   drop database TestWcfDetail;
GO

create database TestWcfDetail;
GO
USE TestWcfDetail
GO

CREATE TABLE Test
( 
  id int not null primary key,
  name nvarchar(24),
  val money not null
)

GO
INSERT INTO Test (id, name, val) VALUES
(1, 'name1', 1),(2, 'name2', 2);
