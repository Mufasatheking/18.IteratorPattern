using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregate
{
    public class Languages : ISubjects
    {
        private Dictionary<string,string> Subjects;
        public Languages()
        {
            Subjects = new Dictionary<string, string>
            {
                {"South Korea","Korean"},
                {"Germany","German"},
                {"France","French"},
                {"China","Chinese"},
            };
        }
        public IIterator CreateIterator()
        {
            return new LanguagesIterator(Subjects);
        }
    }
}