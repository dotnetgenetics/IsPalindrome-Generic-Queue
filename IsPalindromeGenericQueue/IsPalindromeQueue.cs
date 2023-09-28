namespace IsPalindromeGenericQueue
{
    public class IsPalindromeQueue
    {
        public bool IsPalindromic<T>(IEnumerable<T> inputSequence) where T : IComparable
        {
            Queue<T> buffer = new Queue<T>();
            foreach (T element in inputSequence)
            {
                buffer.Enqueue(element);
            }

            buffer = new Queue<T>(buffer.Reverse());
            for (int i = 0; i < inputSequence.Count(); i++)
            {
                if (buffer.Dequeue().CompareTo(inputSequence.ElementAt(i)) == 0)
                    continue;
                else
                    return false;
            }

            return true;
        }
    }
}
