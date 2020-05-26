SET TRANSACTION ISOLATION LEVEL
READ UNCOMMITTED
BEGIN TRANSACTION MyTransaction
      BEGIN TRY
              UPDATE Account SET Debit=100 WHERE Name='John Cena'
              UPDATE ContactInformation SET Mobile='1234567890' WHERE Name='The Rock'
              COMMIT TRANSACTION MyTransaction
              PRINT 'TRANSACTION SUCCESS'
      END TRY
      BEGIN CATCH
              ROLLBACK TRANSACTION MyTransaction
              PRINT 'TRANSACTION FAILED'
      END CATCH

--------------------------------------------------------------------------------
SET TRANSACTION ISOLATION LEVEL
REPEATABLE READ
