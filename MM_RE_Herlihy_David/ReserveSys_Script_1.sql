--MM_SE_Herlihy_D
--ReserveSys
--This script creates the ReserveSys databases

DROP TABLE Reservations;
DROP TABLE Customers;
DROP TABLE Rooms;
DROP TABLE Rates;

CREATE TABLE Rates
(Room_Type char(2) NOT NULL,
Rate_Description varchar2(30) NOT NULL,
Room_Rate numeric(5,2) NOT NULL,
CONSTRAINT pk_Rates PRIMARY KEY (Room_Type));

CREATE TABLE Rooms
(RoomNo numeric(3) NOT NULL,
Room_Description varchar2(30) NOT NULL,
Room_Type char(2) NOT NULL,
Room_Status char(1) NOT NULL,
CONSTRAINT pk_Rooms PRIMARY KEY (RoomNo),
CONSTRAINT fk_Type FOREIGN KEY (Room_Type) REFERENCES Rates(Room_Type));

CREATE TABLE Customers
(CustID numeric(6) NOT NULL,
FName varchar2(15) NOT NULL,
SName varchar2(15) NOT NULL,
Street varchar2(15) NOT NULL,
Town varchar2(15) NOT NULL,
County varchar2(15) NOT NULL,
Tel_No varchar2(12) NOT NULL,
CardNo numeric(20) NOT NULL,
CardName varchar2(25) NOT NULL,
CONSTRAINT pk_Customer PRIMARY KEY (CustID));

CREATE TABLE Reservations
(ResNo numeric(6) NOT NULL,
Arrival_Date DATE NOT NULL,
Dept_Date DATE NOT NULL,
Res_Status varchar2(2) NOT NULL,
Res_Cost numeric(6,2) NOT NULL,
CustID numeric(5) NOT NULL,
RoomNo numeric(3) NOT NULL,
CONSTRAINT pk_Res PRIMARY KEY (ResNo),
CONSTRAINT fk_Customer FOREIGN KEY (CustID) REFERENCES Customers(CustID),
CONSTRAINT fk_Room FOREIGN KEY (RoomNo) REFERENCES Rooms(RoomNo));







