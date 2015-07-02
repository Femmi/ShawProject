namespace DataLayer.Model
{
    public class CityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Num { get; set; }
        public int PollsReported { get; set; }
        public int PollsTotal { get; set; }
        public ResultModel[] Results { get; set; }
    }
}
