namespace Pr8
{
    class MyArray
    {
        private int[] Arr;

        public MyArray(int size)
        {
            Arr = new int[size];
            FillArrayWithRandomNumbers();
        }

        private void FillArrayWithRandomNumbers()
        {

            foreach (int index in Enumerable.Range(0, Arr.Length))
            {
                Arr[index] = new Random().Next(-10, 10);
            }
        }
        public static string operator ~(MyArray arr)
        {
            return "{ " + string.Join(", ", arr.Arr) + " }";
        }
        public static MyArray operator ++(MyArray arr)
        {
            Array.Resize(ref arr.Arr, arr.Arr.Length + 1);
            return arr;
        }
        public static MyArray operator --(MyArray arr)
        {
            Array.Resize(ref arr.Arr, arr.Arr.Length - 1);
            return arr;
        }
        public static MyArray operator +(MyArray arr1, MyArray arr2)
        {
            int originalLength = arr1.Arr.Length;
            Array.Resize(ref arr1.Arr, originalLength + arr2.Arr.Length);
            Array.Copy(arr2.Arr, 0, arr1.Arr, originalLength, arr2.Arr.Length);
            return arr1;
        }
        public static MyArray operator +(int num, MyArray arr)
        {
            Array.Resize(ref arr.Arr, arr.Arr.Length + 1);
            Array.Copy(arr.Arr, 0, arr.Arr, 0 + 1, arr.Arr.Length - 0 - 1);
            arr.Arr[0] = num;
            return arr;
        }
        public static MyArray operator +(MyArray arr, int num)
        {
            Array.Resize(ref arr.Arr, arr.Arr.Length + 1);
            arr.Arr[arr.Arr.Length-1] = num;
            return arr;
        }
    }
}