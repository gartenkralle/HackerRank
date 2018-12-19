SELECT
    convert(decimal(10, 2), round(sum(Lat_n), 2)),
    convert(decimal(10, 2), round(sum(Long_w), 2))
FROM Station;
