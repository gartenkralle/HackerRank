Declare @Start int;
Set @Start = 1;

While(@Start <= 20)
Begin
    Print Replicate('* ', @Start);
    Set @Start = @Start + 1;
End
