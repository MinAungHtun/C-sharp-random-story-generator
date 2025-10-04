Create table Accounts
(
AccountID int NOt Null Primary Key,
AccountName varchar(30) Not Null,
AccountTypeID int, 
FOreign Key (AccountTypeID) references Accounttype (AccountTypeID)
);
Create table Accounttype

(
AccountTypeID int NOt Null Primary Key,
AccountTypeName varchar (20),
);
Create table Themes
(
ThemesID int NOt Null Primary Key,
ThemesName varchar (20) Not Null,
);

Create table Character
(
CharacterID int NOt Null Primary Key,
CharacterName varchar(30) Not Null,
)
Create table Place
(
PlaceID int NOt Null Primary Key,
PlaceName varchar (30) Not Null,
)

Create table BackgroundMotive
(
MotiveID int Not Null Primary Key,
MotiveN varchar (30) Not Null,
);

Create table Animation
(
AnimationID int Not Null Primary Key,
);
Create table Images
(
ImagesID int NOt Null Primary Key,
);
Create table Story
(
StoryID int NOt Null Primary Key,
);