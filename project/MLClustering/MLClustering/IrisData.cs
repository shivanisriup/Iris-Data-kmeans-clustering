using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML.Data;


namespace MLClustering
{
    public class IrisData
    {
        [LoadColumn(0)]
        public float sepal_length;

        [LoadColumn(1)]
        public float sepal_width;

        [LoadColumn(2)]
        public float petal_length;

        [LoadColumn(3)]
        public float petal_width;
    }

    public class ClusterPrediction
    {
        [ColumnName("PredictedLabel")]
        public uint PredictedClusterId;

        [ColumnName("Score")]
        public float[] Distances;
    }
}
