namespace CRUDProduto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.tbQntd = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btInserir = new System.Windows.Forms.Button();
            this.btLocaliza = new System.Windows.Forms.Button();
            this.btEdita = new System.Windows.Forms.Button();
            this.btDeleta = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(77, 70);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(155, 20);
            this.tbNome.TabIndex = 0;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(77, 114);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(155, 20);
            this.tbMarca.TabIndex = 1;
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(77, 155);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(155, 20);
            this.tbPreco.TabIndex = 2;
            // 
            // tbQntd
            // 
            this.tbQntd.Location = new System.Drawing.Point(77, 201);
            this.tbQntd.Name = "tbQntd";
            this.tbQntd.Size = new System.Drawing.Size(155, 20);
            this.tbQntd.TabIndex = 3;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(77, 23);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(69, 20);
            this.tbID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade";
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(37, 269);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 10;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btLocaliza
            // 
            this.btLocaliza.Location = new System.Drawing.Point(132, 269);
            this.btLocaliza.Name = "btLocaliza";
            this.btLocaliza.Size = new System.Drawing.Size(75, 23);
            this.btLocaliza.TabIndex = 11;
            this.btLocaliza.Text = "Localizar";
            this.btLocaliza.UseVisualStyleBackColor = true;
            // 
            // btEdita
            // 
            this.btEdita.Location = new System.Drawing.Point(225, 269);
            this.btEdita.Name = "btEdita";
            this.btEdita.Size = new System.Drawing.Size(75, 23);
            this.btEdita.TabIndex = 12;
            this.btEdita.Text = "Editar";
            this.btEdita.UseVisualStyleBackColor = true;
            // 
            // btDeleta
            // 
            this.btDeleta.Location = new System.Drawing.Point(319, 269);
            this.btDeleta.Name = "btDeleta";
            this.btDeleta.Size = new System.Drawing.Size(75, 23);
            this.btDeleta.TabIndex = 13;
            this.btDeleta.Text = "Deletar";
            this.btDeleta.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(415, 269);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 14;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 326);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btDeleta);
            this.Controls.Add(this.btEdita);
            this.Controls.Add(this.btLocaliza);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbQntd);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.TextBox tbQntd;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btLocaliza;
        private System.Windows.Forms.Button btEdita;
        private System.Windows.Forms.Button btDeleta;
        private System.Windows.Forms.Button btSair;
    }
}

