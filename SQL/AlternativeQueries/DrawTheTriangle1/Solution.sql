Declare @Start int;
Set @Start = 20;

While(@Start > 0)
Begin
    Print Replicate('* ', @Start);
    Set @Start = @Start - 1;
End
