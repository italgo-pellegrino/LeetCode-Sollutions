# Longest Common Prefix

This program implements two algorithms for finding the longest common prefix of an array of strings: vertical scanning and horizontal scanning.
## Vertical Scanning Algorithm

The vertical scanning algorithm is implemented in the lCPVertical method. It takes an array of strings strs as input and returns the longest common prefix as a string.

This algorithm first checks if the first string in the array is empty, if so, it returns an empty string. It then iterates over the characters of the first string and compares them with the corresponding characters in the other strings. If a mismatch is found, it returns the prefix found so far. Otherwise, it appends the matching character to the prefix and continues the iteration.
## Horizontal Scanning Algorithm

The horizontal scanning algorithm is implemented in the lCPHorizontal method. It takes an array of strings strs as input and returns the longest common prefix as a string.

This algorithm first checks if the input array is null or empty, if so, it returns an empty string. It initializes the prefix to the first string in the array and iterates over the remaining strings, repeatedly removing the last character from the prefix until it is a prefix of the current string. If the prefix becomes empty, it returns an empty string. Otherwise, it returns the prefix.
