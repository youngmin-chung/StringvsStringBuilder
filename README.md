## StringvsStringBuilder
C# | String vs StringBuilder

### Test elapsed time between String and StringBuilder
* TestString();
* TestStringBuilder();

### Compare String and StringBuilder
* cancat1(String s1): In this method, we are passing a string “Chung” and performing “s1 = String.Concat(s1, st);” where st is “Youngmin ” to be concatenated. The string passed from Main() is not changed, this is due to the fact that String is immutable. Altering the value of string creates another object and s1 in concat1() stores reference of the new string. But the references s1 in Main() and concat1() refer to different strings.
* concat2(String s2): In this method, we are passing a string “Chung” and performing “s2.Append(“Youngmin ”)” which changes the actual value of the string (in Main) to “Youngmin ”. This is due to the simple fact that StringBuilder is mutable and hence changes its value.
* When to use which one:
<br>If a string is going to remain constant throughout the program, then use String class object because a String object is immutable.
<br>If a string can change (example: lots of logic and operations in the construction of the string) then using a StringBuilder is the best option.
