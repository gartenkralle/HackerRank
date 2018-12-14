#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <assert.h>

#define MAX_CHARACTERS 1005
#define MAX_PARAGRAPHS 5

char *add_char(char *_word, char character)
{
    static int size;

    if (_word == NULL)
    {
        size = 0;
        _word = (char *)malloc(0);
    }

    _word = (char *)realloc(_word, (size + 1) * sizeof(char));
    _word[size] = character;
    _word[size + 1] = 0;

    size++;

    return _word;
}

char **add_word(char **_sentence, char *_word)
{
    int static size;

    if (_sentence == NULL)
    {
        size = 0;
        _sentence = (char **)malloc(0);
    }

    _sentence = (char **)realloc(_sentence, (size + 1) * sizeof(char *));
    _sentence[size] = _word;
    _word = NULL;

    size++;

    return _sentence;
}

char ***add_sentence(char ***_paragraph, char **_sentence)
{
    int static size;

    if (_paragraph == NULL)
    {
        size = 0;
        _paragraph = (char ***)malloc(0);
    }

    _paragraph = (char ***)realloc(_paragraph, (size + 1) * sizeof(char **));
    _paragraph[size] = _sentence;
    _sentence = NULL;

    size++;

    return _paragraph;
}

char ****add_paragraph(char ****_document, char ***_paragraph)
{
    int static size;

    if (_document == NULL)
    {
        size = 0;
        _document = (char ****)malloc(0);
    }

    _document = (char ****)realloc(_document, (size + 1) * sizeof(char ***));
    _document[size] = _paragraph;
    _paragraph = NULL;

    size++;

    return _document;
}

char* kth_word_in_mth_sentence_of_nth_paragraph(char**** document, int k, int m, int n)
{
    return document[n - 1][m - 1][k - 1];
}

char** kth_sentence_in_mth_paragraph(char**** document, int k, int m)
{
    return document[m - 1][k - 1];
}

char*** kth_paragraph(char**** document, int k)
{
    return document[k - 1];
}

char**** get_document(char* text)
{
    char **** _document = NULL;
    char *** _paragraph = NULL;
    char ** _sentence = NULL;
    char *_word = NULL;

    for (unsigned int i = 0; i <= strlen(text); i++)
    {
        switch (text[i])
        {
        case ' ':
            _sentence = add_word(_sentence, _word);
            _word = NULL;
            break;

        case '.':
            _sentence = add_word(_sentence, _word);
            _word = NULL;

            _paragraph = add_sentence(_paragraph, _sentence);
            _sentence = NULL;
            break;

        case '\n':
        case '\0':
            _document = add_paragraph(_document, _paragraph);
            _paragraph = NULL;
            break;

        default:
            _word = add_char(_word, text[i]);
            break;
        }
    }

    return _document;
}


char* get_input_text()
{
    int paragraph_count;
    scanf("%d", &paragraph_count);

    char p[MAX_PARAGRAPHS][MAX_CHARACTERS], doc[MAX_CHARACTERS];
    memset(doc, 0, sizeof(doc));
    getchar();

    for (int i = 0; i < paragraph_count; i++)
    {
        scanf("%[^\n]%*c", p[i]);
        strcat(doc, p[i]);

        if (i != paragraph_count - 1)
            strcat(doc, "\n");
    }

    char* returnDoc = (char*)malloc((strlen(doc) + 1) * (sizeof(char)));
    strcpy(returnDoc, doc);

    return returnDoc;
}

void print_word(char* word)
{
    printf("%s", word);
}

void print_sentence(char** sentence)
{
    int word_count;
    scanf("%d", &word_count);

    for (int i = 0; i < word_count; i++)
    {
        printf("%s", sentence[i]);

        if (i != word_count - 1)
            printf(" ");
    }
}

void print_paragraph(char*** paragraph)
{
    int sentence_count;
    scanf("%d", &sentence_count);

    for (int i = 0; i < sentence_count; i++)
    {
        print_sentence(*(paragraph + i));
        printf(".");
    }
}

int main()
{
    char* text = get_input_text();
    char**** document = get_document(text);

    int q;
    scanf("%d", &q);

    while (q--)
    {
        int type;
        scanf("%d", &type);

        if (type == 3)
        {
            int k, m, n;
            scanf("%d %d %d", &k, &m, &n);
            char* word = kth_word_in_mth_sentence_of_nth_paragraph(document, k, m, n);
            print_word(word);
        }

        else if (type == 2)
        {
            int k, m;
            scanf("%d %d", &k, &m);
            char** sentence = kth_sentence_in_mth_paragraph(document, k, m);
            print_sentence(sentence);
        }

        else
        {
            int k;
            scanf("%d", &k);
            char*** paragraph = kth_paragraph(document, k);
            print_paragraph(paragraph);
        }

        printf("\n");
    }
}
