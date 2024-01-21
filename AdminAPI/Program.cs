
namespace AdminAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            i = 17 % 2;
            Console.WriteLine($"int:{i}");

            short j = 3;
            j = (short)(j +5);
            Console.WriteLine($"short:{j}");

            ushort k= 2555;
            k = 3 -3;
            Console.WriteLine($"ushort:{k}");


            long f = 36666666666666;
            f = f +5 ;
            Console.WriteLine($"long:{f}");

            string s = "123你好asd";
            s =s+5 ;
            s = s + "e";
            Console.WriteLine($"string:{s}");


            double d = 17;
            d = d / 2;
            Console.WriteLine($"double:{d}");

            Guid u = Guid.NewGuid();
            Console.WriteLine($"Guid : {u}");

            DateTime dateTime = DateTime.Now;

            DateOnly dol = DateOnly.FromDateTime(dateTime);
            Console.WriteLine($"DateOnly{dol}");

            TimeOnly qw = TimeOnly.FromDateTime(dateTime);

      

            Console.WriteLine($"TimeOnly{qw}");
            DateTime dateTime1 = DateTime.Now.AddMinutes(10);
            TimeSpan ts = dateTime1 - dateTime;

            ts = TimeSpan.FromHours(70);
            Console.WriteLine($"TimeSpan{ts}");

            Console.WriteLine($"DateTime : {dateTime.ToString("yyyy年MM月dd日 HH:mm:ss")}");


            DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
            Console.WriteLine($"DataTimeOffset.{dateTimeOffset}");

          
            bool q = false;
            q = true;
            Console.WriteLine($"bool {q}");








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
