/* Dil Prasad Kunwar
 * Kathmandu, Nepal
 * Email:samir_k2002@yahoo.com
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextClustering.Lib
{
    /// <summary>
    /// Prepares cluster center using K-Means clustering algorithm 
    /// in n-dimensional vector space
    /// Document similarity is measured using cosine similarity
    /// </summary>
    public static class DocumnetClustering
    {

        private static int globalCounter = 0;
        private static int counter;
        /// <summary>
        /// Prepares the document cluster, Grouping of similar 
        /// type of text document is done here
        /// </summary>
        /// <param name="k">initial cluster center</param>
        /// <param name="documentCollection">document corpus</param>
        /// <returns></returns>


        public static List<Centroid> PrepareDocumentCluster(int k, List<DocumentVector> documentCollection,ref int _counter)
        {
            globalCounter = 0;
            //prepares k initial centroid and assign one object randomly to each centroid
            List<Centroid> centroidCollection = new List<Centroid>();
            Centroid c;
            
            /*
             * Avoid repeation of random number, if same no is generated more than once same document is added to the next cluster 
             * so avoid it using HasSet collection
             */
            HashSet<int> uniqRand = new HashSet<int>();
            GenerateRandomNumber(ref uniqRand,k,documentCollection.Count);
            
            foreach(int pos in uniqRand) 
            {
                c = new Centroid();                
                c.GroupedDocument = new List<DocumentVector>();
                c.GroupedDocument.Add(documentCollection[pos]);
                centroidCollection.Add(c);                
            }

            Boolean stoppingCriteria;
            List<Centroid> resultSet;
            List<Centroid> prevClusterCenter;
            
            InitializeClusterCentroid(out resultSet, centroidCollection.Count);

            do
            {
                prevClusterCenter = centroidCollection;

                foreach (DocumentVector obj in documentCollection)
                {
                    int index = FindClosestClusterCenter(centroidCollection, obj);
                    resultSet[index].GroupedDocument.Add(obj);
                }
                InitializeClusterCentroid(out centroidCollection, centroidCollection.Count());
                centroidCollection = CalculateMeanPoints(resultSet);
                stoppingCriteria = CheckStoppingCriteria(prevClusterCenter, centroidCollection);
                if (!stoppingCriteria)
                {   
                    //initialize the result set for next iteration
                    InitializeClusterCentroid(out resultSet, centroidCollection.Count);
                }


            } while (stoppingCriteria == false);

            _counter = counter;
            return resultSet;

        }

        /// <summary>
        /// Generates unique random numbers and also ensures the generated random number 
        /// lies with in a range of total no. of document
        /// </summary>
        /// <param name="uniqRand"></param>
        /// <param name="k"></param>
        /// <param name="docCount"></param>
 
        private static void GenerateRandomNumber(ref HashSet<int> uniqRand, int k, int docCount)
        {
            
            Random r = new Random();
            
            if (k > docCount)
            {
                do
                {
                    int pos = r.Next(0, docCount);
                    uniqRand.Add(pos);

                } while (uniqRand.Count != docCount);
            }            
            else
            {
                do
                {
                    int pos = r.Next(0, docCount);
                    uniqRand.Add(pos);

                } while (uniqRand.Count != k);
            }
        }

        /// <summary>
        /// Initialize the result cluster centroid for the next iteration, that holds the result to be returned
        /// </summary>
        /// <param name="centroid"></param>
        /// <param name="count"></param>
        private static void InitializeClusterCentroid(out List<Centroid> centroid,int count)
        {
            Centroid c;
            centroid = new List<Centroid>();
            for (int i = 0; i < count; i++)
            {
                c = new Centroid();
                c.GroupedDocument = new List<DocumentVector>();
                centroid.Add(c);
            }

        }

        /// <summary>
        /// Check the stopping criteria for the iteration, if centroid do not move their position it meets the criteria
        /// or if the global counter exist its predefined limit(minimum iteration threshold) than iteration terminates
        /// </summary>
        /// <param name="prevClusterCenter"></param>
        /// <param name="newClusterCenter"></param>
        /// <returns></returns>
        private static Boolean CheckStoppingCriteria(List<Centroid> prevClusterCenter, List<Centroid> newClusterCenter)
        {
            
            globalCounter++;
            counter = globalCounter;
            if (globalCounter > 11000)
            {
                return true;
            }
           
            else
            {
                Boolean stoppingCriteria;
                int[] changeIndex = new int[newClusterCenter.Count()]; //1 = centroid has moved 0 == centroid do not moved its position
                
                int index = 0;
                do
                {
                    int count = 0;
                    if (newClusterCenter[index].GroupedDocument.Count == 0 && prevClusterCenter[index].GroupedDocument.Count == 0)
                    {
                        index++;
                    }
                    else if (newClusterCenter[index].GroupedDocument.Count != 0 && prevClusterCenter[index].GroupedDocument.Count != 0)
                    {
                        for (int j = 0; j < newClusterCenter[index].GroupedDocument[0].VectorSpace.Count(); j++)
                        {
                            //
                            if (newClusterCenter[index].GroupedDocument[0].VectorSpace[j] == prevClusterCenter[index].GroupedDocument[0].VectorSpace[j])
                            {
                                count++;
                            }

                        }

                        if (count == newClusterCenter[index].GroupedDocument[0].VectorSpace.Count())
                        {
                            changeIndex[index] = 0;
                        }
                        else
                        {
                            changeIndex[index] = 1;
                        }
                        index++;
                    }
                    else
                    {
                        index++;
                        continue;
                        
                    }
                  

                } while (index < newClusterCenter.Count());

                // if index list contains 1 stopping criteria is set to flase
                if (changeIndex.Where(s => (s != 0)).Select(r => r).Any())
                {
                    stoppingCriteria = false;
                }
                else
                    stoppingCriteria = true;

                return stoppingCriteria;
            }
            
            
        }

        //returns index of closest cluster centroid
        private static int FindClosestClusterCenter(List<Centroid> clusterCenter,DocumentVector obj)
        {
           
            float[] similarityMeasure = new float[clusterCenter.Count()];

            for (int i = 0; i < clusterCenter.Count(); i++)
            {

                similarityMeasure[i] = SimilarityMatrics.FindCosineSimilarity(clusterCenter[i].GroupedDocument[0].VectorSpace, obj.VectorSpace); 
                
            }

            int index = 0;
            float maxValue = similarityMeasure[0];
            for (int i = 0; i < similarityMeasure.Count(); i++)
            {
                //if document is similar assign the document to the lowest index cluster center to avoid the long loop
                if (similarityMeasure[i] >maxValue)
                {
                    maxValue = similarityMeasure[i];
                    index = i;

                }
            }
            return index;
                
        }

        //Reposition the centroid
        private static List<Centroid> CalculateMeanPoints(List<Centroid> _clusterCenter)
        {
            
            for (int i = 0; i < _clusterCenter.Count(); i++)
            {
                
                if (_clusterCenter[i].GroupedDocument.Count() > 0)
                {
                    
                    for (int j = 0; j < _clusterCenter[i].GroupedDocument[0].VectorSpace.Count(); j++)
                    {
                        float total = 0;
                        
                        foreach (DocumentVector vSpace in _clusterCenter[i].GroupedDocument)
                        {

                            total += vSpace.VectorSpace[j];
                           
                        }
                       
                        //reassign new calculated mean on each cluster center, It indicates the reposition of centroid
                        _clusterCenter[i].GroupedDocument[0].VectorSpace[j] = total / _clusterCenter[i].GroupedDocument.Count();
                       
                    }
                   
                }

            }
          
            return _clusterCenter;

        }
        /// <summary>
        /// Find Residual sum of squares it measures how well a cluster centroid represents the member of their cluster
        /// We can use the RSS value as stopping criteria of k-means algorithm when decreses in RSS value falls below a 
        /// threshold t for small t we can terminate the algorithm.
        /// </summary>
        private static void FindRSS(List<Centroid> newCentroid, List<Centroid> _clusterCenter) 
        {
            //TODO:
        }
       
    }
   
}
