namespace AdProvider.Model
{
    internal class Weather
    {
        public Weather(float temperature)
        {
            Temperature = temperature;
        }

        public float Temperature { get; }
    }
}
