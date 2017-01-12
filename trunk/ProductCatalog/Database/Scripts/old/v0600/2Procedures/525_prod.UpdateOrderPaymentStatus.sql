IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[prod].[UpdateOrderPaymentStatus]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [prod].[UpdateOrderPaymentStatus]
GO

CREATE procedure [prod].[UpdateOrderPaymentStatus] 
	@OrderId int
 	,@PaymentStatus int  	
 	,@UpdatedUserId nvarchar(255)
 	,@ClientId nvarchar(255) = null
 	,@MissingOrderId int OUTPUT as
BEGIN

if (@OrderId is null)
begin
	RAISERROR (N'@OrderId is null', 17, 1);
	RETURN
end

if (@ClientId is not null)
begin
	if (NOT EXISTS (SELECT 1 FROM [prod].[Orders] o 
	                WHERE @ClientId = o.ClientId
					  AND (@OrderId is not null and Id = @OrderId)))
	begin
		DECLARE @mess nvarchar(300) = N'Client ' + @ClientId + ' is not owner of order'
		RAISERROR (@mess, 17, 1);
		RETURN
	end
end

declare @targetOrderId int
set @targetOrderId = (select top 1 Id from prod.Orders where Id = @OrderId)

if(@targetOrderId is null)
begin
	set @MissingOrderId = @OrderId
end
else
begin
	set @MissingOrderId = NULL
end

UPDATE [prod].[Orders]
set     
	 [PaymentStatus] = @PaymentStatus
	,[StatusChangedDate] = getdate()
	,[StatusUtcChangedDate] = GETUTCDATE()
	,[UpdatedUserId] = @UpdatedUserId
where
(@OrderId is not null and Id = @OrderId)

END


GO

