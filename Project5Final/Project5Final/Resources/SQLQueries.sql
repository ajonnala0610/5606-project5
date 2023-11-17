create database BloodBankDatabase;

use BloodBankDatabase;

create table Donor(Donor_Id INT PRIMARY KEY IDENTITY(1,1), Name NVARCHAR(50), Father_Name NVARCHAR(50), Mother_Name NVARCHAR(50), DOB DATE, Mobile_Number VARCHAR(20), Gender NVARCHAR(10), Email NVARCHAR(255), Blood_Group NVARCHAR(10), City NVARCHAR(50), Address NVARCHAR(255));

select * from Donor;

INSERT INTO Donor VALUES('Aishwarya', 'Seshu', 'Sarala', '10/06/1996', '9126573874', 'Female', 'axj20900@ucmo.edu', 'B+', 'Overland Park', '143rd Street 2099');