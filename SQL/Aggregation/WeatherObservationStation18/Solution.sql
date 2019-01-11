Select Format(([Max LAT] - [Min LAT]) + ([Max LONG] - [Min LONG]), 'N4') 
From (Select Min(LAT_N) as [Min LAT], Min(LONG_W) as [Min LONG], Max(LAT_N) as [Max LAT], Max(LONG_W) as [Max LONG] FROM Station) 
as Station;
