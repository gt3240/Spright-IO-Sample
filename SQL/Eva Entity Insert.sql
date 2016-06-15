USE [C15]
GO

/****** Object:  StoredProcedure [dbo].[EVA_Entity_Insert]    Script Date: 6/14/2016 5:39:16 PM ******/
DROP PROCEDURE [dbo].[EVA_Entity_Insert]
GO

/****** Object:  StoredProcedure [dbo].[EVA_Entity_Insert]    Script Date: 6/14/2016 5:39:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[EVA_Entity_Insert]
			
			@Name nvarchar(255)
           ,@Slug nvarchar(255)
           ,@WebsiteId int
		   ,@OID int output

AS

BEGIN
INSERT INTO [dbo].[EVA_Entities]
           
		   (
		    [Name]
           ,[Slug]
           ,[CreatedDate]
           ,[WebsiteId]
		   )
     VALUES
           (
		    @Name
           ,@Slug
		   , GETUTCDATE()
           ,@WebsiteId
		   )

SET @OID = SCOPE_IDENTITY()
END
GO


