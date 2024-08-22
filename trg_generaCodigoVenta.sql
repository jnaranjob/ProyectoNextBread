CREATE SEQUENCE seq_CodigoVenta
    START WITH 1
    INCREMENT BY 1;
GO

CREATE TRIGGER trg_GeneraCodigoVenta
ON CajaRegistradora
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @CodigoVenta NVARCHAR(20);
    DECLARE @currentDateTime NVARCHAR(14);
    DECLARE @nextValue INT;
    
    -- Inserta la fecha en este formato 'YYYYMMDDHHMMSS'
    SET @currentDateTime = CONVERT(VARCHAR, GETDATE(), 112) + 
                           RIGHT('0' + CONVERT(VARCHAR, DATEPART(HOUR, GETDATE())), 2) + 
                           RIGHT('0' + CONVERT(VARCHAR, DATEPART(MINUTE, GETDATE())), 2) + 
                           RIGHT('0' + CONVERT(VARCHAR, DATEPART(SECOND, GETDATE())), 2);
    
    -- Obtiene valor de la secuencia
    SET @nextValue = NEXT VALUE FOR seq_CodigoVenta;
    SET @CodigoVenta = @currentDateTime + RIGHT('0000' + CONVERT(VARCHAR, @nextValue), 4);

    -- Inserta el registro con el CodigoVenta generado y la fecha actual
    INSERT INTO CajaRegistradora (CodigoVenta, FechaCompra, IdTipoPago, CompraFinal, IdUsuario)
    SELECT @CodigoVenta, GETDATE(), IdTipoPago, CompraFinal, IdUsuario
    FROM inserted;

    -- Insertar el CodigoVenta en la tabla temporal
    INSERT INTO TempCodigoVenta (CodigoVenta) VALUES (@CodigoVenta);
END;


SELECT * FROM CajaRegistradora