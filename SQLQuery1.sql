Create table Charact
(
CharID int Not Null Primary Key,
Charname varchar (30),
Descriptive_Traits varchar (200),
Personality_Traits varchar (200),
Occupation varchar (50),
Inner_Drive varchar (200),
ThemeID int,
Img Varbinary(8000),
Foreign Key (ThemeID) references Theme(ThemeID)
);

Create table Theme
(
ThemeID int Not Null Primary Key,
ThemeName varchar (30),
Nature varchar (100),
Vibe varchar (100),
Location varchar (100),
Emotional_State varchar (100),
Scientific_Evidence varchar (100)
);
Alter table Place
(
Alter column
);
Create table Motive
(
MotiveID int Not Null Primary Key,
MotiveName varchar(30),
Descript varchar (200),
);
Create table Act
(
ActionID int Not Null Primary Key,
Actionn varchar (100)
);
Create table Place
(
PlaceID int Not Null Primary Key,
PlaceName varchar (30),
Landmark varchar (100),
Descriptive_traits varchar (100),
Overall_description varchar (100),
Style varchar (100),
Cultural_Vibe varchar (100),
ThemeID int,
Foreign Key (ThemeID) references Theme
);
Create table Script
(
ScriptID int Not Null Primary Key,
ScriptName nvarchar (30),
PlaceID int,
MotiveID int,
ThemeID int,
CharID int,
ActionID int,
Foreign Key (PlaceID) references Place,
Foreign Key (MotiveID) references Motive,
Foreign Key (ThemeID) references Theme,
Foreign Key (CharID) references Charact,
Foreign Key (ActionID) references Act
);

Create table Account
(
AccountID int Not Null Primary Key,
AccountName varchar (30),
Passw varchar (30),
Email varchar (30),
AccountTypeID int,
Foreign Key (AccountTypeID) references AccountType
);
Create table AccountType
(
AccountTypeID int Not Null Primary Key,
AccountTypeName varchar (30),
);
 