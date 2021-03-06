USE [AccessDB]
GO
/****** Object:  StoredProcedure [dbo].[Add_LMSMainCategory]    Script Date: 7/21/2021 10:17:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Udhayakumar M
-- Create date: 07/20/2021 12:20 PM
-- Description:	Used to add new LMS Main Category from Docebo API
-- =============================================
ALTER PROCEDURE [dbo].[Add_LMSMainCategory] 
	-- Add the parameters for the stored procedure here
	@InternalID bigint,
	@UniqueID nvarchar(50) = null,
	@Name nvarchar(999),
	@LmsExtObjID bigint = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	BEGIN TRY

		IF EXISTS (select 1 from LMSMainLearningCategory where internal_id = @InternalID)
			BEGIN
				update LMSMainLearningCategory set content_unique_id = @UniqueID, name = @Name, lms_ext_obj_id = @LmsExtObjID
					where internal_id = @InternalID
				
				select ErrorCode = null, Message = 'Successfully Updated', OutputCode = 1;
			END
		ELSE
			BEGIN
				-- SET IDENTITY_INSERT to ON.  
				SET IDENTITY_INSERT dbo.LMSMainLearningCategory ON;

				insert into LMSMainLearningCategory (internal_id, content_unique_id, name, lms_ext_obj_id)
					values (@InternalID, @UniqueID, @Name, @LmsExtObjID);
				
				select ErrorCode = null, Message = 'Successfully Inserted', OutputCode = 2;
			END
	END TRY
	BEGIN CATCH
		select ErrorCode = ERROR_NUMBER(), Message = ERROR_MESSAGE(), OutputCode = 0;
	END CATCH
END
