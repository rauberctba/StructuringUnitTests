Structuring Unit Tests

===



### C# + xUnit Sample



A small sample of how I organize my unit tests. This is the same approach used by Phil Haack.


To run tests from the command line, use the following.

```Shell
# Restore NuGet packages
dnu restore

# Run tests in current directory
dnx test

# Run tests if tests are not in the current directory
dnx -p path/to/test/project test
```