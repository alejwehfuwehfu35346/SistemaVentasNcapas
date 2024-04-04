namespace SistemasVentas.VISTA.PersonaVistas
{
    partial class PersonaInterfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonaInterfaz));
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 141);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 21;
            label1.Text = "NOMBRE";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(345, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(464, 430);
            dataGridView1.TabIndex = 20;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 100);
            panel1.TabIndex = 32;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(546, 34);
            button2.Name = "button2";
            button2.Size = new Size(115, 51);
            button2.TabIndex = 41;
            button2.Text = "ACTUALIZAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(424, 34);
            button1.Name = "button1";
            button1.Size = new Size(106, 51);
            button1.TabIndex = 33;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(286, 34);
            button3.Name = "button3";
            button3.Size = new Size(116, 51);
            button3.TabIndex = 32;
            button3.Text = "Insertar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Sitka Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(33, 20);
            label2.Name = "label2";
            label2.Size = new Size(174, 47);
            label2.TabIndex = 0;
            label2.Text = "PERSONA";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Teal;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 192);
            label7.Name = "label7";
            label7.Size = new Size(93, 23);
            label7.TabIndex = 33;
            label7.Text = "APELLIDO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 261);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 23);
            textBox3.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Teal;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 261);
            label8.Name = "label8";
            label8.Size = new Size(99, 23);
            label8.TabIndex = 35;
            label8.Text = "TELEFONO";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(118, 324);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 23);
            textBox4.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Teal;
            label9.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 402);
            label9.Name = "label9";
            label9.Size = new Size(27, 23);
            label9.TabIndex = 37;
            label9.Text = "CI";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(69, 405);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 23);
            textBox5.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Teal;
            label10.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 324);
            label10.Name = "label10";
            label10.Size = new Size(77, 23);
            label10.TabIndex = 39;
            label10.Text = "CORREO";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Location = new Point(696, 34);
            button4.Name = "button4";
            button4.Size = new Size(112, 51);
            button4.TabIndex = 42;
            button4.Text = "ELIMINAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // PersonaInterfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(821, 544);
            Controls.Add(textBox5);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonaInterfaz";
            Text = "PersonaInterfaz";
            Load += PersonaInterfaz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}