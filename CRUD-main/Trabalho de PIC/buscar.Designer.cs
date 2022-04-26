namespace Trabalho_de_PIC
{
    partial class buscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DGVDados = new System.Windows.Forms.DataGridView();
            this.procuraBox = new System.Windows.Forms.ComboBox();
            this.panelchildForm = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDados)).BeginInit();
            this.panelchildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(314, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(641, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(190, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Century", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(961, 141);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(73, 22);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Procurar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1054, 586);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Volta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DGVDados
            // 
            this.DGVDados.AllowUserToAddRows = false;
            this.DGVDados.AllowUserToDeleteRows = false;
            this.DGVDados.AllowUserToResizeColumns = false;
            this.DGVDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DGVDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.DGVDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGVDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDados.GridColor = System.Drawing.Color.Black;
            this.DGVDados.Location = new System.Drawing.Point(190, 178);
            this.DGVDados.Name = "DGVDados";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDados.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVDados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDados.Size = new System.Drawing.Size(758, 310);
            this.DGVDados.TabIndex = 7;
            this.DGVDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGVDados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDados_CellDoubleClick);
            // 
            // procuraBox
            // 
            this.procuraBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.procuraBox.ForeColor = System.Drawing.Color.White;
            this.procuraBox.FormattingEnabled = true;
            this.procuraBox.Items.AddRange(new object[] {
            "Data",
            "Proprietário",
            "Animal",
            "Contato"});
            this.procuraBox.Location = new System.Drawing.Point(197, 141);
            this.procuraBox.Name = "procuraBox";
            this.procuraBox.Size = new System.Drawing.Size(112, 21);
            this.procuraBox.TabIndex = 8;
            this.procuraBox.Text = "Selecionar...";
            this.procuraBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelchildForm
            // 
            this.panelchildForm.AutoSize = true;
            this.panelchildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelchildForm.Controls.Add(this.procuraBox);
            this.panelchildForm.Controls.Add(this.button4);
            this.panelchildForm.Controls.Add(this.label6);
            this.panelchildForm.Controls.Add(this.label1);
            this.panelchildForm.Controls.Add(this.btnbuscar);
            this.panelchildForm.Controls.Add(this.textBox1);
            this.panelchildForm.Location = new System.Drawing.Point(-7, -3);
            this.panelchildForm.Name = "panelchildForm";
            this.panelchildForm.Size = new System.Drawing.Size(1159, 639);
            this.panelchildForm.TabIndex = 28;
            this.panelchildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchildForm_Paint_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(512, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Área reservada para Adicionar e Buscar\r\n";
            // 
            // buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1164, 648);
            this.Controls.Add(this.DGVDados);
            this.Controls.Add(this.panelchildForm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "buscar";
            this.Text = "buscar";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDados)).EndInit();
            this.panelchildForm.ResumeLayout(false);
            this.panelchildForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DGVDados;
        private System.Windows.Forms.Panel panelchildForm;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox procuraBox;
        public System.Windows.Forms.Button btnbuscar;
    }
}