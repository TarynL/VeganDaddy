USE [master]
GO

IF db_id('VeganDaddy') IS NULL
  CREATE DATABASE [VeganDaddy]
GO

USE [VeganDaddy]
GO

---------------------------------------------------------------------------

DROP TABLE IF EXISTS [UserProfile];
DROP TABLE IF EXISTS [Recipe];
DROP TABLE IF EXISTS [Ingredient];
DROP TABLE IF EXISTS [Measure];
DROP TABLE IF EXISTS [RecipeIngredient];

GO 


CREATE TABLE [UserProfile] (
  [Id] INTEGER IDENTITY PRIMARY KEY NOT NULL,
  [FirebaseUserId] NVARCHAR(50) NOT NULL,
  [FirstName] NVARCHAR(50) NOT NULL,
  [LastName] NVARCHAR(50) NOT NULL,
  [DisplayName] NVARCHAR(50) NOT NULL,
  [Email] NVARCHAR(255) NOT NULL,

  CONSTRAINT UQ_FirebaseUserId UNIQUE(FirebaseUserId)
)
GO

CREATE TABLE [Recipe] (
  [Id] INTEGER IDENTITY PRIMARY KEY NOT NULL,
  [UserId] INTEGER NOT NULL,
  [Name] NVARCHAR(50) NOT NULL,
  [Description] NVARCHAR(255) NOT NULL,
  [Instructions] NVARCHAR(50) NOT NULL,
  [ImageUrl] NVARCHAR(255) NOT NULL,
  [PostedDate] Datetime,
  [IsDeleted] BIT NOT NULL DEFAULT 0
)
GO

CREATE TABLE [Ingredient] (
  [Id] INTEGER IDENTITY PRIMARY KEY NOT NULL,
  [Name] NVARCHAR(50) NOT NULL,
  [IsDeleted] BIT NOT NULL DEFAULT 0
)
GO

CREATE TABLE [Measure] (
  [Id] INTEGER IDENTITY PRIMARY KEY NOT NULL,
  [Name] NVARCHAR(50) NOT NULL,
)
GO

CREATE TABLE [RecipeIngredient] (
  [Id] INTEGER IDENTITY PRIMARY KEY NOT NULL,
  [RecipeId] INT NOT NULL, 
  [IngredientId] INT NOT NULL,
  [MeasureId] INT,
  [Amount] INT,
  [IsDeleted] BIT NOT NULL DEFAULT 0
)
GO
INSERT INTO UserProfile (FirebaseUserId, FirstName, LastName, DisplayName, Email) VALUES ('wHeoZpxi09Pshooo9oSkeR7yvJF2', 'Taryn', 'Lytle', 'Taryn', 'taryn@taryn.com');

INSERT INTO UserProfile (FirebaseUserId, FirstName, LastName, DisplayName, Email) VALUES ('qlpVOVYLDgOfvliRQIkbqbWFtK62', 'Haley', 'Grant', 'Haley', 'haley@haley.com');

INSERT INTO Measure (name) VALUES('CUP'), ('TEASPOON'), ('TABLESPOON');

INSERT INTO Ingredient (name) VALUES('artichokes'), ('veggie broth'), ('mushrooms'), ('onion'), ('olive oil'), ('sage'), ('garlic cloves'), ('lemon'), ('fettuccine');

INSERT INTO Recipe ( UserId, Name, Description, Instructions, PostedDate) VALUES ( 1, 'Mushroom Artichoke Pasta', 'Mushroom pasta with a creamy artichoke sauce', 'Preheat oven to 400. Bring pot of water to a boil. Cook pasta to al dente. In a large skillet, saute mushrooms and onions over medium heat. In a blender, mix artichokes, sage, oil, broth, salt and pepper-to taste. Blend until smooth. Mix all ingredients and serve hot.', SYSDATETIME());

INSERT INTO RecipeIngredient (RecipeId, IngredientId, MeasureId, amount) VALUES (1, 3, 1, 1);

INSERT INTO RecipeIngredient (RecipeId, IngredientId, MeasureId, amount) VALUES (1, 4, 1, 1);

INSERT INTO RecipeIngredient (RecipeId, IngredientId, MeasureId, amount) VALUES (1, 2, 1, .75);

INSERT INTO RecipeIngredient (RecipeId, IngredientId, MeasureId, amount) VALUES (1, 1, 1, 1.5);

INSERT INTO RecipeIngredient (RecipeId, IngredientId, MeasureId, amount) VALUES (1, 5, 1, .25);

INSERT INTO RecipeIngredient (RecipeId, IngredientId, MeasureId, amount) VALUES (1, 6, 1, .25);

INSERT INTO RecipeIngredient (RecipeId, IngredientId, MeasureId, amount) VALUES (1, 7, NULL, 2);

INSERT INTO RecipeIngredient (RecipeId, IngredientId, MeasureId, amount) VALUES (1, 8, 3, .5);













