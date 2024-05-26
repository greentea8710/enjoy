namespace AdminAPI.Libraries
{
    public static class StudyHelper3
    {

        /// <summary>
        /// 判斷是否為奇數
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsOddNumber(int number)
        {
            //若傳入數字為奇數則為true
            return number % 2 == 1;
        }


        public static bool Isthree(int number)
        {
            return number % 3 == 0;
        }

        //public bool IsOdd(int number) => number % 2 == 1;

    }
}
