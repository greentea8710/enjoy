namespace AdminAPI.Libraries
{
    public class TRy(int numb)
    {

    /// <summary>
    /// 判斷是否為奇數
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
        public bool OddNum()
        {   //若傳入數字為奇數則為true
        return numb % 2 == 1;
        }


        public bool xthree()
        {
            return numb % 3 == 0;
        }
    }
}