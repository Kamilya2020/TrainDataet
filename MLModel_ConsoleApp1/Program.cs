﻿
// This file was auto-generated by ML.NET Model Builder. 

using MLModel_ConsoleApp1;
using System.IO;

// Create single instance of sample data from first line of dataset for model input
var imageBytes = File.ReadAllBytes(@"C:\Users\LENOVO\Desktop\archive (1)\raw-img\cane\OIF-e2bexWrojgtQnAPPcUfOWQ.jpeg");
MLModel.ModelInput sampleData = new MLModel.ModelInput()
{
    ImageSource = imageBytes,
};

// Make a single prediction on the sample data and print results.
var predictionResult = MLModel.Predict(sampleData);
Console.WriteLine($"\n\nPredicted Label value: {predictionResult.PredictedLabel} \nPredicted Label scores: [{String.Join(",", predictionResult.Score)}]\n\n");
