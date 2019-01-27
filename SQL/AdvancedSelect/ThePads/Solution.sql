select [Name] + '(' + left(Occupation, 1) + ')' from Occupations order by [Name];

select 'There are a total of ' + convert(varchar(10), Count([Name])) + ' ' + lower(Occupation) + 's.' 
from Occupations group by Occupation order by Count([Name]), Occupation;
