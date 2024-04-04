namespace SistemasVentas.VISTA.UsuarioVistas
{
    partial class UsuarioInterfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioInterfaz));
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Teal;
            label9.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 146);
            label9.Name = "label9";
            label9.Size = new Size(131, 23);
            label9.TabIndex = 71;
            label9.Text = "NOMBRE USER";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 23);
            textBox2.TabIndex = 70;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Teal;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 222);
            label8.Name = "label8";
            label8.Size = new Size(111, 23);
            label8.TabIndex = 69;
            label8.Text = "ID PERSONA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 68;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(345, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(550, 400);
            dataGridView1.TabIndex = 57;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 100);
            panel1.TabIndex = 72;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Location = new Point(766, 21);
            button4.Name = "button4";
            button4.Size = new Size(104, 60);
            button4.TabIndex = 4;
            button4.Text = "ELIMINAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(630, 22);
            button3.Name = "button3";
            button3.Size = new Size(104, 60);
            button3.TabIndex = 3;
            button3.Text = "INSERTAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(486, 20);
            button2.Name = "button2";
            button2.Size = new Size(106, 62);
            button2.TabIndex = 2;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(355, 22);
            button1.Name = "button1";
            button1.Size = new Size(107, 60);
            button1.TabIndex = 1;
            button1.Text = "ACTUALIZAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Sitka Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(33, 20);
            label2.Name = "label2";
            label2.Size = new Size(167, 47);
            label2.TabIndex = 0;
            label2.Text = "USUARIO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Teal;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 304);
            label7.Name = "label7";
            label7.Size = new Size(121, 23);
            label7.TabIndex = 75;
            label7.Text = "CONTRASEÑA";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 307);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 74;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Teal;
            label10.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(35, 392);
            label10.Name = "label10";
            label10.Size = new Size(65, 23);
            label10.TabIndex = 77;
            label10.Text = "FECHA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 392);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 78;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.Location = new Point(199, 196);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "SELEC";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // UsuarioInterfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(907, 519);
            Controls.Add(button5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsuarioInterfaz";
            Text = "UsuarioInterfaz";
            Load += UsuarioInterfaz_Load;
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
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private Label label7;
        private TextBox textBox3;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
    }
}