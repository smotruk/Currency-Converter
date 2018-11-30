namespace konverter1
{
    
    internal class Converter 
    {
        public double Convert(double amount, double fromRate, double toRate)
        {
            return fromRate / toRate * amount;
        }
    }
}