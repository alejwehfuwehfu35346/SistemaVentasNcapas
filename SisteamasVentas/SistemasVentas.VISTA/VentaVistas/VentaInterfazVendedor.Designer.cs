namespace SistemasVentas.VISTA.VentaVistas
{
    partial class VentaInterfazVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaInterfazVendedor));
            label2 = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 270);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 168;
            label2.Text = "TOTAL";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 270);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 23);
            textBox3.TabIndex = 167;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 384);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 165;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 384);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 164;
            label1.Text = "FECHA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Teal;
            label9.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(10, 197);
            label9.Name = "label9";
            label9.Size = new Size(126, 23);
            label9.TabIndex = 162;
            label9.Text = "ID VENDEDOR";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 161;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Teal;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 139);
            label8.Name = "label8";
            label8.Size = new Size(106, 23);
            label8.TabIndex = 160;
            label8.Text = "ID CLIENTE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 159;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(360, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(529, 401);
            dataGridView1.TabIndex = 150;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 100);
            panel1.TabIndex = 169;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(693, 25);
            button2.Name = "button2";
            button2.Size = new Size(125, 61);
            button2.TabIndex = 2;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(432, 25);
            button1.Name = "button1";
            button1.Size = new Size(139, 61);
            button1.TabIndex = 1;
            button1.Text = "INSERTAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gray;
            label7.Font = new Font("Sitka Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Menu;
            label7.Location = new Point(95, 25);
            label7.Name = "label7";
            label7.Size = new Size(130, 47);
            label7.TabIndex = 0;
            label7.Text = "VENTA";
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.Location = new Point(191, 110);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 3;
            button5.Text = "SELEC";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.Location = new Point(205, 171);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 170;
            button6.Text = "SELEC";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // VentaInterfazVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(901, 519);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentaInterfazVendedor";
            Text = "VentaInterfazVendedor";
            Load += VentaInterfazVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label9;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label7;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button6;
    }
}