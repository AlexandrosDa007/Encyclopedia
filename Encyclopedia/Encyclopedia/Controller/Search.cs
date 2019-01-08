using Encyclopedia.fooDataSetTableAdapters;
using Encyclopedia.Model;
using Lucene;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UI;

namespace Encyclopedia.Controller
{

    /// <summary>
    /// Has static variables to hold information for Lucene indexing.
    /// Also contains static functions for creating index and searching.
    /// </summary>
    public class Search
    {
        /// <summary>
        /// A static reference to the directory of the lucene index.
        /// </summary>
        public static SimpleFSDirectory dir;
        /// <summary>
        /// A static reference to the lemmas for indexing.
        /// </summary>
        public static List<Lemma> lemmaList;

        /// <summary>
        /// Static method for Creating Index or Directory 
        /// The Lucene Engine analyzes the documents
        /// And makes an index table -- In disk
        /// </summary>
        public static void CreateIndex()
        {
            //initialize all static components
            //directory = new RAMDirectory();
            lemmaList = new List<Lemma>();

            dir = new SimpleFSDirectory(new System.IO.DirectoryInfo("../../LuceneDocuments"), null);

            //Analyzer object used to analyze text based search
            Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            //Writer object used to write the directory or the "Index"
            IndexWriter writer = new IndexWriter(dir, analyzer, new IndexWriter.MaxFieldLength(1000));
            writer.DeleteAll();
            //Seting similarity -- Used to make the text based search retrive relavant
            //used in scoring system
            writer.SetSimilarity(new DefaultSimilarity());

            //get all Lemmas
            lemmaList = DBConnect.GetAllLemma();

            //Iterate in dataset 
            foreach(Lemma lemma in lemmaList)
            {
                
                //Use Lucene Document for assign fields
                Document document = new Document();

                //Adding the fields in the document
                //Dont analyze category_id because it doesnt matter in the search
                document.Add(new Field("lemma_title", lemma.Title, Field.Store.YES, Field.Index.ANALYZED));
                document.Add(new Field("lemma_body", Encoding.UTF8.GetString(Compression.DecompressLemmas(lemma.Body)), Field.Store.YES, Field.Index.ANALYZED));
                document.Add(new Field("category_id", lemma.Category.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));

                //add the documents in the writer
                writer.AddDocument(document);
                
            }
            
            //Closing the writer -- IF writer remains open the search cant be completed
            writer.Dispose();

        }

        /// <summary>
        /// Static method: Search the index table by a string 
        /// It analyzes the index table and retrieves data by searching lemma body for the string.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static List<Document> DoSearch(string text)
        {
            //string text = RemoveControlCharsFromString(textSearch);
            if (text == null || text == "" || text.Contains('\n') || text.Contains('\t') || text.Contains('\r') || text.Contains('\b'))
                return null;
            //The array-list of title strings for the matching results
            List<Document> list = new List<Document>();

            //The IndexReader reads the index table -- opens the directory(IN MEMORY)
            IndexReader reader = IndexReader.Open(dir, true);
            //The indexSearcher is used to search for matches
            IndexSearcher searcher = new IndexSearcher(reader);
            searcher.SetDefaultFieldSortScoring(true, false);
            //Similarity -- relevence
            searcher.Similarity = new DefaultSimilarity();
            //The analyzer -- Maybe it has something to do with the relevence
            StandardAnalyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

            //The queryParser defines which fields are to be used for the search
            MultiFieldQueryParser queryParser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30, new string[] {"lemma_body", "lemma_title"},analyzer);
            //True so we can use wildcards in the search *
            queryParser.AllowLeadingWildcard = true;
            //Used when searching now it matches results if the hit has one of the words 
            //example: "the house" will match only in text with both words
            queryParser.DefaultOperator = QueryParser.OR_OPERATOR;
            //A query is being created with the given text
            Query query;
            //may fail
            try
            {
                query = queryParser.Parse(text);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            


            TopScoreDocCollector collector = TopScoreDocCollector.Create(1000, true);
            searcher.Search(query,collector);
            ScoreDoc[] matches = collector.TopDocs().ScoreDocs;


            //Itereate in matches array 
            foreach (ScoreDoc item in matches)
            {
                
                int id = item.Doc;
                //search by id in the index table -- very fast
                Document doc = searcher.Doc(id);
                //We add the document to the list
                list.Add(doc);
                
            }

            //the list is always with order by score
            return list;
        }

    }
}
