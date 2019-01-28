select Doctor, Professor, Singer, Actor
from (select ROW_NUMBER() over (partition by Occupation order by [Name]) 'Row', [Name], Occupation from Occupations) temp
pivot
(
	max([Name])
	for Occupation
	in (Doctor, Professor, Singer, Actor)
) piv
