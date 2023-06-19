using Microsoft.Extensions.ObjectPool;
using Microsoft.ML;

namespace Squad.ML.Engine
{
    public class PooledPredictionEnginePolicy<TData, TPrediction> : IPooledObjectPolicy<PredictionEngine<TData, TPrediction>>
                    where TData : class
                    where TPrediction : class, new()
    {
        private readonly MLContext _mlContext;
        private readonly ITransformer _model;
        public PooledPredictionEnginePolicy(MLContext mlContext, ITransformer model)
        {
            _mlContext = mlContext;
            _model = model;
        }

        public PredictionEngine<TData, TPrediction> Create()
        {
            // Measuring CreatePredictionengine() time
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var predictionEngine = _mlContext.Model.CreatePredictionEngine<TData, TPrediction>(_model);

            watch.Stop();
#pragma warning disable IDE0059 // Ненужное присваивание значения
            long elapsedMs = watch.ElapsedMilliseconds;
#pragma warning restore IDE0059 // Ненужное присваивание значения

            return predictionEngine;
        }

        public bool Return(PredictionEngine<TData, TPrediction> obj)
        {
            if (obj == null)
                return false;

            return true;
        }
    }
}
