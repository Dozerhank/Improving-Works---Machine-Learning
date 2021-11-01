using Microsoft.ML.Data;

namespace SpamDetector.DataStructures
{
    class SpamPrediction
    {
        [ColumnName("PredictedLabel")]
        public string isSpam { get; set; }
    }
}
