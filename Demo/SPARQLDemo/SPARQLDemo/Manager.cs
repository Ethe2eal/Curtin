using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Query;
using VDS.RDF.Update;
using VDS.RDF.Writing;

namespace SPARQLDemo
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string className = classTextBox.Text;
            string classDefinition = subClassTextBox.Text;
            IGraph g = new Graph();
            TripleStore tripleStore = new TripleStore();
            tripleStore.Add(g);

            RdfXmlParser rdfXmlParser = new RdfXmlParser();
            g.LoadFromFile("DSRO.rdf");

            SparqlUpdateParser parser = new SparqlUpdateParser();
            SparqlParameterizedString cmdString = new SparqlParameterizedString();

            cmdString.CommandText = @"PREFIX rdf: < http://www.w3.org/1999/02/22-rdf-syntax-ns#>"
            + "PREFIX owl: <http://www.w3.org/2002/07/owl#>"
            + "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>"
            + "PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>"
            + "PREFIX dsro: < http://www.semanticweb.org/zhang/ontologies/2018/8/DSR-ontology#> INSERT DATA {dsro:"+classTextBox.Text+" a owl:Class. dsro:"+classTextBox.Text+" rdfs:subClassOf dsro:"+subClassTextBox.Text+".}";
            SparqlUpdateCommandSet cmds = parser.ParseFromString(cmdString);
            LeviathanUpdateProcessor processor = new LeviathanUpdateProcessor(tripleStore);
            processor.ProcessCommandSet(cmds);
            RdfXmlWriter rdfXmlWriter = new RdfXmlWriter();
            rdfXmlWriter.Save(g, "DSRO.rdf");
            MessageBox.Show("New class has inserted");
            this.Close();
        }
    }
}
