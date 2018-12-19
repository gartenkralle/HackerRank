SELECT sum(City.Population) FROM Country JOIN City ON Country.Code = City.CountryCode WHERE Continent = 'Asia';
