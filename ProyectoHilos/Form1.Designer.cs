namespace ProyectoHilos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnADD = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progrFile = new System.Windows.Forms.ProgressBar();
            this.progrBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLASTNAME = new System.Windows.Forms.TextBox();
            this.txtCELLPHONE = new System.Windows.Forms.TextBox();
            this.txtADDRESS = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.dgvDATA = new System.Windows.Forms.DataGridView();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Black;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnADD.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.Red;
            this.btnADD.Location = new System.Drawing.Point(804, 196);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(64, 54);
            this.btnADD.TabIndex = 8;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.Black;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSAVE.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.Red;
            this.btnSAVE.Location = new System.Drawing.Point(586, 131);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(77, 29);
            this.btnSAVE.TabIndex = 7;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(755, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "PROGRESS STREAM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(755, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "PROGRESS DATABASE";
            // 
            // progrFile
            // 
            this.progrFile.BackColor = System.Drawing.Color.Red;
            this.progrFile.ForeColor = System.Drawing.Color.Red;
            this.progrFile.Location = new System.Drawing.Point(682, 333);
            this.progrFile.Name = "progrFile";
            this.progrFile.Size = new System.Drawing.Size(328, 27);
            this.progrFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progrFile.TabIndex = 1;
            this.progrFile.UseWaitCursor = true;
            // 
            // progrBar
            // 
            this.progrBar.BackColor = System.Drawing.Color.Red;
            this.progrBar.ForeColor = System.Drawing.Color.Red;
            this.progrBar.Location = new System.Drawing.Point(682, 256);
            this.progrBar.Name = "progrBar";
            this.progrBar.Size = new System.Drawing.Size(328, 27);
            this.progrBar.TabIndex = 0;
            this.progrBar.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "NAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "CELLPHONE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "E-MAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "CURP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "ADDRESS";
            // 
            // txtNAME
            // 
            this.txtNAME.BackColor = System.Drawing.Color.Black;
            this.txtNAME.ForeColor = System.Drawing.Color.Red;
            this.txtNAME.Location = new System.Drawing.Point(13, 12);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(100, 20);
            this.txtNAME.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "LAST NAME";
            // 
            // txtLASTNAME
            // 
            this.txtLASTNAME.BackColor = System.Drawing.Color.Black;
            this.txtLASTNAME.ForeColor = System.Drawing.Color.Red;
            this.txtLASTNAME.Location = new System.Drawing.Point(186, 12);
            this.txtLASTNAME.Name = "txtLASTNAME";
            this.txtLASTNAME.Size = new System.Drawing.Size(145, 20);
            this.txtLASTNAME.TabIndex = 2;
            // 
            // txtCELLPHONE
            // 
            this.txtCELLPHONE.BackColor = System.Drawing.Color.Black;
            this.txtCELLPHONE.ForeColor = System.Drawing.Color.Red;
            this.txtCELLPHONE.Location = new System.Drawing.Point(13, 78);
            this.txtCELLPHONE.Name = "txtCELLPHONE";
            this.txtCELLPHONE.Size = new System.Drawing.Size(100, 20);
            this.txtCELLPHONE.TabIndex = 4;
            // 
            // txtADDRESS
            // 
            this.txtADDRESS.BackColor = System.Drawing.Color.Black;
            this.txtADDRESS.ForeColor = System.Drawing.Color.Red;
            this.txtADDRESS.Location = new System.Drawing.Point(395, 12);
            this.txtADDRESS.Name = "txtADDRESS";
            this.txtADDRESS.Size = new System.Drawing.Size(268, 20);
            this.txtADDRESS.TabIndex = 3;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.BackColor = System.Drawing.Color.Black;
            this.txtEMAIL.ForeColor = System.Drawing.Color.Red;
            this.txtEMAIL.Location = new System.Drawing.Point(186, 78);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(145, 20);
            this.txtEMAIL.TabIndex = 5;
            // 
            // txtCURP
            // 
            this.txtCURP.BackColor = System.Drawing.Color.Black;
            this.txtCURP.ForeColor = System.Drawing.Color.Red;
            this.txtCURP.Location = new System.Drawing.Point(401, 78);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(262, 20);
            this.txtCURP.TabIndex = 6;
            // 
            // dgvDATA
            // 
            this.dgvDATA.AllowUserToAddRows = false;
            this.dgvDATA.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDATA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDATA.BackgroundColor = System.Drawing.Color.Black;
            this.dgvDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDATA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNom,
            this.colPat,
            this.colDir,
            this.colRfc,
            this.colEma,
            this.colTel});
            this.dgvDATA.Location = new System.Drawing.Point(13, 166);
            this.dgvDATA.Name = "dgvDATA";
            this.dgvDATA.ReadOnly = true;
            this.dgvDATA.Size = new System.Drawing.Size(650, 221);
            this.dgvDATA.TabIndex = 37;
            // 
            // colNom
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.colNom.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNom.HeaderText = "NAME";
            this.colNom.Name = "colNom";
            this.colNom.ReadOnly = true;
            // 
            // colPat
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            this.colPat.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPat.HeaderText = "LAST NAME";
            this.colPat.Name = "colPat";
            this.colPat.ReadOnly = true;
            // 
            // colDir
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            this.colDir.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDir.HeaderText = "ADDRESS";
            this.colDir.Name = "colDir";
            this.colDir.ReadOnly = true;
            // 
            // colRfc
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            this.colRfc.DefaultCellStyle = dataGridViewCellStyle5;
            this.colRfc.HeaderText = "CELLPHONE";
            this.colRfc.Name = "colRfc";
            this.colRfc.ReadOnly = true;
            // 
            // colEma
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            this.colEma.DefaultCellStyle = dataGridViewCellStyle6;
            this.colEma.HeaderText = "E-MAIL";
            this.colEma.Name = "colEma";
            this.colEma.ReadOnly = true;
            // 
            // colTel
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            this.colTel.DefaultCellStyle = dataGridViewCellStyle7;
            this.colTel.HeaderText = "CURP";
            this.colTel.Name = "colTel";
            this.colTel.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoHilos.Properties.Resources._1470174011_news2;
            this.pictureBox1.Location = new System.Drawing.Point(682, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDATA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLASTNAME);
            this.Controls.Add(this.txtCELLPHONE);
            this.Controls.Add(this.txtADDRESS);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtCURP);
            this.Controls.Add(this.progrFile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progrBar);
            this.Controls.Add(this.btnADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progrFile;
        private System.Windows.Forms.ProgressBar progrBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLASTNAME;
        private System.Windows.Forms.TextBox txtCELLPHONE;
        private System.Windows.Forms.TextBox txtADDRESS;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtCURP;
        private System.Windows.Forms.DataGridView dgvDATA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
    }
}

