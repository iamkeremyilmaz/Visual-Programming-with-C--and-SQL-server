
namespace midtermproject
{
    partial class CarDatas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarDatas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chassis = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.feature = new System.Windows.Forms.RichTextBox();
            this.Listbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.carid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chassis Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(36, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(36, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(36, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Features";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(706, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(574, 654);
            this.dataGridView1.TabIndex = 4;
            // 
            // chassis
            // 
            this.chassis.Location = new System.Drawing.Point(327, 53);
            this.chassis.Name = "chassis";
            this.chassis.Size = new System.Drawing.Size(179, 31);
            this.chassis.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(327, 180);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(179, 31);
            this.price.TabIndex = 7;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(327, 124);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(179, 31);
            this.model.TabIndex = 8;
            // 
            // feature
            // 
            this.feature.Location = new System.Drawing.Point(327, 234);
            this.feature.Name = "feature";
            this.feature.Size = new System.Drawing.Size(343, 166);
            this.feature.TabIndex = 9;
            this.feature.Text = "";
            // 
            // Listbtn
            // 
            this.Listbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Listbtn.Location = new System.Drawing.Point(148, 465);
            this.Listbtn.Name = "Listbtn";
            this.Listbtn.Size = new System.Drawing.Size(82, 56);
            this.Listbtn.TabIndex = 10;
            this.Listbtn.Text = "List";
            this.Listbtn.UseVisualStyleBackColor = true;
            this.Listbtn.Click += new System.EventHandler(this.Listbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Deletebtn.Location = new System.Drawing.Point(266, 465);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(82, 56);
            this.Deletebtn.TabIndex = 12;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addbtn.Location = new System.Drawing.Point(43, 465);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(82, 56);
            this.addbtn.TabIndex = 13;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Updatebtn.Location = new System.Drawing.Point(382, 465);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(104, 56);
            this.Updatebtn.TabIndex = 14;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(36, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "Car Id";
            // 
            // carid
            // 
            this.carid.Location = new System.Drawing.Point(327, 9);
            this.carid.Name = "carid";
            this.carid.Size = new System.Drawing.Size(186, 31);
            this.carid.TabIndex = 16;
            // 
            // CarDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 821);
            this.Controls.Add(this.carid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Listbtn);
            this.Controls.Add(this.feature);
            this.Controls.Add(this.model);
            this.Controls.Add(this.price);
            this.Controls.Add(this.chassis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarDatas";
            this.Text = "CarDatas";
            this.Load += new System.EventHandler(this.CarDatas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox chassis;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.RichTextBox feature;
        private System.Windows.Forms.Button Listbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox carid;
    }
}