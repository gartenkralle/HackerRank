SELECT 

Convert(
    int,
    CEILING(

        avg(
            Convert(
                float,
                Salary)
        )
        
        - 

        avg(
            Convert(
                float, 
                REPLACE(
                    Salary, 
                    '0',
                    ''
                )
            )
        )
    )
)

FROM Employees;
