/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            /* Indexers provide a natural syntax for accessing elements in
             a class or struct that encapsulate a list or dictionary of values. 
             Indexers are similar to properties, but are accessed via an 
             index argument rather than a property name. The string class has 
             an indexer that lets you access each of its char values via an int index: */

            string s = "hello";
            Console.WriteLine(s[0]);    // h
            Console.WriteLine(s[3]);    // l

            /* The syntax for using indexers is like that for using arrays, except that 
             the index argument(s) can be of any type(s). 
             
               Indexers have the same modifiers as properties, and can be called null-
             conditionally by inserting a question mark before the square bracket:  */

            string n = null;
            Console.WriteLine(n?[0]);   // Writes nothing; no error.

            // Here's how we could use the indexer below:

            Sentence S = new Sentence();
            Console.WriteLine(S[3]);        // fox
            S[3] = "kangaroo";
            Console.WriteLine(S[3]);        // kangaroo
        }
    }
    /* To write an indexer, define a property called this, specifying the 
     arguments in square brackets. For instance: */

    class Sentence
    {
        string[] words = "The quick brown fox".Split();
        public string this [int wordNum]    // Indexer
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
            /* If you omit the set accessor, an indexer becomes read-only, and
            expression-bodied syntax may be used in C# 6 to shorten its definition:
            
            public string this [int wordNum] => words [wordNum]; */
        }
    }
    /* An type may declare multiple indexers, each with parameters of different
     types. An indexer can also take more than one parameter: 
        
    public string this [int arg1, string arg2]
    {
    get { ... } set { ... }
    } */
}
