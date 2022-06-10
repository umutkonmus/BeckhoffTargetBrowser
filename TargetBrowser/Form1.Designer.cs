namespace TargetBrowser
{
    partial class MainForm
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
            this.treeViewSymbols = new System.Windows.Forms.TreeView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbFlat = new System.Windows.Forms.CheckBox();
            this.tbSymbolname = new System.Windows.Forms.TextBox();
            this.btnFindSymbol = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbIndexGroup = new System.Windows.Forms.TextBox();
            this.tbIndexOffset = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbDatatype = new System.Windows.Forms.TextBox();
            this.tbDatatypeId = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNetId = new System.Windows.Forms.TextBox();
            this.disconnectTimer = new System.Windows.Forms.Timer(this.components);
            this.pbTcState = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTcState)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewSymbols
            // 
            this.treeViewSymbols.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeViewSymbols.Location = new System.Drawing.Point(12, 8);
            this.treeViewSymbols.Name = "treeViewSymbols";
            this.treeViewSymbols.Size = new System.Drawing.Size(457, 444);
            this.treeViewSymbols.TabIndex = 0;
            this.treeViewSymbols.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSymbols_AfterSelect);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoad.Location = new System.Drawing.Point(256, 82);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(72, 29);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Bağlan";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbFlat
            // 
            this.cbFlat.AutoSize = true;
            this.cbFlat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFlat.Location = new System.Drawing.Point(276, 56);
            this.cbFlat.Name = "cbFlat";
            this.cbFlat.Size = new System.Drawing.Size(52, 20);
            this.cbFlat.TabIndex = 2;
            this.cbFlat.Text = "Flat";
            this.cbFlat.UseVisualStyleBackColor = true;
            // 
            // tbSymbolname
            // 
            this.tbSymbolname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSymbolname.Location = new System.Drawing.Point(486, 295);
            this.tbSymbolname.Name = "tbSymbolname";
            this.tbSymbolname.Size = new System.Drawing.Size(121, 27);
            this.tbSymbolname.TabIndex = 4;
            this.tbSymbolname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSymbolname_KeyDown);
            // 
            // btnFindSymbol
            // 
            this.btnFindSymbol.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFindSymbol.Location = new System.Drawing.Point(613, 295);
            this.btnFindSymbol.Name = "btnFindSymbol";
            this.btnFindSymbol.Size = new System.Drawing.Size(101, 27);
            this.btnFindSymbol.TabIndex = 5;
            this.btnFindSymbol.Text = "Symbol Bul";
            this.btnFindSymbol.UseVisualStyleBackColor = true;
            this.btnFindSymbol.Click += new System.EventHandler(this.btnFindSymbol_Click);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Verdana", 12F);
            this.tbName.Location = new System.Drawing.Point(134, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(140, 27);
            this.tbName.TabIndex = 6;
            // 
            // tbIndexGroup
            // 
            this.tbIndexGroup.Enabled = false;
            this.tbIndexGroup.Font = new System.Drawing.Font("Verdana", 12F);
            this.tbIndexGroup.Location = new System.Drawing.Point(134, 51);
            this.tbIndexGroup.Name = "tbIndexGroup";
            this.tbIndexGroup.Size = new System.Drawing.Size(140, 27);
            this.tbIndexGroup.TabIndex = 7;
            // 
            // tbIndexOffset
            // 
            this.tbIndexOffset.Enabled = false;
            this.tbIndexOffset.Font = new System.Drawing.Font("Verdana", 12F);
            this.tbIndexOffset.Location = new System.Drawing.Point(134, 88);
            this.tbIndexOffset.Name = "tbIndexOffset";
            this.tbIndexOffset.Size = new System.Drawing.Size(140, 27);
            this.tbIndexOffset.TabIndex = 8;
            // 
            // tbSize
            // 
            this.tbSize.Enabled = false;
            this.tbSize.Font = new System.Drawing.Font("Verdana", 12F);
            this.tbSize.Location = new System.Drawing.Point(133, 129);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(140, 27);
            this.tbSize.TabIndex = 9;
            // 
            // tbDatatype
            // 
            this.tbDatatype.Enabled = false;
            this.tbDatatype.Font = new System.Drawing.Font("Verdana", 12F);
            this.tbDatatype.Location = new System.Drawing.Point(134, 162);
            this.tbDatatype.Name = "tbDatatype";
            this.tbDatatype.Size = new System.Drawing.Size(140, 27);
            this.tbDatatype.TabIndex = 10;
            // 
            // tbDatatypeId
            // 
            this.tbDatatypeId.Enabled = false;
            this.tbDatatypeId.Font = new System.Drawing.Font("Verdana", 12F);
            this.tbDatatypeId.Location = new System.Drawing.Point(134, 199);
            this.tbDatatypeId.Name = "tbDatatypeId";
            this.tbDatatypeId.Size = new System.Drawing.Size(140, 27);
            this.tbDatatypeId.TabIndex = 11;
            // 
            // tbValue
            // 
            this.tbValue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbValue.Location = new System.Drawing.Point(134, 232);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(140, 27);
            this.tbValue.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbValue);
            this.groupBox1.Controls.Add(this.btnWrite);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbValue);
            this.groupBox1.Controls.Add(this.tbDatatypeId);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbDatatype);
            this.groupBox1.Controls.Add(this.tbIndexGroup);
            this.groupBox1.Controls.Add(this.tbSize);
            this.groupBox1.Controls.Add(this.tbIndexOffset);
            this.groupBox1.Location = new System.Drawing.Point(486, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 270);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO";
            // 
            // cbValue
            // 
            this.cbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValue.Enabled = false;
            this.cbValue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbValue.Location = new System.Drawing.Point(134, 233);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(140, 26);
            this.cbValue.TabIndex = 16;
            this.cbValue.Visible = false;
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWrite.Location = new System.Drawing.Point(280, 232);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(52, 27);
            this.btnWrite.TabIndex = 14;
            this.btnWrite.Text = "Yaz";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Value :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "DataType ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "DataType :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Size :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "IndexOffset :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "IndexGroup :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "AMS Net ID : ";
            // 
            // tbNetId
            // 
            this.tbNetId.Font = new System.Drawing.Font("Verdana", 12F);
            this.tbNetId.Location = new System.Drawing.Point(133, 23);
            this.tbNetId.Name = "tbNetId";
            this.tbNetId.Size = new System.Drawing.Size(195, 27);
            this.tbNetId.TabIndex = 14;
            // 
            // disconnectTimer
            // 
            this.disconnectTimer.Enabled = true;
            this.disconnectTimer.Tick += new System.EventHandler(this.disconnectTimer_Tick);
            // 
            // pbTcState
            // 
            this.pbTcState.Image = global::TargetBrowser.Properties.Resources.tcConfigImg;
            this.pbTcState.Location = new System.Drawing.Point(9, 92);
            this.pbTcState.Name = "pbTcState";
            this.pbTcState.Size = new System.Drawing.Size(18, 19);
            this.pbTcState.TabIndex = 16;
            this.pbTcState.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pbTcState);
            this.groupBox2.Controls.Add(this.tbNetId);
            this.groupBox2.Controls.Add(this.cbFlat);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Location = new System.Drawing.Point(486, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 124);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PLC";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSymbolname);
            this.Controls.Add(this.btnFindSymbol);
            this.Controls.Add(this.treeViewSymbols);
            this.Name = "MainForm";
            this.Text = "TwinCAT Target Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTcState)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewSymbols;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox cbFlat;
        private System.Windows.Forms.TextBox tbSymbolname;
        private System.Windows.Forms.Button btnFindSymbol;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbIndexGroup;
        private System.Windows.Forms.TextBox tbIndexOffset;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbDatatype;
        private System.Windows.Forms.TextBox tbDatatypeId;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNetId;
        private System.Windows.Forms.Timer disconnectTimer;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.PictureBox pbTcState;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

