SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_CarsTasksConfirm]
	@nCarTaskID		int, 
	@nUserConfirmID	int, 
	@bDropConfirm	bit, 
	@nError			int = 0 output,
	@cErrorText		varchar(200) = '' output 
AS

set nocount on

if	IsNull(@nCarTaskID, 0) = 0 begin
	select	@nError = -1, 
			@cErrorText = 'Не задан код задания...'
	return
end
if	not exists (select top 1 ID from CarsTasks with (nolock) where ID = @nCarTaskID) begin 
	select	@nError = -2, 
			@cErrorText = 'Не найдено задание с кодом ' + ltrim(str(@nCarTaskID)) + '...'
	return
end

declare @dDateConfirm smalldatetime, @nTripID int
select @dDateConfirm = DateConfirm, @nTripID = TripID 
	from CarsTasks with (nolock) 
	where ID = @nCarTaskID

if @bDropConfirm = 0 begin		-- подтверждение задания
	if	@dDateConfirm is not Null begin 
		select	@nError = -3, 
				@cErrorText = 'Задание с кодом ' + ltrim(str(@nCarTaskID)) + ' уже подтверждено...'
		return
	end
	if	@nTripID is Null begin 
		select	@nError = -4, 
				@cErrorText = 'Задание с кодом ' + ltrim(str(@nCarTaskID)) + ' не привязано к рейсу...'
		return
	end

	set @dDateConfirm = GetDate()
end
else begin		-- сброс подтверждения задания
	if	@dDateConfirm is Null begin 
		select	@nError = -5, 
				@cErrorText = 'Задание с кодом ' + ltrim(str(@nCarTaskID)) + ' еще не подтверждено...'
		return
	end
	if	@nTripID is not Null begin 
		select	@nError = -6, 
				@cErrorText = 'Задание с кодом ' + ltrim(str(@nCarTaskID)) + ' привязано к рейсу...'
		return
	end

	set @dDateConfirm = Null
	set @nUserConfirmID = Null
end

begin transaction
	update CarsTasks 
		set DateConfirm = @dDateConfirm, UserConfirmID = @nUserConfirmID 
		where ID = @nCarTaskID
	set @nError = @@Error
	if @nError > 0 goto ERR

commit transaction
return

ERR:
rollback transaction
return