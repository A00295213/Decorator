

using System;

class Program 
{
    static void Main (string[] args)
    {
        ConcreteComponent concreateComponent = new ConcreateComponent();
        PlainDecorator plainDecorator = new PlainDecorator();
        UppercaseDecorator uppercaseDecorator = new UppercaseDecorator();
        ColorDecorator colorDecorator = new ColorDecorator();


        Console.WriteLine("Original String:" +concreateComponent.GetText());
        Console.WriteLine("Plain decorator:" +plainDecorator.GetText());
        Console.WriteLine("Upper case Decorator:" +uppercaseDecorator.GetText());
        Console.WriteLine("Color Decorator:" +colorDecorator.GetText());
    }
}
