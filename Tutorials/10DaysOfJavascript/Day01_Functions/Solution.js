function factorial(number)
{
    number = Number(number);

    if (number == 1)
        return 1;

    return number * factorial(number - 1);
}
