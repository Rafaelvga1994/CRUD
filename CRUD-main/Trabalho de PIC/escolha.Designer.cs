namespace Trabalho_de_PIC
{
    partial class escolha
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
            this.adicionar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adicionar
            // 
            this.adicionar.BackColor = System.Drawing.Color.White;
            this.adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionar.Image = global::Trabalho_de_PIC.Properties.Resources.adicionarcerta11;
            this.adicionar.Location = new System.Drawing.Point(311, 67);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(162, 160);
            this.adicionar.TabIndex = 0;
            this.adicionar.UseVisualStyleBackColor = false;
            // 
            // apagar
            // 
            this.apagar.BackColor = System.Drawing.Color.White;
            this.apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apagar.Image = global::Trabalho_de_PIC.Properties.Resources.apagarcerta11;
            this.apagar.Location = new System.Drawing.Point(682, 307);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(163, 158);
            this.apagar.TabIndex = 1;
            this.apagar.UseVisualStyleBackColor = false;
            // 
            // alterar
            // 
            this.alterar.BackColor = System.Drawing.Color.White;
            this.alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterar.Image = global::Trabalho_de_PIC.Properties.Resources.alterar1_certa;
            this.alterar.Location = new System.Drawing.Point(311, 307);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(162, 158);
            this.alterar.TabIndex = 2;
            this.alterar.UseVisualStyleBackColor = false;
            this.alterar.Click += new System.EventHandler(this.button3_Click);
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.White;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Image = global::Trabalho_de_PIC.Properties.Resources.buscarcerta11;
            this.buscar.Location = new System.Drawing.Point(682, 67);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(163, 160);
            this.buscar.TabIndex = 3;
            this.buscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adicionar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alterar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apagar";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(988, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // escolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1182, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.adicionar);
            this.Name = "escolha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}