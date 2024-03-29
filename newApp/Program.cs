

using System;

class Program 
{
    static void Main (string[] args)
    {
        var concreateComponent = new ConcreateComponent();
        var plainDecorator = new PlainDecorator();
        var uppercaseDecorator = new UppercaseDecorator();
        var colorDecorator = new ColorDecorator();


        Console.WriteLine("Original String:" +concreateComponent.GetText());
        Console.WriteLine("Plain decorator:" +plainDecorator.GetText());
        Console.WriteLine("Upper case Decorator:" +uppercaseDecorator.GetText());
        Console.WriteLine("Color Decorator:" +colorDecorator.GetText());
    }
}
