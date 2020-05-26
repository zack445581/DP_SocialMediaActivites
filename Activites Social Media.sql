create database ActivitesSocialMedia

drop database ActivitesSocialMedia

use ActivitesSocialMedia




create table Userr(
id int identity(1,1) primary key,
email varchar(30) unique,
pass varchar(30))



create table propos(
id int identity(1,1) primary key,
datep date ,
titre varchar(max),
detail varchar(max))


create table client(
id int identity(1,1) primary key,
picClient varbinary(max) null,
raisonSociale varchar(50),
numTele int,
adress varchar(50),
dateDebut date)


create table top3(
id int identity(1,1) primary key,
datee date,
personTouchees int,
interaction int,
reaction int,
commentaire int,
partage int,
idc int foreign key references client(id),
idsm int foreign key references SocialMedia(id))



create table SocialMedia(
id int identity(1,1) primary key,
name varchar(30) unique,
pic image null)


create table DépensesPublicitaires(
id int identity(1,1) primary key,
Campagne varchar(max),
PersonnesAtteintes int,
Interactions int,
Depenses int,
total int)


create table IndicateursPerformance(
id int identity(1,1) primary key,
pic1 varbinary(max) null,
pic2 varbinary(max) null)



create table DépensesPublicitaires2(
Campagne varchar(max),
Résultat int,
Portée int,
Impressions int ,
CoutParRsultat int,
Depenses int,
total int)






select * from userr
select * from client
select * from propos
select * from top3
select * from SocialMedia
select * from IndicateursPerformance





select reaction from top3 order by reaction desc

select t.datee ,ip.* from top3 t,client c ,IndicateursPerformance ip where c.id = idc and idsm =2 order by reaction desc 

SELECT CONVERT(varchar , GetDate() ,110) AS "Date au Format USA" ,

select c.raisonSociale, reaction from top3 ,client c where c.id = idc and idsm=1 order by reaction desc 

select datepart(month , t.datee),idc,idsm,s.id,s.name,c.id from top3 t, client c,SocialMedia s where idc=c.id and idsm=s.id and c.id=2
select datepart(month , t.datee),idc,idsm,s.id,s.name,c.id from top3 t, client c,SocialMedia s where idc=c.id and idsm=s.id and c.id = c.id
select c.raisonSociale from top3 t,client c where t.idc = c.id
SELECT client.*, top3.* FROM client INNER JOIN top3 ON client.id = top3.idc
select * from DépensesPublicitaires dp, IndicateursPerformance ip

---------------------------------------
SELECT  client.*, DépensesPublicitaires.*, IndicateursPerformance.*, top3.* FROM client INNER JOIN IndicateursPerformance ON client.id = IndicateursPerformance.id INNER JOIN top3 ON client.id = top3.idc CROSS JOIN DépensesPublicitaires
SELECT DISTINCT client.*, DépensesPublicitaires.* FROM client , DépensesPublicitaires
insert into IndicateursPerformance values('C:\Users\ZAKARIA\Desktop\Activities Social Media\no-image-icon-4.png','C:\Users\ZAKARIA\Desktop\Activities Social Media\no-image-icon-4.png')
insert into client values (1,'facebook','C:\Users\ZAKARIA\Desktop\Activities Social Media\no-image-icon-4.png')
select DISTINCT c.raisonSociale , DATENAME(month, t.datee) from top3 t , client c where t.id = c.id and c.id =2
select * from top3 where datee(select DATEADD(MONTH , 0 , datee) from top3
select *, DATEADD(MONTH , 0 , datee) from top3 where datee = '2019-04-19'
------------------------------------------------------------------------------------------------------------------------------------

INSERT INTO client(picClient ,raisonSociale) 
SELECT BulkColumn , 'aaa'
FROM Openrowset( Bulk 'C:\Users\ZAKARIA\Desktop\Activities Social Media\no-image-icon-4.png', Single_Blob) as defaultimg
insert into socialmedia values('facebook','C:\Users\ZAKARIA\Desktop\pp\f.png')
select * from top3
insert into top3 values('1/1/1',1000,1200,120,20,40,1)
-- top3 (dateDebut,personTouchees,interaction,reaction,commentaire,partage ) select  from top3 t ,
create proc sa 
as
select * from client
select * from top3
select * from socialmedia
select * from DépensesPublicitaires
select * from IndicateursPerformance
create proc clientproc 
as
Begin
select * from client
end

create proc IndicateursPerformanceproc 
as
select * from IndicateursPerformance

