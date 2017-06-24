Declare @minLen int
Declare @maxLen int

Select @minLen = Min(Len(City)) From Station
Select @maxLen = Max(Len(City)) From Station

Select Top 1 City, @minLen From Station Where Len(City) = @minLen Order By City ASC
Select Top 1 City, @maxLen From Station Where Len(City) = @maxLen Order By City ASC
