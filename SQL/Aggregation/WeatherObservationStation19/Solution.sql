Select 
Format(
Sqrt(
Power([Max LAT] - [Min LAT], 2) + 
Power([Max LONG] - [Min LONG], 2)), 
'N4') 
From (Select Min(LAT_N) as [Min LAT], Min(LONG_W) as [Min LONG], Max(LAT_N) as [Max LAT], Max(LONG_W) as [Max LONG] FROM Station) 
as Station;
