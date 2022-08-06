namespace EcoHub.Helpers
{
    using System.Globalization;
    using System.Text;
    public class OrderNumberGenerator
    {
        public async Task<string> GenerateOrderNumber()
        {
            var todaysDate = DateTime.Now;//.ToString("M/d/yyyy");
            CultureInfo ci = CultureInfo.InvariantCulture;
            var currentTime = todaysDate.ToString("hh-mm-ss", ci);

            int stringLength = 3;
            Random randomCharacter = new Random();
            string dictionaryString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder resultStringBuilder = new StringBuilder();
            StringBuilder randomString = new StringBuilder();

            for (int i = 0; i < stringLength; i++)
            {
                int randomCharSelected = randomCharacter.Next(0, (dictionaryString.Length - 1));

                randomString.Append(dictionaryString[randomCharSelected]);
            }

            return currentTime + randomString;
        }
    }
}
