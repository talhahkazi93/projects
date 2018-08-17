Create Procedure AddPartsToInventory

@PartNo varchar(100),
@StoreId int,
@Qty int

AS

BEGIN

Declare @CheckExistance int
SET @CheckExistance = (Select COUNT(*) FROM Inventory WHERE PartNo = @PartNo AND StoreId = @StoreId);

IF (@CheckExistance > 0)
	BEGIN
	 Update Inventory SET Qty = (Qty+@Qty) WHERE PartNo = @PartNo AND StoreId = @StoreId;
	END

ELSE
	BEGIN
		INSERT INTO Inventory(PartNo,StoreId,Qty) VALUES (@PartNo,@StoreId,@Qty)
	END
	
END

GO

CREATE PROCEDURE InsertDebt
@DealDate as smalldatetime,
@Total as money,
@Payed as money,
@PartyId as int,
@LastPaymentDate as smalldatetime

AS
DECLARE @DebtId  int

BEGIN

INSERT INTO Debt(DealDate, Total,Payed, PartyId, LastPaymentDate) VALUES  
(@DealDate, @Total, @Payed, @PartyId, @LastPaymentDate);

SET @DebtId = (Select SCOPE_IDENTITY())

SELECT @DebtId

END
GO

Create Procedure ShiftPartsToInventory

@ShiftFrom varchar(50),
@PartNo varchar(100),
@ShiftTo varchar(50),
@Qty int

AS

DECLARE @ErrorCode int

SET @ErrorCode = @@error

BEGIN TRANSACTION

IF ( @ErrorCode = 0 )

BEGIN

Declare @CheckExistance int
SET @CheckExistance = (Select COUNT(*) FROM Inventory WHERE PartNo = @PartNo AND StoreId = (Select Id FROM Store WHERE Name = @ShiftTo));

IF (@CheckExistance > 0)
	BEGIN
	 UPDATE Inventory SET Qty = (Qty+@Qty) WHERE PartNo = @PartNo AND StoreId = (Select Id FROM Store WHERE Name = @ShiftTo);
	 UPDATE Inventory SET Qty = (Qty-@Qty) WHERE PartNo = @PartNo and StoreId = (Select Id FROM Store WHERE Name = @ShiftFrom);
	END

ELSE
	BEGIN
		INSERT INTO Inventory(PartNo,StoreId,Qty) VALUES (@PartNo,(Select Id FROM Store WHERE Name = @ShiftTo),@Qty);
		UPDATE Inventory SET Qty = (Qty-@Qty) WHERE PartNo = @PartNo and StoreId = (Select Id FROM Store WHERE Name = @ShiftFrom);
	END
	


SET @ErrorCode = @@error

END

IF ( @ErrorCode = 0 )
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION