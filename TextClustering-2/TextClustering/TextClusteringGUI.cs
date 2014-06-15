using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TextClustering.Lib;

namespace TextClustering
{
    public partial class TextClusteringGUI : Form
    {
        private DocumentCollection docCollection;
        public TextClusteringGUI()
        {
            InitializeComponent();
            docCollection = new DocumentCollection() { DocumentList = new List<string>() };
        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDoc1.Text))
                docCollection.DocumentList.Add(txtDoc1.Text);
            if (!string.IsNullOrEmpty(txtDoc2.Text))
                docCollection.DocumentList.Add(txtDoc2.Text);
            if (!string.IsNullOrEmpty(txtDoc3.Text))
                docCollection.DocumentList.Add(txtDoc3.Text);
            if (!string.IsNullOrEmpty(txtDoc4.Text))
                docCollection.DocumentList.Add(txtDoc4.Text);


            int totalDoc = 0;
            if(int.TryParse(docCollection.DocumentList.Count.ToString(),out totalDoc))
            {
                lblTotalDoc.Text = totalDoc.ToString();
            }

            txtDoc1.Clear();
            txtDoc2.Clear();
            txtDoc3.Clear();
            txtDoc4.Clear();

            
        }

        private void btnStartClustering_Click(object sender, EventArgs e)
        {
            List<DocumentVector> vSpace = VectorSpaceModel.ProcessDocumentCollection(docCollection);
            int totalIteration = 0;
            List<Centroid> resultSet = DocumnetClustering.PrepareDocumentCluster(int.Parse(txtClusterNo.Text), vSpace,ref  totalIteration);
            string msg = string.Empty;
            int count = 1;
            foreach (Centroid c in resultSet)
            {
                msg += String.Format("------------------------------[ CLUSTER {0} ]-----------------------------{1}", count, System.Environment.NewLine);
                foreach (DocumentVector document in c.GroupedDocument)
                {
                    msg += document.Content + System.Environment.NewLine;
                    if (c.GroupedDocument.Count > 1)
                    {
                        msg += String.Format("{0}-------------------------------------------------------------------------------{0}", System.Environment.NewLine);
                    }
                }
                msg += "-------------------------------------------------------------------------------" + System.Environment.NewLine;
                count++;
            }

            richTextBox1.Text = msg;
            lblTotalIteration.Text = totalIteration.ToString();
        }

        private void btnStopProcess_Click(object sender, EventArgs e)
        {
            docCollection = new DocumentCollection();
            this.ClearField();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.ClearField();
            docCollection = new DocumentCollection();
        }


        private void ClearField()
        {
            txtClusterNo.Clear();
            txtDoc1.Clear();
            txtDoc2.Clear();
            txtDoc3.Clear();
            txtDoc4.Clear();
            lblTotalDoc.Text="";
            lblError.Text = "";
            lblTotalCluster.Text = "";
            lblTotalIteration.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearField();
        }

        private void txtClusterNo_TextChanged(object sender, EventArgs e)
        {
            int totalDoc = 0;
            if(int.TryParse(txtClusterNo.Text, out totalDoc))
            {
                lblError.Text = "";
                lblTotalCluster.Text = txtClusterNo.Text;
            }
            else
            {
                lblError.Text = "Enter a valid integer";
                lblTotalCluster.Text = " ";
            }

            
        }

    }
}
