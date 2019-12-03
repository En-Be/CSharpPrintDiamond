using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Diamond diamond = new Diamond(Convert.ToChar(args[0]));
    }
}

public class Diamond
{
    public List<string> lines = new List<string>();
    
    public Diamond(char midLetter)
    {
        makeLines(midLetter);
        if(lines.Count > 1)
        {
            fillLines();
            appendBottomLines();      
        }
        
        Console.WriteLine();
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine();
    }
    
    public List<string> Lines
    {
        get { return this.lines; }
    }
    
    public void makeLines(char midLetter)
    {
        for(char letter = 'A'; letter <= midLetter; letter++)
        {
            lines.Add(char.ToString(letter));
        }
    }
    
    public void fillLines()
    {
        for(int line = 0; line < lines.Count; line++)
        {
            string completeLine = lines[line];
            int totalSpaces = lines.Count + lines.Count - 2;
            
            if(line == 0)
            {
                totalSpaces -= 1;
                for(int s = 0; s <= totalSpaces / 2; s++)
                {
                    completeLine = string.Concat(" ", completeLine, " ");
                }
            }
            else
            {
                string midSpaces = " ";
                string endSpaces = "";
                for(int s = 0; s < (totalSpaces / 2) - line; s++)
                {
                    endSpaces += " ";
                }

                for(int s = 1; s < totalSpaces - (totalSpaces - line); s++)
                {
                    midSpaces += "  ";
                }
                completeLine = string.Concat(endSpaces, completeLine, midSpaces, completeLine, endSpaces);
            }
            
            lines[line] = completeLine;
        }

    }
    
    public void appendBottomLines()
    {
        for(int i = lines.Count - 2; i >= 0; i--)
        {
            this.lines.Add(lines[i]);
        }
    }
}
