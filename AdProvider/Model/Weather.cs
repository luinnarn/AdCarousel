namespace AdProvider.Model
{
    public class Weather
    {
        public Weather(float temperature)
        {
            Temperature = temperature;
        }

        public float Temperature { get; }
    }
}
