USE [FlexMoneyDB]
GO
/****** Object:  StoredProcedure [dbo].[AllMemberReport]    Script Date: 3/31/2023 1:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AllMemberReport]
AS
BEGIN
    SELECT m.Name,
		SUM(CASE WHEN t.CallerId = ml.MemberId and t.Position = ml.Position THEN t.Earn ELSE 0 END) AS Earn, 
		SUM(CASE WHEN t.CallerId <> ml.MemberId AND ml.DeadSection = 0 THEN mo.Money - t.Call
				WHEN t.CallerId <> ml.MemberId AND ml.DeadSection<> t.Section THEN mo.Money ELSE 0 END) AS Pay,
		SUM(CASE WHEN t.CallerId = ml.MemberId AND t.Position = ml.Position THEN t.ThankMoney ELSE 0 END) AS ThankMoney,
		SUM(CASE WHEN t.Alive IS NULL THEN 0 ELSE t.Alive END) As Alive, 
		SUM(CASE WHEN t.CallerId = ml.MemberId AND t.Position = ml.Position THEN t.Dead ELSE 0 END) AS Dead
	FROM Members m
	JOIN MemberLines ml ON m.Id = ml.MemberId
	JOIN MoneyLines mo ON mo.Id = ml.LineId
	LEFT JOIN Transactions t ON mo.Id = t.LineId
	GROUP BY m.Name;
END
GO
/****** Object:  StoredProcedure [dbo].[GetTotalThankMoneyByLineId]    Script Date: 3/31/2023 1:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetTotalThankMoneyByLineId]
    @LineId INT
AS
BEGIN
    SELECT s.Section, t.TotalThankMoney
FROM (
  SELECT TOP 1 Section
  FROM Transactions
  WHERE LineId = @LineId
  ORDER BY CreatedDate DESC
) s
CROSS JOIN (
  SELECT SUM(ThankMoney) AS TotalThankMoney
  FROM Transactions
  WHERE LineId = @LineId
) t
END
GO
/****** Object:  StoredProcedure [dbo].[GetTransactionInfoByLineId]    Script Date: 3/31/2023 1:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetTransactionInfoByLineId]
    @LineId INT
AS
BEGIN
    SELECT m.Id, Name, j.Position
    FROM Members m
    JOIN
    (SELECT MemberId, Position
     FROM MemberLines
     WHERE LineId = @LineId
     EXCEPT
     SELECT CallerId, Position
     FROM Transactions
     WHERE LineId = @LineId) j on m.Id = j.MemberId
END
GO
/****** Object:  StoredProcedure [dbo].[SingleMemberReport]    Script Date: 3/31/2023 1:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SingleMemberReport]
    @Memberid INT
AS
BEGIN
     SELECT ml.LineId, 
       ml.MemberId,
	   m.CreatedDate,
	   m.Name,
	   m.currentSection,
       SUM(CASE WHEN t.CallerId = ml.MemberId AND t.Section = ml.DeadSection THEN t.Earn ELSE 0 END) AS Earn, 
       SUM(CASE WHEN t.CallerId <> ml.MemberId AND ml.DeadSection = 0
	   THEN m.Money - t.Call
	   WHEN t.CallerId <> ml.MemberId AND ml.DeadSection<> t.Section
	   THEN m.Money
	   ELSE
	   0 END) AS Pay
FROM   MemberLines ml 
       JOIN Transactions t 
         ON ml.LineId = t.LineId 
       JOIN MoneyLines m 
         ON ml.LineId = m.Id 
       JOIN Members me 
         ON t.CallerId = me.Id 
WHERE  ml.MemberId = @Memberid
GROUP  BY ml.LineId,
m.CreatedDate,
m.Name,
m.currentSection,
          ml.MemberId
HAVING SUM(CASE WHEN t.CallerId = ml.MemberId AND t.Section = ml.DeadSection THEN t.Earn ELSE 0 END) > 0 OR
       SUM(CASE WHEN t.CallerId <> ml.MemberId 
	   THEN m.Money - t.Call
	   WHEN t.CallerId <> ml.MemberId AND ml.DeadSection> t.Section
	   THEN m.Money
	   ELSE
	   0 END) > 0;

END
GO
/****** Object:  StoredProcedure [dbo].[ThankMoneyReport]    Script Date: 3/31/2023 1:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ThankMoneyReport]
    @Ownerid INT
AS
BEGIN
    SELECT m.CreatedDate, m.Name, m.Quantity, m.currentSection, 
		SUM(CASE WHEN t.ThankMoney Is NULL THEN 0 ELSE t.ThankMoney END) AS ThankMoney 
	FROM MoneyLines m
	LEFT JOIN Transactions t on m.Id = t.LineId 
	WHERE OwnerId = @Ownerid
	GROUP BY m.CreatedDate, m.Name, m.Quantity, m.currentSection;
END
GO
