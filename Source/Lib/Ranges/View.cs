namespace Ranges
{
    public static class View
    {
        public static int[] Ints(uint count)
        {
            var range = new int[count];

            for (int i = 0; i < count; ++i)
                range[i] = i + 1;

            return range;
        }
    }
}
