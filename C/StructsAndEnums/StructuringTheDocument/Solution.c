typedef struct word word;
typedef struct sentence sentence;
typedef struct paragraph paragraph;
typedef struct document document;

void add_char(word* _word, char character)
{
    static int size;

    if (_word->data == NULL)
    {
        _word->data = (char*)malloc(0);
        size = 2;
    }

    _word->data = (char*)realloc(_word->data, size * sizeof(char));
    _word->data[size - 2] = character;
    _word->data[size - 1] = 0;

    size++;
}

void add_word(sentence* _sentence, word* _word)
{
    if (_sentence->data == NULL)
    {
        _sentence->data = (word*)malloc(0);
        _sentence->word_count = 0;
    }

    _sentence->word_count++;
    _sentence->data = (word*)realloc(_sentence->data, _sentence->word_count * sizeof(word));
    _sentence->data[_sentence->word_count - 1] = *_word;
    _word->data = NULL;
}

void add_sentence(paragraph* _paragraph, sentence* _sentence)
{
    if (_paragraph->data == NULL)
    {
        _paragraph->data = (sentence*)malloc(0);
        _paragraph->sentence_count = 0;
    }

    _paragraph->sentence_count++;
    _paragraph->data = (sentence*)realloc(_paragraph->data, _paragraph->sentence_count * sizeof(sentence));
    _paragraph->data[_paragraph->sentence_count - 1] = *_sentence;
    _sentence->data = NULL;
}

void add_paragraph(document* _document, paragraph* _paragraph)
{
    if (_document->data == NULL)
    {
        _document->data = (paragraph*)malloc(0);
        _document->paragraph_count = 0;
    }

    _document->paragraph_count++;
    _document->data = (paragraph*)realloc(_document->data, _document->paragraph_count * sizeof(paragraph));
    _document->data[_document->paragraph_count - 1] = *_paragraph;
    _paragraph->data = NULL;
}

struct document get_document(char* text)
{
    document _document;
    paragraph _paragraph;
    sentence _sentence;
    word _word;

    _document.data = NULL;
    _paragraph.data = NULL;
    _sentence.data = NULL;
    _word.data = NULL;

    for (unsigned int i = 0; i <= strlen(text); i++)
    {
        switch (text[i])
        {
        case ' ':
            add_word(&_sentence, &_word);
            break;

        case '.':
            add_word(&_sentence, &_word);
            add_sentence(&_paragraph, &_sentence);
            break;

        case '\n':
        case '\0':
            add_paragraph(&_document, &_paragraph);
            break;

        default:
            add_char(&_word, text[i]);
            break;
        }
    }

    return _document;
}

struct word kth_word_in_mth_sentence_of_nth_paragraph(struct document Doc, int k, int m, int n)
{
    return Doc.data[n - 1].data[m - 1].data[k - 1];
}

struct sentence kth_sentence_in_mth_paragraph(struct document Doc, int k, int m)
{
    return Doc.data[m - 1].data[k - 1];
}

struct paragraph kth_paragraph(struct document Doc, int k)
{
    return Doc.data[k - 1];
}
