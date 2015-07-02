namespace DataLayer.Model
{
    public class ResultModel
    {
        public string Name { get; set; }
        public int PartyId { get; set; }
        public int Votes { get; set; }
        public bool IsElected { get; set; }
        public string PartyCode { get; set; }
    }
}
