# Isomorphic Strings Algorithm

This code contains an algorithm to determine whether two given strings are isomorphic or not. 

## What is Isomorphic Strings?

Two strings are said to be isomorphic if the characters in string `s` can be replaced to get string `t`. For example, `"egg"` and `"add"` are isomorphic because we can replace `"e"` with `"a"` and `"g"` with `"d"`. Similarly, `"paper"` and `"title"` are also isomorphic because we can replace `"p"` with `"t"`, `"a"` with `"i"`, `"e"` with `"l"`, and `"r"` with `"e"`.

## How does the algorithm work?

The algorithm uses a two-step approach to determine whether two strings `s` and `t` are isomorphic or not:

1. The algorithm creates a "code" string for both `s` and `t`. The "code" string is created by assigning an integer to each character in `s` that indicates the index of the character in `s` or `t`. For example, if `s = "egg"` and `t = "add"`, then the "code" string for `s` would be `"011"` and the "code" string for `t` would be `"011"`.
2. The algorithm checks whether the "code" string for `s` is equal to the "code" string for `t`. If they are equal, then `s` and `t` are isomorphic; otherwise, they are not.

To create the "code" string for `s` and `t`, the algorithm uses two dictionaries `mapS` and `mapT`, and a StringBuilder `sb`. For each character `cS` in `s`, the algorithm checks whether `cS` has already appeared in `s` before. If `cS` has not appeared in `s` before, the algorithm assigns the index of `cS` in `s` to the dictionary `mapS`. Similarly, for each character `cT` in `t`, the algorithm checks whether `cT` has already appeared in `t` before. If `cT` has not appeared in `t` before, the algorithm assigns the index of `cT` in `t` to the dictionary `mapT`. Finally, the algorithm appends the indexes of `cS` and `cT` to the StringBuilder `sb`. 

## How to use the algorithm?

To use the algorithm, call the `IsIsomorphic(string s, string t)` method of the `IsomorphicStrings` class and pass the two strings `s` and `t` as arguments. The method returns a boolean value that indicates whether `s` and `t` are isomorphic or not.

```csharp
IsomorphicStrings isM = new IsomorphicStrings();
bool areIsomorphic = isM.IsIsomorphic("egg", "add"); // true
```

## Conclusion

The Isomorphic Strings algorithm is a useful tool for checking whether two strings are isomorphic or not. It works by creating a "code" string for the two strings and checking whether the two "code" strings are equal. The algorithm is easy to use and can be integrated into any C# program that requires isomorphic string checking.
