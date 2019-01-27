select
    case
        when (A + B > C) and (A + C > B) and (B + C > A)
        then
            case 
                when (A = B) and (B = C) then 'Equilateral'
                when (A = B) or (B = C) or (A = C) then 'Isosceles'
                when (A != B) and (B != C) and (A != C) then 'Scalene'
            end
        else
            'Not A Triangle'
    end

from Triangles;
