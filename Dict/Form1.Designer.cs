namespace Dict
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
            this.mylist = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insert = new System.Windows.Forms.Button();
            this.MeaningBox = new System.Windows.Forms.RichTextBox();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectedMeaning = new System.Windows.Forms.RichTextBox();
            this.selectedID = new System.Windows.Forms.TextBox();
            this.selectedWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.update = new System.Windows.Forms.Button();
            this.updateMeaning = new System.Windows.Forms.RichTextBox();
            this.updateWord = new System.Windows.Forms.TextBox();
            this.meaninglabel = new System.Windows.Forms.Label();
            this.wordlabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.deleteID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.findMeaningBox = new System.Windows.Forms.RichTextBox();
            this.find = new System.Windows.Forms.Button();
            this.findBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mylist
            // 
            this.mylist.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.mylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mylist.ForeColor = System.Drawing.Color.Blue;
            this.mylist.HideSelection = false;
            this.mylist.Location = new System.Drawing.Point(3, 27);
            this.mylist.Name = "mylist";
            this.mylist.Size = new System.Drawing.Size(450, 333);
            this.mylist.TabIndex = 0;
            this.mylist.UseCompatibleStateImageBehavior = false;
            this.mylist.SelectedIndexChanged += new System.EventHandler(this.mylist_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.MeaningBox);
            this.groupBox1.Controls.Add(this.WordBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(459, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Lime;
            this.insert.ForeColor = System.Drawing.Color.Red;
            this.insert.Location = new System.Drawing.Point(103, 118);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(116, 34);
            this.insert.TabIndex = 3;
            this.insert.Text = "INSERT";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // MeaningBox
            // 
            this.MeaningBox.Location = new System.Drawing.Point(84, 65);
            this.MeaningBox.Name = "MeaningBox";
            this.MeaningBox.Size = new System.Drawing.Size(166, 47);
            this.MeaningBox.TabIndex = 2;
            this.MeaningBox.Text = "";
            // 
            // WordBox
            // 
            this.WordBox.Location = new System.Drawing.Point(84, 33);
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(166, 26);
            this.WordBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Meaning:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox2.Controls.Add(this.selectedMeaning);
            this.groupBox2.Controls.Add(this.selectedID);
            this.groupBox2.Controls.Add(this.selectedWord);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected";
            // 
            // selectedMeaning
            // 
            this.selectedMeaning.Location = new System.Drawing.Point(108, 81);
            this.selectedMeaning.Name = "selectedMeaning";
            this.selectedMeaning.Size = new System.Drawing.Size(336, 35);
            this.selectedMeaning.TabIndex = 2;
            this.selectedMeaning.Text = "";
            // 
            // selectedID
            // 
            this.selectedID.Location = new System.Drawing.Point(46, 37);
            this.selectedID.Name = "selectedID";
            this.selectedID.Size = new System.Drawing.Size(102, 29);
            this.selectedID.TabIndex = 1;
            // 
            // selectedWord
            // 
            this.selectedWord.Location = new System.Drawing.Point(240, 40);
            this.selectedWord.Name = "selectedWord";
            this.selectedWord.Size = new System.Drawing.Size(204, 29);
            this.selectedWord.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meaning:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Word:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Thistle;
            this.groupBox3.Controls.Add(this.update);
            this.groupBox3.Controls.Add(this.updateMeaning);
            this.groupBox3.Controls.Add(this.updateWord);
            this.groupBox3.Controls.Add(this.meaninglabel);
            this.groupBox3.Controls.Add(this.wordlabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(459, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 167);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Chocolate;
            this.update.ForeColor = System.Drawing.Color.SeaShell;
            this.update.Location = new System.Drawing.Point(103, 125);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(116, 34);
            this.update.TabIndex = 3;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // updateMeaning
            // 
            this.updateMeaning.Location = new System.Drawing.Point(84, 73);
            this.updateMeaning.Name = "updateMeaning";
            this.updateMeaning.Size = new System.Drawing.Size(166, 46);
            this.updateMeaning.TabIndex = 2;
            this.updateMeaning.Text = "";
            // 
            // updateWord
            // 
            this.updateWord.Location = new System.Drawing.Point(84, 35);
            this.updateWord.Name = "updateWord";
            this.updateWord.Size = new System.Drawing.Size(166, 26);
            this.updateWord.TabIndex = 1;
            // 
            // meaninglabel
            // 
            this.meaninglabel.AutoSize = true;
            this.meaninglabel.Location = new System.Drawing.Point(6, 73);
            this.meaninglabel.Name = "meaninglabel";
            this.meaninglabel.Size = new System.Drawing.Size(82, 20);
            this.meaninglabel.TabIndex = 0;
            this.meaninglabel.Text = "Meaning:";
            // 
            // wordlabel
            // 
            this.wordlabel.AutoSize = true;
            this.wordlabel.Location = new System.Drawing.Point(6, 41);
            this.wordlabel.Name = "wordlabel";
            this.wordlabel.Size = new System.Drawing.Size(56, 20);
            this.wordlabel.TabIndex = 0;
            this.wordlabel.Text = "Word:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox4.Controls.Add(this.Delete);
            this.groupBox4.Controls.Add(this.deleteID);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(459, 366);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 122);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.ForeColor = System.Drawing.Color.SeaShell;
            this.Delete.Location = new System.Drawing.Point(103, 72);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 36);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // deleteID
            // 
            this.deleteID.Location = new System.Drawing.Point(84, 27);
            this.deleteID.Name = "deleteID";
            this.deleteID.Size = new System.Drawing.Size(166, 26);
            this.deleteID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Violet;
            this.groupBox5.Controls.Add(this.findMeaningBox);
            this.groupBox5.Controls.Add(this.find);
            this.groupBox5.Controls.Add(this.findBox);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 494);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(717, 93);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search a Word";
            // 
            // findMeaningBox
            // 
            this.findMeaningBox.Location = new System.Drawing.Point(537, 25);
            this.findMeaningBox.Name = "findMeaningBox";
            this.findMeaningBox.Size = new System.Drawing.Size(169, 44);
            this.findMeaningBox.TabIndex = 2;
            this.findMeaningBox.Text = "";
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.Gold;
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.ForeColor = System.Drawing.Color.Black;
            this.find.Location = new System.Drawing.Point(269, 34);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(159, 26);
            this.find.TabIndex = 3;
            this.find.Text = "Find Meaning";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // findBox
            // 
            this.findBox.Location = new System.Drawing.Point(112, 34);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(151, 26);
            this.findBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter Word: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Meaning:";
            // 
            // Form1
            // 
            this.AcceptButton = this.insert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mylist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView mylist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.RichTextBox MeaningBox;
        private System.Windows.Forms.TextBox WordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox selectedMeaning;
        private System.Windows.Forms.TextBox selectedID;
        private System.Windows.Forms.TextBox selectedWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.RichTextBox updateMeaning;
        private System.Windows.Forms.TextBox updateWord;
        private System.Windows.Forms.Label meaninglabel;
        private System.Windows.Forms.Label wordlabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox deleteID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox findMeaningBox;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox findBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

