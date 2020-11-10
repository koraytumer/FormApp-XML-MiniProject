namespace FormApp_XML_MiniProject
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbJob = new System.Windows.Forms.Label();
            this.txAdress = new System.Windows.Forms.TextBox();
            this.lbBirthdate = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txJob = new System.Windows.Forms.TextBox();
            this.txSurname = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 349);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 5, 0, 0, 0, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(580, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 20);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(580, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 20);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(580, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 20);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(346, 349);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(100, 20);
            this.txID.TabIndex = 30;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbID.Location = new System.Drawing.Point(284, 349);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 17);
            this.lbID.TabIndex = 29;
            this.lbID.Text = "ID:";
            // 
            // lbJob
            // 
            this.lbJob.AutoSize = true;
            this.lbJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbJob.Location = new System.Drawing.Point(284, 238);
            this.lbJob.Name = "lbJob";
            this.lbJob.Size = new System.Drawing.Size(35, 17);
            this.lbJob.TabIndex = 28;
            this.lbJob.Text = "Job:";
            // 
            // txAdress
            // 
            this.txAdress.Location = new System.Drawing.Point(346, 293);
            this.txAdress.Name = "txAdress";
            this.txAdress.Size = new System.Drawing.Size(100, 20);
            this.txAdress.TabIndex = 27;
            // 
            // lbBirthdate
            // 
            this.lbBirthdate.AutoSize = true;
            this.lbBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBirthdate.Location = new System.Drawing.Point(67, 349);
            this.lbBirthdate.Name = "lbBirthdate";
            this.lbBirthdate.Size = new System.Drawing.Size(69, 17);
            this.lbBirthdate.TabIndex = 26;
            this.lbBirthdate.Text = "Birthdate:";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAdress.Location = new System.Drawing.Point(284, 293);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(56, 17);
            this.lbAdress.TabIndex = 25;
            this.lbAdress.Text = "Adress:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSurname.Location = new System.Drawing.Point(67, 293);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(73, 17);
            this.lbSurname.TabIndex = 24;
            this.lbSurname.Text = "Surname: ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbName.Location = new System.Drawing.Point(67, 238);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 17);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "Name: ";
            // 
            // txJob
            // 
            this.txJob.Location = new System.Drawing.Point(346, 235);
            this.txJob.Name = "txJob";
            this.txJob.Size = new System.Drawing.Size(100, 20);
            this.txJob.TabIndex = 22;
            // 
            // txSurname
            // 
            this.txSurname.Location = new System.Drawing.Point(141, 293);
            this.txSurname.Name = "txSurname";
            this.txSurname.Size = new System.Drawing.Size(100, 20);
            this.txSurname.TabIndex = 21;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(141, 238);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(100, 20);
            this.txName.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 188);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.World, ((byte)(160)));
            this.label1.Location = new System.Drawing.Point(12, 417);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(294, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Read, add, update and delete data from XML file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbJob);
            this.Controls.Add(this.txAdress);
            this.Controls.Add(this.lbBirthdate);
            this.Controls.Add(this.lbAdress);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txJob);
            this.Controls.Add(this.txSurname);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbJob;
        private System.Windows.Forms.TextBox txAdress;
        private System.Windows.Forms.Label lbBirthdate;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txJob;
        private System.Windows.Forms.TextBox txSurname;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}

