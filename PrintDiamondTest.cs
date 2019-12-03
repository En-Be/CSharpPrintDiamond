using NUnit.Framework;
using System;

public class PrintDiamond
{
    [Test]
    public void returnsListOfStrings()
    {
        Diamond diamond = new Diamond('A');
        Assert.That(diamond.Lines, Is.All.InstanceOf<String>());
    }
    
    [Test]
    public void correctNumberOfLines()
    {
        Diamond diamondA = new Diamond('A');
        Assert.That(diamondA.Lines, Has.Exactly(1).Items);
        Diamond diamondB = new Diamond('B');
        Assert.That(diamondB.Lines, Has.Exactly(3).Items);
        Diamond diamondJ = new Diamond('J');
        Assert.That(diamondJ.Lines, Has.Exactly(19).Items);
    }
    
    [Test]
    public void lineLength()
    {
        Diamond diamond = new Diamond('C');
        Assert.AreEqual(5, diamond.Lines[0].Length);
    }
    
    [Test]
    public void lineEndings()
    {
        char smallDiamond = 'C';
        Diamond Sdiamond = new Diamond(smallDiamond);
        Assert.That(Sdiamond.lines[0], Does.StartWith(" "));
        Assert.That(Sdiamond.lines[0], Does.EndWith(" "));
        Assert.That(Sdiamond.lines[1], Does.StartWith(" "));
        Assert.That(Sdiamond.lines[1], Does.EndWith(" "));
        Assert.That(Sdiamond.lines[Sdiamond.lines.Count/2], Does.StartWith(char.ToString(smallDiamond)));
        Assert.That(Sdiamond.lines[Sdiamond.lines.Count/2], Does.EndWith(char.ToString(smallDiamond)));
        
        char largeDiamond = 'X';
        Diamond Ldiamond = new Diamond(largeDiamond);
        Assert.That(Ldiamond.lines[0], Does.StartWith(" "));
        Assert.That(Ldiamond.lines[0], Does.EndWith(" "));
        Assert.That(Ldiamond.lines[1], Does.StartWith(" "));
        Assert.That(Ldiamond.lines[1], Does.EndWith(" "));
        Assert.That(Ldiamond.lines[Ldiamond.lines.Count/2], Does.StartWith(char.ToString(largeDiamond)));
        Assert.That(Ldiamond.lines[Ldiamond.lines.Count/2], Does.EndWith(char.ToString(largeDiamond)));
    }
}
