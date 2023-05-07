namespace IteratorPattern.Iterator
{
    public class LanguagesIterator : IIterator
    {
        private Dictionary<string,string> Subjects;
        private int position;

        public LanguagesIterator(Dictionary<string,string> subjects)
        {
            this.Subjects = subjects;
            position = 0;
        }
        public void First()
        {
            position = 0;
        }

        public string Next()
        {
            return Subjects.ElementAt(position++).Value;
        }

        public bool IsDone()
        {
            if (position < Subjects.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string CurrentItem()
        {
            return Subjects.ElementAt(position).Value;
        }
    }
}