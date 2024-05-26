namespace AdminAPI.Libraries
{
    public class StudyHelper2
    {

        /// <summary>
        /// 判斷是否為奇數
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool IsOddNumber(int number)
        {
            //若傳入數字為奇數則為true
            return number % 2 == 1;
        }


        public  void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // 交换元素  
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

                    Console.WriteLine(string.Join(",", array));
                }
            }
        }


        public bool Isthree(int number)
        {
            return number % 3 == 0;
        }

        //public bool IsOdd(int number) => number % 2 == 1;

    }
}
