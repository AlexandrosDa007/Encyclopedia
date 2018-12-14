using Encyclopedia.fooDataSetTableAdapters;
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
using System.Threading.Tasks;


namespace Encyclopedia.Controller
{
    class Search
    {
        //static variable for directory -- holding in memory
        public static RAMDirectory directory;
        //static dataset of fooDataSet object -- reference to our data set
        public static fooDataSet dataSet;
        //static adapter for our dataset -- used to fill all data in the dataSet object
        public static LemmaTableAdapter adapter;


        /*
         * Static method for Creating Index or Directory 
         * The Lucene Engine analyzes the documents
         * And makes an index table -- IN MEMORY
         * TODO: Get similarity working
         */
        public static void CreateIndex()
        {
            //initialize all static components
            directory = new RAMDirectory();
            dataSet = new fooDataSet();
            adapter = new LemmaTableAdapter();

            //Analyzer object used to analyze text based search
            Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            //Writer object used to write the directory or the "Index"
            IndexWriter writer = new IndexWriter(directory, analyzer, new IndexWriter.MaxFieldLength(1000));

            //Seting similarity -- Used to make the text based search retrive relavant
            //used in scoring system
            writer.SetSimilarity(new DefaultSimilarity());
            
            //Fill the dataSet with values
            adapter.Fill(dataSet.Lemma);

            //Iterate in dataset 
            foreach(fooDataSet.LemmaRow row in dataSet.Lemma.Rows)
            {
                
                //Use Lucene Document for assign fields
                Document document = new Document();

                //convert byte[] to string for lemma_body -- lemma_body is a byte[] cannot
                //use it like that
                string lemma_b = System.Text.Encoding.Default.GetString((Byte[])row["lemma_body"]);
                //Adding the fields in the document
                //Dont analyze category_id because it doesnt matter in the search
                document.Add(new Field("lemma_title", row["lemma_title"].ToString(), Field.Store.YES, Field.Index.ANALYZED));
                document.Add(new Field("lemma_body", lemma_b, Field.Store.YES, Field.Index.ANALYZED));
                document.Add(new Field("category_id", row["category_id"].ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));

                //add the documents in the writer
                writer.AddDocument(document);
                
            }
            
            //Closing the writer -- IF writer remains open the search cant be completed
            writer.Dispose();
            
        }

        /*
         * Static method: Search the index table by a string 
         * It analyzes the index table and retrieves 
         * data by searching lemma_body for the string
         * TODO: make similarity and relevance working
         */
        public static List<Document> DoSearch(string textSearch)
        {
            //The array-list of title strings for the matching results
            List<Document> list = new List<Document>();

            //The IndexReader reads the index table -- opens the directory(IN MEMORY)
            IndexReader reader = IndexReader.Open(directory, true);
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
            Query query = queryParser.Parse(textSearch);


            //TODO: Make parser to filter more relavant text
            //CODE BELLOW WORKS -- BUT WE DONT GET THE RESULT WE ARE LOOKING FOR
            TopScoreDocCollector collector = TopScoreDocCollector.Create(1000, true);
            searcher.Search(query,collector);
            ScoreDoc[] matches = collector.TopDocs().ScoreDocs;
            //CODE BELLOW WORKS -- BUT WE DONT GET THE RESULT WE ARE LOOKING FOR

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
