# First non repeating letter

## Takes a string input, and returns the first character that is not repeated anywhere in the string.

For example, if given the input 'stress', the function should return "t", since the letter t only occurs once in the string, and occurs first in the string.

Upper and lowercase letters are considered the same character, but the program returns the correct case for the initial letter. For example, the input 'sTreSS' returns "T".

If a string contains all repeating characters, it returns an empty string "".

### How to run:

- Clone the repo
- Inside the root directory of the project, run the program with a string of letters:

    ```
    dotnet run aabBcdd
    ```

- To see the test coverage, run:

    ```
    dotnet test
    ```
---

### Extension

If I were to spend more time on this, I would test drive the development of:

- Refactoring