DROP TABLE UserCreds

CREATE TABLE UserCreds (
	username varchar(100),
	password varchar (100)
);

-- stored procedure --
CREATE OR ALTER PROCEDURE spGetCreds

@Username varchar(100),
@Password varchar(100)

AS 
BEGIN
    INSERT INTO UserCreds (username, password) VALUES (@Username, @Password)
END

SELECT * FROM UserCreds