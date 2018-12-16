function getCount(objects) {
    var count = 0;

    for (var object of objects)
    {
        if (object.x == object.y)
            count++;
    }

    return count;
}
