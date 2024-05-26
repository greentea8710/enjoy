
using AdminAPI.Libraries;
namespace AdminAPI
{
    public class Program
    {
        /// <summary>
        /// main接收了一個類型為String的參數，名字叫args(arguments的縮寫，"參數"的意思)
        /// args的作用是，在程序啟動時，獲得用戶給程序傳入的數據
        /// void:空白
        /// void:空白
        /// </summary>
        ///<param name="args"></param>
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            int[] y1 = new int[7];
            y1[0] = 102;
            y1[1] = 503;
            y1[2] = 30;
            y1[3] = 900;
            y1[4] = 80;
            y1[5] = 300;
            y1[6] = 503;
            Console.WriteLine(string.Join(",", y1));

            Array.Sort(y1);
            Console.WriteLine(string.Join(",", y1));
            /////////////////////////////////////////////////////////////////////////////////////
            List<int> ss = y1.ToList();
            ss = ss.Distinct().OrderBy(t=>t).ToList();
            Console.WriteLine(string.Join(",", ss));

            ss = ss.Distinct().OrderByDescending(t=>t).ToList();
            Console.WriteLine(string.Join(",", ss));

            /////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("輸入成績:");
            //int score = Convert.ToInt32(Console.ReadLine());

            //if (score >= 80)
            //{
            //    Console.WriteLine("甲等");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("乙等");
            //}
            //else
            //{
            //    Console.WriteLine("不及格");
            //}
            //============================================================================================
            StudyHelper2 studyHelper25 = new();
            List<int> h = [102, 503, 30, 900, 80, 300, 420, 600];
            h.ForEach(item =>
            {
                var zxc = studyHelper25.IsOddNumber(item) ? "奇" : "偶";
                Console.WriteLine($"{item}是{zxc}數");
            });
            /////
            foreach (var item in h)
            {
                var zxc = studyHelper25.IsOddNumber(item) ? "奇" : "偶";
                Console.WriteLine($"{item}是{zxc}數");
            }
            /////
            for (int i = 0; i < h.Count; i++)
            {
                var zxc = studyHelper25.IsOddNumber(h[i]) ? "奇" : "偶";
                Console.WriteLine($"{h[i]}是{zxc}數");
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////
            int[] y = [10, 11, 12, 13, 14];

            foreach (var item in y)
            {
                var zxc = studyHelper25.IsOddNumber(item) ? "奇" : "偶";
                Console.WriteLine($"{item}是{zxc}數");
            }

            for (int i = 0; i < y.Length; i++)
            {
                var zxc = studyHelper25.IsOddNumber(y[i]) ? "奇" : "偶";
                Console.WriteLine($"{y[i]}是{zxc}數");
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("從多少?");
            //int fromwhere = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("到多少?");
            //int towhere = Convert.ToInt32(Console.ReadLine());

            //while (fromwhere < towhere)
            //{
            //    var zxc = studyHelper25.IsOddNumber(fromwhere) ? "奇" : "偶";
            //    Console.WriteLine($"{fromwhere}是{zxc}數");
            //    var def = studyHelper25.Isthree(fromwhere) ? "是" : "不是";
            //    Console.WriteLine($"{fromwhere}{def}三的倍數");

            //    fromwhere++;
            //}



            //do
            //{
            //    var zxc = studyHelper25.IsOddNumber(fromwhere) ? "奇" : "偶";
            //    Console.WriteLine($"{fromwhere}是{zxc}數");
            //    var def = studyHelper25.Isthree(fromwhere) ? "是" : "不是";
            //    Console.WriteLine($"{fromwhere}{def}三的倍數");

            //    fromwhere++;

            //} while (fromwhere < towhere);
            ///////////////////////////////////////////////////////////////////////////////////////////////////

            //for (int qq = fromwhere; qq < towhere; qq++)
            //{

            //    TRy rr = new(qq);//????????????
            //    var zxc = rr.OddNum() ? "奇" : "偶";
            //    var def = rr.xthree() ? "是" : "不是";
            //}
            //new()放在迴圈裡面會跑很久，要放在外面(呼叫一次就好)
            //============================================================================================
            int s1 = 101;
            TRy rr1 = new(s1);

            var zxc1 = rr1.OddNum() ? "奇" : "偶";
            Console.WriteLine($"{s1}是一個{zxc1}數");

            var def1 = rr1.xthree() ? "是" : "不是";
            Console.WriteLine($"{s1}{def1}三的倍數");
            //============================================================================================
            int xs = 61;
            StudyHelper studyHelper = new(xs);
            var three = studyHelper.Isthree();
            string abc = studyHelper.IsOddNumber() ? "奇" : "偶";
            Console.WriteLine($"{xs}是一个{abc}数");
            if (three)
            {
                Console.WriteLine($"{xs}是三的倍數");
            }
            else
            {
                Console.WriteLine($"{xs}不是三的倍數");
            }
            //============================================================================================

            //int x = 91;
            //StudyHelper2 studyHelper2 = new();
            //var sxs2 = studyHelper2.IsOddNumber(x);
            //var sxs3 = studyHelper2.IsOddNumber(33);
            //var sxs4 = studyHelper2.IsOddNumber(59);
            //var three2 = studyHelper2.Isthree(x);

            //StudyHelper3.IsOddNumber(x);
            //StudyHelper3.Isthree(x);
            //if (sxs2)
            //{
            //    Console.WriteLine($"{x}是一个奇数");
            //}
            //else
            //{
            //    Console.WriteLine($"{x}是一个偶数");
            //}

            //if (three2)
            //{
            //    Console.WriteLine($"{x}是三的倍數");
            //}
            //else
            //{
            //    Console.WriteLine($"{x}不是三的倍數");
            //}

            //======================================================================================

            ////int i = 1;
            ////i = 16 % 2;
            ////Console.WriteLine($"int:{i}");
            ////Console = 控制台

            //short j = 3;
            //j = (short)(j + 5);
            //Console.WriteLine($"short:{j}");

            ////ushort k = 2555;
            ////k = 3 - 3;
            ////Console.WriteLine($"ushort:{k}");

            //long hf = 36666666666666;
            //hf = hf + 5;
            //Console.WriteLine($"long:{hf}");

            ////string ps = "123你好asd";
            ////ps = ps + 5;
            ////ps = ps + "e";
            ////Console.WriteLine($"string:{s}");

            //double ed = 17;
            //ed = ed / 2;
            //Console.WriteLine($"double:{ed}");

            //Guid u = Guid.NewGuid();
            //Console.WriteLine($"Guid : {u}");

            //DateTime dateTime = DateTime.Now;
            //DateOnly dol = DateOnly.FromDateTime(dateTime);
            //Console.WriteLine($"DateOnly{dol}");
            //TimeOnly qw = TimeOnly.FromDateTime(dateTime);

            //Console.WriteLine($"TimeOnly{qw}");
            //DateTime dateTime1 = DateTime.Now.AddMinutes(10);
            //TimeSpan ts = dateTime1 - dateTime;
            //ts = TimeSpan.FromHours(70);
            //Console.WriteLine($"TimeSpan{ts}");
            //Console.WriteLine($"DateTime : {dateTime.ToString("yyyy年MM月dd日 HH:mm:ss")}");

            //DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
            //Console.WriteLine($"DataTimeOffset.{dateTimeOffset}");

            //bool q = false;
            //q = true;
            //Console.WriteLine($"bool {q}");
            //==================================================================================================
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
