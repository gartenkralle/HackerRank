function getSecondLargest(nums) {
    var max = 0;
    var maxSecond = 0;

    for (let num of nums) {
        if (num > max) {
            maxSecond = max;
            max = num;
        }
        if (num < max && num > maxSecond) {
            maxSecond = num;
        }
    }

    return maxSecond;    
}
