namespace Subscriber.core.model
{
    public class CardModel
    {
        public int Id { get; set; }

        public double BMI { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public DateTime UpdateDate { get; set; }

        public CardModel()
        {

        }
        public CardModel(int id, double? bmi, double height, double weight, DateTime? updateDate)
        {
            Id = id;
            BMI = 0;
            Height = height;
            Weight = weight;
            UpdateDate = DateTime.Now;

        }
    }
}
