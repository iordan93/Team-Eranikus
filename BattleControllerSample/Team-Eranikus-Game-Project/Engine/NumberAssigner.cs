namespace Engine
{
    public static class NumberAssigner
    {
        private static int _nextNumber = 0;

        public static int GetNextNumber()
        {
            _nextNumber = (_nextNumber + 1);

            return _nextNumber;
        }
    }
}