USE [Pratice]
GO

INSERT INTO [dbo].[Tenant]
           (ID,
		   [personal_account]
           ,[firstname]
           ,[lastname]
           ,[phone]
           ,[pass_hash])
     VALUES
           (1,
		   '123',
           'Misha',
           'Pori',
           '89959971843',
           HASHBYTES('sha1','user12345')
		   )
GO


