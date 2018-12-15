function vowelsAndConsonants(s) {
    for (let c of s) {
        switch (c)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                console.log(c);
                break;
        }
    }

    for (let c of s) {
        switch (c) {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                break;

            default:
                console.log(c);
                break;
        }
    }
}
