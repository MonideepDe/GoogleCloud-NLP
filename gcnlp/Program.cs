using System;
using Google.Cloud.Language.V1;

namespace gcnlp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Text to analyze
            String text = "Hey there";
            var client = LanguageServiceClient.Create();
            var response = client.AnalyzeSentiment(new Document()
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            });
            var sentiment = response.DocumentSentiment;
            Console.WriteLine($"Score: {sentiment.Score}");
            Console.WriteLine($"Magnitude: {sentiment.Magnitude}");

        }
    }
}
