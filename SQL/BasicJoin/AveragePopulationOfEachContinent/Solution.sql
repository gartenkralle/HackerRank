Select Continent, Avg(City.Population) From Country Inner Join City On Country.Code = City.Countrycode Group By Continent;
