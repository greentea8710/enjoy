namespace AdminAPI.Models
{
    public class User
    {


        public short A {  get; set; }
        public ushort B { get; set; }


        public int Id { get; set; }
        public int? Id1 { get; set; } = null;

        public uint IdX { get; set; }

        public long LongV { get; set; }
        public ulong LongA { get; set; }


        public string Name { get; set; }
        public string? Namw1 { get; set; }


        public bool BoolA { get; set; }


        public Guid Gid { get; set; }


        public float Fa {get;set; }


        public double Dx { get; set; }


        public decimal Ds { get; set; }


        public DateTime D1 { get; set; }


        public DateTimeOffset DateTimeOffset2 { get; set; }


        public DateOnly DateOnly { get; set; }


        public TimeOnly TimeOnly { get; set; }


        public TimeSpan Time { get; set; }
    }
}
