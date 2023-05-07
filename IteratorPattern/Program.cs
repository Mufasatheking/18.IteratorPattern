using IteratorPattern.Aggregate;
using IteratorPattern.Iterator;

Console.WriteLine("***Iterator Pattern Demo***");
ISubjects ScienceSubjects = new Science();
ISubjects ArtsSubjects = new Arts();
ISubjects LanguagesSubjects = new Languages();
IIterator IteratorForScience = ScienceSubjects.CreateIterator();
IIterator IteratorForArts = ArtsSubjects.CreateIterator();
IIterator IteratorForLanguages = LanguagesSubjects.CreateIterator();
Console.WriteLine("\nScience subjects :");
Print(IteratorForScience);
Console.WriteLine("\nArts subjects :");
Print(IteratorForArts);
Console.WriteLine("\nLanguages subjects :");
Print(IteratorForLanguages);
Console.ReadLine();

void Print(IIterator iterator)
{
    while (!iterator.IsDone())
    {
        Console.WriteLine(iterator.Next());
    }
}