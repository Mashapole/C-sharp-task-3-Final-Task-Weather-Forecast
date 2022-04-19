Create Database WEATHER_FORECASTER

CREATE TABLE [dbo].[Login_Details] (
    [User_ID]          INT          IDENTITY (1, 1) NOT NULL,
    [Username]         VARCHAR (50) NOT NULL,
    [Password]         VARCHAR (50) NOT NULL,
    [Confirm_Password] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([User_ID] ASC)
);

CREATE TABLE [dbo].[Weather_Inputs] (
    [Input_ID]            INT          IDENTITY (1, 1) NOT NULL,
    [City]                VARCHAR (50) NOT NULL,
    [Date]                DATE         NOT NULL,
    [Minimum_Temperature] INT          NOT NULL,
    [Maximum_Temperature] INT          NOT NULL,
    [Precipitation]       INT          NOT NULL,
    [Humidity]            INT          NOT NULL,
    [Wind_speed]          INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Input_ID] ASC)
);

CREATE TABLE [dbo].[Favorite] (
    [key]      INT          IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (50) NOT NULL,
    [City]     VARCHAR (50) NOT NULL,
    [User_ID]  INT          NOT NULL,
    [Input_id] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([key] ASC),
    CONSTRAINT [FK_Favorite] FOREIGN KEY ([User_ID]) REFERENCES [dbo].[Login_Details] ([User_ID]),
    CONSTRAINT [FK_inputs] FOREIGN KEY ([Input_id]) REFERENCES [dbo].[Weather_Inputs] ([Input_ID])
);


Select* from [Login_Details];
Select* from [Weather_Inputs];
Select* from [Favorite];

insert into [Login_Details] values('Admin','12345','12345');
