namespace SistemasVentas.VISTA.ClienteVistas
{
    partial class ClienteInterfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteInterfaz));
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox3 = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Red;
            label9.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 245);
            label9.Name = "label9";
            label9.Size = new Size(127, 23);
            label9.TabIndex = 110;
            label9.Text = "TIPO CLIENTE";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 245);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 23);
            textBox2.TabIndex = 109;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Red;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 393);
            label8.Name = "label8";
            label8.Size = new Size(111, 23);
            label8.TabIndex = 108;
            label8.Text = "ID PERSONA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 396);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 107;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Red;
            label6.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(565, 44);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 106;
            label6.Text = "ELIMINAR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Red;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(863, 44);
            label5.Name = "label5";
            label5.Size = new Size(114, 23);
            label5.TabIndex = 105;
            label5.Text = "ACTUALIZAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(390, 44);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 104;
            label4.Text = "LIMPIAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(711, 44);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 103;
            label3.Text = "INSERTAR";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(355, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(724, 464);
            dataGridView1.TabIndex = 98;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 321);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 113;
            label1.Text = "CODIGO CLIENTE";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 321);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 112;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(8, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 100);
            panel1.TabIndex = 114;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(33, 20);
            label2.Name = "label2";
            label2.Size = new Size(163, 47);
            label2.TabIndex = 0;
            label2.Text = "CLIENTE";
            // 
            // ClienteInterfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1079, 584);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClienteInterfaz";
            Text = "ClienteInterfaz";
            Load += ClienteInterfaz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox3;
        private Panel panel1;
        private Label label2;
    }
}