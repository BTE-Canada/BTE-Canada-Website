-- TEMP: 7*33V9e_z[WN*VPP

DROP TABLE IF EXISTS BuilderResourcesCategory;
CREATE TABLE BuilderResourcesCategory (
    Id int NOT NULL AUTO_INCREMENT,
    Name varchar(255) NOT NULL,
    Decsription varchar(255) NULL,
    PRIMARY KEY (Id)
);

DROP TABLE IF EXISTS BuilderResources;
CREATE TABLE BuilderResources (
    Id int NOT NULL AUTO_INCREMENT,
    Title varchar(255) NOT NULL,
    Content varchar(16000) NULL,
    PRIMARY KEY (Id)
);