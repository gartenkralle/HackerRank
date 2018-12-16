class Polygon {

    constructor(lengths) {
        this.lengths = lengths;
    }

    perimeter()
    {
        var perimeter = 0;

        for (var length of this.lengths) {
            perimeter += length;
        }

        return perimeter;
    }
}
