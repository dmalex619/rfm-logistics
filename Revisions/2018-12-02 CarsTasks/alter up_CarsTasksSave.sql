SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_CarsTasksSave]
	@nCarTaskID			int = 0 output, 
	@dDateTask			smalldatetime, 
	@nPartnerID			int, 
	@cDeliveryAddress	varchar(max), 
	@nZoneID			int, 
	@nLatitude			decimal(12,6), 
	@nLongitude			decimal(12,6), 
	@nDistance			int, 
	@nNetto				decimal(9,1), 
	@nBrutto			decimal(9,1), 
	@nPalletsQnt		decimal(9,2), 
	@nTaskInnerCost		money, 
	@nTaskOuterCost		money, 
	@nCarTaskUnitID		int, 
	@nUnitsQnt			decimal(12,3), 
	@nPrice				money, 
	@bIsCash			bit, 
	@cNote				varchar(max), 
	@nUserIndentID		int, 
	@nError				int = 0 output, 
	@cErrorText			varchar(200) = '' output
AS

set nocount on

-- Проверка параметров
if IsNull(@nCarTaskID, 0) <> 0 and 
		not exists (select ID from CarsTasks with (nolock) where ID = @nCarTaskID) begin
	select	@nError = -1, 
			@cErrorText = 'Не найдено задание с кодом ' + ltrim(str(@nCarTaskID)) + '...'
	return
end

-- Изменение от 02.12.2018, Александров
-- По просьбе Головкина снята проверка на старые даты
/*
if @dDateTask is Null or @dDateTask < dateadd(Day, -3, getdate()) begin
	select	@nError = -2, 
			@cErrorText = 'Слишком старая или неизвестная дата задания с кодом ' + ltrim(str(@nCarTaskID)) + '...'
	return
end
*/
if @nPartnerID is Null begin
	select	@nError = -3, 
			@cErrorText = 'Неизвестный парнтнер для задания с кодом ' + ltrim(str(@nCarTaskID)) + '...'
	return
end

-- Сохранение данных
begin transaction
	if IsNull(@nCarTaskID, 0) = 0 begin
		insert CarsTasks (DateTask, PartnerID, DeliveryAddress, 
				ZoneID, Latitude, Longitude, Distance, 
				Netto, Brutto, PalletsQnt, 
				TaskInnerCost, TaskOuterCost, 
				CarTaskUnitID, UnitsQnt, Price, IsCash, 
				Note, DateIndent, UserIndentID) 
			values (@dDateTask, @nPartnerID, @cDeliveryAddress, 
				@nZoneID, @nLatitude, @nLongitude, @nDistance, 
				@nNetto, @nBrutto, @nPalletsQnt, 
				@nTaskInnerCost, @nTaskOuterCost, 
				@nCarTaskUnitID, @nUnitsQnt, @nPrice, @bIsCash, 
				@cNote, getdate(), @nUserIndentID)
		select @nCarTaskID = @@Identity, @nError = @@Error
		if @nError <> 0 goto ERR
	end
	else begin
		update CarsTasks set 
				DateTask = @dDateTask, PartnerID = @nPartnerID, DeliveryAddress = @cDeliveryAddress, 
				ZoneID = @nZoneID, Latitude = @nLatitude, Longitude = @nLongitude, Distance = @nDistance, 
				Netto = @nNetto, Brutto = @nBrutto, PalletsQnt = @nPalletsQnt, 
				TaskInnerCost = @nTaskInnerCost, TaskOuterCost = @nTaskOuterCost, 
				CarTaskUnitID = @nCarTaskUnitID, UnitsQnt = @nUnitsQnt, Price = @nPrice, IsCash = @bIsCash, 
				Note = @cNote 
			where ID = @nCarTaskID
		set	@nError = @@Error
		if @nError <> 0 goto ERR
	end

commit transaction
return

ERR:
rollback transaction
return