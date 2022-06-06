CREATE TABLE Games ( 
	Id                   INTEGER NOT NULL  PRIMARY KEY  ,
	Name                 VARCHAR(200) NOT NULL    ,
	Description          LONGTEXT     ,
	Date                 DATE  DEFAULT CURRENT_DATE   ,
	Properties_List      LONGTEXT NOT NULL    ,
	FOREIGN KEY ( Id ) REFERENCES Properties( Owner_Fk_Id ) ON DELETE CASCADE ,
	FOREIGN KEY ( Id ) REFERENCES SecAttributes( Owner_Fk_Id ) ON DELETE CASCADE ,
	FOREIGN KEY ( Id ) REFERENCES Sheets( Source_Id )  
 );

CREATE TABLE Properties ( 
	Id                   VARCHAR(50) NOT NULL    ,
	Name                 VARCHAR(100) NOT NULL    ,
	Roll_Formula         MEDIUMTEXT  DEFAULT ':D20'   ,
	Usable               BOOLEAN  DEFAULT 0   ,
	Owner_Fk_Id          INTEGER NOT NULL    ,
	Propertie_Type       VARCHAR(100) NOT NULL    ,
	FOREIGN KEY ( Id ) REFERENCES PropertiesValue( Id_Properties ) ON DELETE CASCADE 
 );

CREATE TABLE SecAttributes ( 
	Id                   VARCHAR(50) NOT NULL    ,
	Name                 VARCHAR(150) NOT NULL    ,
	Description          MEDIUMTEXT     ,
	icon                 INTEGER  DEFAULT '0'   ,
	Color                VARCHAR(11)  DEFAULT '200-10-10'   ,
	Owner_Fk_Id          INTEGER     ,
	FOREIGN KEY ( Id ) REFERENCES SecAttributesValue( Id_Attributes ) ON DELETE CASCADE 
 );

CREATE TABLE PropertiesValue ( 
	Id_Properties        VARCHAR(50) NOT NULL    ,
	Value                VARCHAR(50) NOT NULL DEFAULT '0/0'   ,
	Owner_Id             INTEGER NOT NULL    
 );

CREATE TABLE SecAttributesValue ( 
	Id_Attributes        VARCHAR(50) NOT NULL    ,
	Value                VARCHAR(50) NOT NULL DEFAULT '0/0'   ,
	Owner_Id             INTEGER NOT NULL    
 );

CREATE TABLE Sheets ( 
	Id                   INTEGER NOT NULL  PRIMARY KEY  ,
	Name                 VARCHAR(200) NOT NULL    ,
	Description          LONGTEXT     ,
	Type                VARCHAR(100)     ,
	Image                INTEGER NOT NULL DEFAULT '0'   ,
	Player               BOOLEAN NOT NULL DEFAULT '0'   ,
	Source_Id            INTEGER NOT NULL    ,
	FOREIGN KEY ( Id ) REFERENCES SecAttributesValue( Owner_Id ) ON DELETE CASCADE ,
	FOREIGN KEY ( Id ) REFERENCES PropertiesValue( Owner_Id ) ON DELETE CASCADE 
 );