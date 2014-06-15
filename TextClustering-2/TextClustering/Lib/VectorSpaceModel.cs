/* Dil Prasad Kunwar
 * Kathmandu, Nepal
 * Email:samir_k2002@yahoo.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace TextClustering.Lib
{
    /// <summary>
    /// Represents document collection in n-dimensional vector space, using Vector Space Model
    /// The two process carried out here are
    /// 1,Document Indexing
    /// 2,Term Weighting using TF-IDF
    /// </summary>
    class VectorSpaceModel
    {
        private static HashSet<string> distinctTerms;
        private static List<string> documentCollection;
        private static Regex r = new Regex("([ \\t{}()\",:;. \n])");

      /// <summary>
      /// Prepares a collection of document in vector space
      /// </summary>
      /// <param name="collection">Document collection/corpus</param>
      /// <returns>List of, document in vector space</returns>
        public static List<DocumentVector> ProcessDocumentCollection(DocumentCollection collection)
        {
            
            distinctTerms = new HashSet<string>();
            documentCollection = collection.DocumentList;
            
           /*
            * Finds out the total no of distinct terms in the whole corpus so that it will be easy  
            * to represent the document in the vector space. The dimension of the vector space will
            * be equal to the total no of distinct terms.
            * 
            */

            foreach (string documentContent in collection.DocumentList)
            {
                foreach (string term in r.Split(documentContent))
                {
                    if (!StopWordsHandler.IsStotpWord(term))
                        distinctTerms.Add(term);
                    else
                        continue;
                }
            }

            List<string> removeList = new List<string>(){"\"","\r","\n","(",")","[","]","{","}","","."," ",","};
            foreach (string s in removeList)
            {
                distinctTerms.Remove(s);
            }
            

            List<DocumentVector> documentVectorSpace = new List<DocumentVector>();
            DocumentVector _documentVector;
            float[] space;
            foreach (string document in documentCollection)
            {
                int count = 0;
                space = new float[distinctTerms.Count];
                foreach (string term in distinctTerms)
                {
                    space[count] = FindTFIDF(document,term);
                    count++;
                }
                _documentVector = new DocumentVector();
                _documentVector.Content = document;
                _documentVector.VectorSpace = space;
                documentVectorSpace.Add(_documentVector);

            }
            
            return documentVectorSpace;

        }
        #region Calculate TF-IDF

        //Calculates TF-IDF weight for each term t in document d
        private static float FindTFIDF(string document, string term)
        {
            float tf = FindTermFrequency(document, term);
            float idf = FindInverseDocumentFrequency(term);
            return tf * idf;
        }

        private static float FindTermFrequency(string document, string term)
        {

            int count = r.Split(document).Where(s => s.ToUpper() == term.ToUpper()).Count();
            //ratio of no of occurance of term t in document d to the total no of terms in the document
            return (float)((float)count / (float)(r.Split(document).Count()));
        }


        private static float FindInverseDocumentFrequency(string term)
        {
            //find the  no. of document that contains the term in whole document collection
            int count = documentCollection.ToArray().Where(s => r.Split(s.ToUpper()).ToArray().Contains(term.ToUpper())).Count();
            /*
             * log of the ratio of  total no of document in the collection to the no. of document containing the term
             * we can also use Math.Log(count/(1+documentCollection.Count)) to deal with divide by zero case; 
             */
            return (float)Math.Log((float)documentCollection.Count() / (float)count);

        }
        #endregion
    }
}
