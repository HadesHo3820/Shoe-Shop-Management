CREATE TRIGGER QuantiType on Products
AFTER Update
AS
BEGIN
	declare @idProduct nvarchar(30), @quantity int, @IDProducType nvarchar(30)
	SELECT @idProduct = IDProduct from inserted

	
	--
     Select @IDProducType = (	select IDProductType
	from Products
	where IDProduct = @idProduct)
	--
	
	select @quantity= ( select SUM(Quantity) 
						from Products
						group by IDProductType
						having IDProductType = @IDProducType)
	Update ProductTypes set  Quantity =  @quantity
	where IDProductType = @IDProducType
END

CREATE TRIGGER QuantiLines on ProductTypes
AFTER Update
AS
BEGIN
	declare @idProductTypes nvarchar(30), @quantity int, @IDProducLines nvarchar(30)
	SELECT @idProductTypes = IDProductType from inserted

	
	--
     Select @IDProducLines = (	select IDProductlines
	from ProductTypes
	where IDProductType = @idProductTypes)
	--
	
	select @quantity= ( select SUM(Quantity) 
						from ProductTypes
						group by IDProductlines
						having IDProductlines = @IDProducLines)
	Update Productlines set  Quantity =  @quantity
	where IDProductlines = @IDProducLines
END



drop trigger QuantiType