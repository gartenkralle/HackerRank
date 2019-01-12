Declare @MaximumTotalEarning int;

Set @MaximumTotalEarning =
(
  Select Top 1 Earnings 
  From (Select months*salary as [Earnings] From Employee) as Employee 
  Group By Earnings Order By Earnings Desc
);

Select @MaximumTotalEarning, (Select Count(employee_id) From Employee Where months*salary = @MaximumTotalEarning);
