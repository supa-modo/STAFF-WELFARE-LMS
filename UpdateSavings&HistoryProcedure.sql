CREATE PROCEDURE UpdateSavingsAndLogHistory
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @currentDateTime DATETIME = GETDATE();

    -- Create a temporary table to capture the output
    CREATE TABLE #TempOutput (
        MemberPFNo INT,
        TransactionDate DATE,
        MonthlySavings DECIMAL(10, 2),
        SavingsAccountBalance INT
    );

    -- Update SavingsAccountBalance and capture the output in the temporary table
    UPDATE Savings
    SET 
        SavingsAccountBalance = SavingsAccountBalance + MonthlySavings,
        LastUpdated = @currentDateTime
    OUTPUT
        inserted.PFNo,
        @currentDateTime,
        inserted.MonthlySavings,
        inserted.SavingsAccountBalance
    INTO
        #TempOutput;

    -- Insert records from the temporary table into SavingsHistory
    INSERT INTO SavingsHistory (PFNo, TransactionDate, Amount, BalanceAfterTransaction)
    SELECT MemberPFNo, TransactionDate, MonthlySavings, SavingsAccountBalance
    FROM #TempOutput;

    -- Drop the temporary table
    DROP TABLE #TempOutput;
END;
