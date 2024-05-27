CREATE TRIGGER after_member_update
ON Members
AFTER UPDATE
AS
BEGIN
    -- Update the MonthlySavings value in the Savings table
    UPDATE Savings
    SET Savings.MonthlySavings = inserted.MonthlySavings
    FROM Savings
    INNER JOIN inserted ON Savings.PFNo = inserted.MemberPFNo;
END;
