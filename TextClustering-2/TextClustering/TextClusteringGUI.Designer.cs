namespace TextClustering
{
    partial class TextClusteringGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblTotalCluster = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalDoc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnStartClustering = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClusterNo = new System.Windows.Forms.TextBox();
            this.txtDoc4 = new System.Windows.Forms.TextBox();
            this.txtDoc3 = new System.Windows.Forms.TextBox();
            this.txtDoc2 = new System.Windows.Forms.TextBox();
            this.txtDoc1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalIteration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalIteration);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalCluster);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalDoc);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnRestart);
            this.splitContainer1.Panel1.Controls.Add(this.lblError);
            this.splitContainer1.Panel1.Controls.Add(this.btnStartClustering);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtClusterNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtDoc4);
            this.splitContainer1.Panel1.Controls.Add(this.txtDoc3);
            this.splitContainer1.Panel1.Controls.Add(this.txtDoc2);
            this.splitContainer1.Panel1.Controls.Add(this.txtDoc1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(867, 432);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 2;
            // 
            // lblTotalCluster
            // 
            this.lblTotalCluster.AutoSize = true;
            this.lblTotalCluster.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCluster.Location = new System.Drawing.Point(138, 372);
            this.lblTotalCluster.Name = "lblTotalCluster";
            this.lblTotalCluster.Size = new System.Drawing.Size(0, 14);
            this.lblTotalCluster.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "User Defined Cluster:";
            // 
            // lblTotalDoc
            // 
            this.lblTotalDoc.AutoSize = true;
            this.lblTotalDoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDoc.Location = new System.Drawing.Point(140, 356);
            this.lblTotalDoc.Name = "lblTotalDoc";
            this.lblTotalDoc.Size = new System.Drawing.Size(0, 14);
            this.lblTotalDoc.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enter your text below. Each text box field \r\nrepresents a new document.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Text Clustering Demo";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(159, 47);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 14);
            this.lblError.TabIndex = 11;
            // 
            // btnStartClustering
            // 
            this.btnStartClustering.Location = new System.Drawing.Point(13, 400);
            this.btnStartClustering.Name = "btnStartClustering";
            this.btnStartClustering.Size = new System.Drawing.Size(75, 23);
            this.btnStartClustering.TabIndex = 9;
            this.btnStartClustering.Text = "Start";
            this.btnStartClustering.UseVisualStyleBackColor = true;
            this.btnStartClustering.Click += new System.EventHandler(this.btnStartClustering_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total No of Document:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(97, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "No of cluster";
            // 
            // txtClusterNo
            // 
            this.txtClusterNo.Location = new System.Drawing.Point(90, 44);
            this.txtClusterNo.Name = "txtClusterNo";
            this.txtClusterNo.Size = new System.Drawing.Size(64, 20);
            this.txtClusterNo.TabIndex = 0;
            this.txtClusterNo.TextChanged += new System.EventHandler(this.txtClusterNo_TextChanged);
            // 
            // txtDoc4
            // 
            this.txtDoc4.Location = new System.Drawing.Point(13, 275);
            this.txtDoc4.Multiline = true;
            this.txtDoc4.Name = "txtDoc4";
            this.txtDoc4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDoc4.Size = new System.Drawing.Size(309, 48);
            this.txtDoc4.TabIndex = 4;
            // 
            // txtDoc3
            // 
            this.txtDoc3.Location = new System.Drawing.Point(13, 221);
            this.txtDoc3.Multiline = true;
            this.txtDoc3.Name = "txtDoc3";
            this.txtDoc3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDoc3.Size = new System.Drawing.Size(309, 48);
            this.txtDoc3.TabIndex = 3;
            // 
            // txtDoc2
            // 
            this.txtDoc2.Location = new System.Drawing.Point(13, 167);
            this.txtDoc2.Multiline = true;
            this.txtDoc2.Name = "txtDoc2";
            this.txtDoc2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDoc2.Size = new System.Drawing.Size(309, 48);
            this.txtDoc2.TabIndex = 2;
            // 
            // txtDoc1
            // 
            this.txtDoc1.Location = new System.Drawing.Point(13, 113);
            this.txtDoc1.Multiline = true;
            this.txtDoc1.Name = "txtDoc1";
            this.txtDoc1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDoc1.Size = new System.Drawing.Size(309, 48);
            this.txtDoc1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(515, 424);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(179, 328);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total Iteration:";
            // 
            // lblTotalIteration
            // 
            this.lblTotalIteration.AutoSize = true;
            this.lblTotalIteration.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIteration.Location = new System.Drawing.Point(277, 372);
            this.lblTotalIteration.Name = "lblTotalIteration";
            this.lblTotalIteration.Size = new System.Drawing.Size(0, 14);
            this.lblTotalIteration.TabIndex = 20;
            // 
            // TextClusteringGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 456);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TextClusteringGUI";
            this.Text = "Text Clustering";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtDoc4;
        private System.Windows.Forms.TextBox txtDoc3;
        private System.Windows.Forms.TextBox txtDoc2;
        private System.Windows.Forms.TextBox txtDoc1;
        private System.Windows.Forms.Button btnStartClustering;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClusterNo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblTotalDoc;
        private System.Windows.Forms.Label lblTotalCluster;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalIteration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestart;
    }
}

