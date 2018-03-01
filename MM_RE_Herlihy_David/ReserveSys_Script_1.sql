--MM_SE_Herlihy_D
--ReserveSys
--This script creates the ReserveSys databases

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




