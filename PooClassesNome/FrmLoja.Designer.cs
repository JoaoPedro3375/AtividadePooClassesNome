namespace PooClassesNome
{
    partial class FrmLoja
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aquiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefeitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.lblpais = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.lblcomplemento = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.lblrua = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.lblcnpj = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aquiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aquiToolStripMenuItem
            // 
            this.aquiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prefeitoToolStripMenuItem,
            this.alimentoToolStripMenuItem,
            this.lojaToolStripMenuItem});
            this.aquiToolStripMenuItem.Name = "aquiToolStripMenuItem";
            this.aquiToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.aquiToolStripMenuItem.Text = "aqui";
            // 
            // prefeitoToolStripMenuItem
            // 
            this.prefeitoToolStripMenuItem.Name = "prefeitoToolStripMenuItem";
            this.prefeitoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prefeitoToolStripMenuItem.Text = "Prefeito";
            this.prefeitoToolStripMenuItem.Click += new System.EventHandler(this.prefeitoToolStripMenuItem_Click);
            // 
            // alimentoToolStripMenuItem
            // 
            this.alimentoToolStripMenuItem.Name = "alimentoToolStripMenuItem";
            this.alimentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alimentoToolStripMenuItem.Text = "Alimento";
            this.alimentoToolStripMenuItem.Click += new System.EventHandler(this.alimentoToolStripMenuItem_Click);
            // 
            // lojaToolStripMenuItem
            // 
            this.lojaToolStripMenuItem.Name = "lojaToolStripMenuItem";
            this.lojaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lojaToolStripMenuItem.Text = "Loja";
            this.lojaToolStripMenuItem.Click += new System.EventHandler(this.lojaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnlimpar);
            this.panel1.Controls.Add(this.btncadastrar);
            this.panel1.Controls.Add(this.txtpais);
            this.panel1.Controls.Add(this.lblpais);
            this.panel1.Controls.Add(this.txtestado);
            this.panel1.Controls.Add(this.lblestado);
            this.panel1.Controls.Add(this.txtcidade);
            this.panel1.Controls.Add(this.lblcidade);
            this.panel1.Controls.Add(this.txtcomplemento);
            this.panel1.Controls.Add(this.lblcomplemento);
            this.panel1.Controls.Add(this.txtnumero);
            this.panel1.Controls.Add(this.lblnumero);
            this.panel1.Controls.Add(this.txtrua);
            this.panel1.Controls.Add(this.lblrua);
            this.panel1.Controls.Add(this.txtcep);
            this.panel1.Controls.Add(this.lblcep);
            this.panel1.Controls.Add(this.txtcpf);
            this.panel1.Controls.Add(this.lblcnpj);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Location = new System.Drawing.Point(201, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 289);
            this.panel1.TabIndex = 4;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(262, 252);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 22;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(42, 252);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 21;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(13, 86);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(100, 20);
            this.txtpais.TabIndex = 20;
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Location = new System.Drawing.Point(16, 70);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(32, 13);
            this.lblpais.TabIndex = 19;
            this.lblpais.Text = "País:";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(262, 86);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(104, 20);
            this.txtestado.TabIndex = 18;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(263, 70);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(43, 13);
            this.lblestado.TabIndex = 17;
            this.lblestado.Text = "Estado:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(140, 86);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(100, 20);
            this.txtcidade.TabIndex = 16;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(137, 70);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(43, 13);
            this.lblcidade.TabIndex = 15;
            this.lblcidade.Text = "Cidade:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(17, 142);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(96, 20);
            this.txtcomplemento.TabIndex = 14;
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.Location = new System.Drawing.Point(14, 126);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(74, 13);
            this.lblcomplemento.TabIndex = 13;
            this.lblcomplemento.Text = "Complemento:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(262, 142);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(104, 20);
            this.txtnumero.TabIndex = 12;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(259, 126);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(44, 13);
            this.lblnumero.TabIndex = 11;
            this.lblnumero.Text = "Numero";
            // 
            // txtrua
            // 
            this.txtrua.Location = new System.Drawing.Point(136, 142);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(100, 20);
            this.txtrua.TabIndex = 10;
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.Location = new System.Drawing.Point(133, 126);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(48, 13);
            this.lblrua.TabIndex = 9;
            this.lblrua.Text = "Rua/Av:";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(266, 32);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(100, 20);
            this.txtcep.TabIndex = 8;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(263, 16);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(29, 13);
            this.lblcep.TabIndex = 7;
            this.lblcep.Text = "Cep:";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(136, 32);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 20);
            this.txtcpf.TabIndex = 4;
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.Location = new System.Drawing.Point(133, 16);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(31, 13);
            this.lblcnpj.TabIndex = 3;
            this.lblcnpj.Text = "Cnpj:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(13, 32);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 2;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(10, 16);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome:";
            // 
            // FrmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmLoja";
            this.Text = "Loja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aquiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prefeitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.Label lblrua;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label lblcnpj;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
    }
}

