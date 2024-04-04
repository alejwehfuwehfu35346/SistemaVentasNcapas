namespace SistemasVentas.VISTA.ProveeVistas
{
    partial class ProveeInterfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveeInterfaz));
            label7 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label11 = new Label();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Teal;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 417);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 193;
            label7.Text = "FECHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 319);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 191;
            label2.Text = "PRECIO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 322);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 23);
            textBox3.TabIndex = 190;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Teal;
            label9.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 230);
            label9.Name = "label9";
            label9.Size = new Size(135, 23);
            label9.TabIndex = 187;
            label9.Text = "ID PROVEEDOR";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 186;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Teal;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 158);
            label8.Name = "label8";
            label8.Size = new Size(124, 23);
            label8.TabIndex = 185;
            label8.Text = "ID PRODUCTO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 184;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(360, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(582, 401);
            dataGridView1.TabIndex = 175;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(98, 417);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 194;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 100);
            panel1.TabIndex = 195;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Location = new Point(795, 26);
            button4.Name = "button4";
            button4.Size = new Size(102, 53);
            button4.TabIndex = 4;
            button4.Text = "ELIMINAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(671, 26);
            button3.Name = "button3";
            button3.Size = new Size(96, 53);
            button3.TabIndex = 3;
            button3.Text = "INSERTAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(532, 26);
            button2.Name = "button2";
            button2.Size = new Size(99, 53);
            button2.TabIndex = 2;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(394, 26);
            button1.Name = "button1";
            button1.Size = new Size(100, 53);
            button1.TabIndex = 1;
            button1.Text = "ACTUALIZAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(64, 64, 64);
            label11.Font = new Font("Sitka Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Menu;
            label11.Location = new Point(33, 20);
            label11.Name = "label11";
            label11.Size = new Size(152, 47);
            label11.TabIndex = 0;
            label11.Text = "PROVEE";
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.Location = new Point(198, 132);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "SELEC";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.Location = new Point(209, 204);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "SELEC";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // ProveeInterfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(954, 519);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProveeInterfaz";
            Text = "ProveeInterfaz";
            Load += ProveeInterfaz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label2;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Label label11;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button6;
    }
}