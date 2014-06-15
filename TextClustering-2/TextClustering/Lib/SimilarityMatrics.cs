using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextClustering.Lib
{
    /// <summary>
    /// Calculates Term Frequency of each term in its corresponding document
    /// </summary>
    public class SimilarityMatrics
    {

        #region Cosine Similarity
        public static float FindCosineSimilarity(float[] vecA, float[] vecB)
        {
            var dotProduct = DotProduct(vecA, vecB);
            var magnitudeOfA = Magnitude(vecA);
            var magnitudeOfB = Magnitude(vecB);
            float result = dotProduct / (magnitudeOfA * magnitudeOfB);
            //when 0 is divided by 0 it shows result NaN so return 0 in such case.
            if (float.IsNaN(result))
                return 0;
            else
                return (float)result;
        }

#endregion

        public static float DotProduct(float[] vecA, float[] vecB)
        {

            float dotProduct = 0;
            for (var i = 0; i < vecA.Length; i++)
            {
                dotProduct += (vecA[i] * vecB[i]);
            }

            return dotProduct;
        }

        // Magnitude of the vector is the square root of the dot product of the vector with itself.
        public static float Magnitude(float[] vector)
        {
            return (float)Math.Sqrt(DotProduct(vector, vector));
        }



        #region Euclidean Distance
        //Computes the similarity between two documents as the distance between their point representations. Is translation invariant.
        public static float FindEuclideanDistance(int[] vecA, int[] vecB)
        {
            float euclideanDistance = 0;
            for (var i = 0; i < vecA.Length; i++)
            {
                euclideanDistance += (float)Math.Pow((vecA[i] - vecB[i]), 2);
            }

            return (float)Math.Sqrt(euclideanDistance);

        }
        #endregion

        #region Extended Jaccard
        //Combines properties of both cosine similarity and Euclidean distance
        public static float FindExtendedJaccard(float[] vecA, float[] vecB)
        {
            var dotProduct = DotProduct(vecA, vecB);
            var magnitudeOfA = Magnitude(vecA);
            var magnitudeOfB = Magnitude(vecB);

            return dotProduct / (magnitudeOfA + magnitudeOfB - dotProduct);

        }
        #endregion
        

    }
}
