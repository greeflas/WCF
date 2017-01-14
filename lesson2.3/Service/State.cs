namespace Service
{
    class State
    {
        const int ARRAY_SIZE = 1000000;

        int[] array = new int[ARRAY_SIZE];

        public State()
        {
            for (int i = 0; i < ARRAY_SIZE; i++)
                array[i] = i;
        }

        public string GetState()
        {
            return array.Length.ToString();
        }
    }
}
