methods _key = new methods();


Console.WriteLine(_key.FullName("Trevor", "Stuart"));

string first = "Taylor";
string last = "Dickens";

string fullName = _key.FullName(last, first);

Console.WriteLine(fullName);
public class methods
{
    // int x = ExplainMethod(3); //Variables must have the same datatype as the mothod's return type.
    public void ExplainMethod(int x) 
    {
       
        // Method Body
        Console.WriteLine("Public is the access modifier.");
        Console.WriteLine("Void is the return type.");
        Console.WriteLine("ExplainMethod is the name");
        Console.WriteLine("int x is the Parameter");
        Console.WriteLine("Name + Params = signature");
    }



    public string FullName(string first, string last)
    {
        return $"{first} {last}";
    }

}

