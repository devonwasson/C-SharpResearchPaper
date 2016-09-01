/*

token delimiters?

strings can be split using the .Split operation.
an example of this in action is shown below.

source: https://msdn.microsoft.com/en-us/library/ms228388.aspx

*/

using System;

public class q50{

  public static void Main(){
    char[] deliminatingChars = {' '};
    string text = "Hello world and all who inhabit it.";
    string[] words = text.Split(deliminatingChars); //makes an array of tokens
    for (int i = 0; i < words.Length; i++){
      Console.WriteLine(words[i]); //write each token in the string.
    }
  }

}
