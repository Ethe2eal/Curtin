using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Writing;
using VDS.RDF.Query;
using VDS.RDF.Query.Builder;

namespace SPARQLDemo
{
    public partial class SPARQLDemo : Form
    {
        public SPARQLDemo()
        {
            InitializeComponent();
            //load ontology into listbox
            ResetOntology();

        }
        public int flag;
        private void search_Click(object sender, EventArgs e)
        {
            string keyWord;
            keyWord = textBox1.Text;
            List<string> arr = new List<string>();
            ResetOntology();
            foreach (var item in this.resultBox.Items)
            {
                arr.Add(item.ToString());
            }
            resultBox.Items.Clear();
            for(int i=0;i<arr.Count;i++)
            {
                if (arr[i].ToLower().Contains(keyWord.ToLower()))
                {
                    resultBox.Items.Add(arr[i]);
                }
            }
            if (resultBox.Items.Count == 0)
            {
                MessageBox.Show("No item found\n You can give us feedback");
            }
        }
        public object Search(string a)
        {
            IGraph g = new Graph();
            g.LoadFromFile("DSRO.rdf");
            object results = g.ExecuteQuery("PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>"
                + "PREFIX owl: <http://www.w3.org/2002/07/owl#>"
                + "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>"
                + "PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>"
                + "PREFIX dsro: <http://www.semanticweb.org/zhang/ontologies/2018/8/DSR-ontology#>"
                + "SELECT ?x WHERE {  ?x rdfs:subClassOf  dsro:" + a + "}");
            return results;
        }
        public object InsertNewClass(string a)
        {
            IGraph g = new Graph();
            g.LoadFromFile("DSRO.rdf");
            object results = g.ExecuteQuery("PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>"
                + "PREFIX owl: <http://www.w3.org/2002/07/owl#>"
                + "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>"
                + "PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>"
                + "PREFIX dsro: <http://www.semanticweb.org/zhang/ontologies/2018/8/DSR-ontology#>"
                + "SELECT ?SubClassOfPerson WHERE {  ?SubClassOfPerson rdfs:subClassOf  dsro:" + a + "}");
            return results;
        }
        public object SuperClass(string a)
        {
            IGraph g = new Graph();
            g.LoadFromFile("DSRO.rdf");
            object results = g.ExecuteQuery("PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>"
                + "PREFIX owl: <http://www.w3.org/2002/07/owl#>"
                + "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>"
                + "PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>"
                + "PREFIX dsro: <http://www.semanticweb.org/zhang/ontologies/2018/8/DSR-ontology#>"
                + "SELECT ?x WHERE {  dsro:" + a + " rdfs:subClassOf ?x}");
            return results;
        }
        public object SubClass(string a)
        {
            IGraph g = new Graph();
            g.LoadFromFile("DSRO.rdf");
            object results = g.ExecuteQuery("PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>"
                + "PREFIX owl: <http://www.w3.org/2002/07/owl#>"
                + "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>"
                + "PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>"
                + "PREFIX dsro: <http://www.semanticweb.org/zhang/ontologies/2018/8/DSR-ontology#>"
                + "PREFIX skos: <http://www.w3.org/2004/02/skos/core#>"
                + "SELECT ?x WHERE {  ?x rdfs:subClassOf dsro:" + a + "}");
            return results;
        }
        public void Querry(object querry)
        {
            if (querry is SparqlResultSet)
            {
                resultBox.Items.Clear();
                //Print out the Results
                SparqlResultSet rset = (SparqlResultSet)querry;
                if (rset.Count.ToString() != "0")
                {
                    foreach (SparqlResult result in rset)
                    {
                        string tst = result.ToString().Replace("?x = http://www.semanticweb.org/zhang/ontologies/2018/8/DSR-ontology#", "");
                        resultBox.Items.Add(tst.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("This is first or last hierarchy of the ontology\n you need to re-search");
                    ResetOntology();
                }
            }
        }
        private void subClass_Click(object sender, EventArgs e)
        {

            string a;
            a = resultBox.Text.ToString();
            object q = SubClass(a);
            Querry(q);
        }

        private void superClass_Click(object sender, EventArgs e)
        {

            string a;
            a = resultBox.Text.ToString();
            object q = SuperClass(a);
            Querry(q);
        }

        private void insertClass_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                Manager manager = new Manager();
                manager.ShowDialog();
            }
            else
            {
                Guest guest = new Guest();
                guest.ShowDialog();
            }
        }
        private void ResetOntology()
        {
            IGraph g = new Graph();
            g.LoadFromFile("DSRO.rdf");
            object results = g.ExecuteQuery("PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>"
                + "PREFIX owl: <http://www.w3.org/2002/07/owl#>"
                + "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>"
                + "PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>"
                + "PREFIX dsro: <http://www.semanticweb.org/zhang/ontologies/2018/8/DSR-ontology#>"
                + "PREFIX skos: <http://www.w3.org/2004/02/skos/core#>"
                + "SELECT ?x WHERE {  ?x a ?o}");
            if (results is SparqlResultSet)
            {
                //Print out the Results
                SparqlResultSet rset = (SparqlResultSet)results;
                foreach (SparqlResult result in rset)
                {
                    string tst = result.ToString().Replace("?x = http://www.semanticweb.org/zhang/ontologies/2018/8/DSR-ontology#", "");
                    resultBox.Items.Add(tst.ToString());
                    for (int i = 0; i < resultBox.Items.Count; i++)
                    {
                        string str = resultBox.Items[i].ToString();
                        if (str.Contains("?x"))
                        {
                            resultBox.Items.RemoveAt(i);
                            for (int x = 0; x < resultBox.Items.Count; x++)
                                for (int j = x + 1; j < resultBox.Items.Count; j++)
                                {
                                    if (resultBox.Items[x].Equals(resultBox.Items[j]))
                                    {
                                        resultBox.Items.RemoveAt(j);
                                    }
                                }
                        }
                    }

                }
            }
        }
        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (loginLinkLabel.Text == "Login")
            {
                Form login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                userLabel.Text = "Guest";
                loginLinkLabel.Text = "Login";
                insertButton.Text = "Give Feedback!";
                flag = 0;
            }
            
        }

        private void SPARQLDemo_Load(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                userLabel.Text = "admin";
                loginLinkLabel.Text = "Logout";
                insertButton.Text = "Insert New Class Here";
            } else
            {
                userLabel.Text = "Guest";
                loginLinkLabel.Text = "Login";
                insertButton.Text = "Give Feedback!";
            }
        }
    }
}
