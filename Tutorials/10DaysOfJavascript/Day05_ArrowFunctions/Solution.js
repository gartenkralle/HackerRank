function modifyArray(nums) 
{
    let result = [];

    for(let num of nums)
    {
        if(isEven(num))
        {
            result.push(2 * num);
        }
        else
        {
            result.push(3 * num);
        }
    }

    return result;   
}

function isEven(num)
{
    return num % 2 == 0;
}
