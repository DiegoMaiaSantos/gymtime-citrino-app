namespace gymtime_citrino_app.Models
{
    public class TimeTableModel : BaseModel
    {
        public DateTime Time { get; set; }
        public int MaximumCapacity { get; set; } = 4;
    }
}
