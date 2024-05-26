namespace AdminAPI.Libraries
{
    public class StudyHelper(int number)
    {

        /// <summary>
        /// 判斷是否為奇數
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool IsOddNumber()
        {
            //若傳入數字為奇數則為true
            return number % 2 == 1;
        }


        public bool Isthree()
        {
            return number % 3 == 0;
        }

        //public bool IsOdd(int number) => number % 2 == 1;

    }
}
