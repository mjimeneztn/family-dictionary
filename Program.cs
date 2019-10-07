using System;
using System.Collections.Generic;

namespace family
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a Dictionary that contains information about several members of your family.
        var myFamily = new Dictionary<string, Dictionary<string, string>>();
        myFamily.Add("dad", new Dictionary<string, string>(){
            {"name", "Noel"},
            {"age", "50"}
        });
        myFamily.Add("mom", new Dictionary<string, string>(){
            {"name", "Maria"},
            {"age", "43"}
        });
        myFamily.Add("oldest sister", new Dictionary<string, string>(){
            {"name", "Diana"},
            {"age", "25"}
        });
        myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Isabella"},
            {"age", "19"}
        });
        myFamily.Add("brother", new Dictionary<string, string>(){
            {"name", "Noel"},
            {"age", "24"}
        });
        // Next, iterate over each item in myFamily and produce the following output. Remember that you can use square bracket notation to get to the value of a key, and that a dictionary has a Key and a Value property.
        foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
        {
            string name = familyMember.Value["name"];
            string age = familyMember.Value["age"];
            Console.WriteLine($"{name} is my {familyMember.Key} and is {age} years old.");
        }

        }

        }
    }

