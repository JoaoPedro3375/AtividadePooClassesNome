namespace PooClassesNome
{
    partial class FrmAlimento
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
            this.txtvalor10 = new System.Windows.Forms.TextBox();
            this.lblrua = new System.Windows.Forms.Label();
            this.txtvalorcompra = new System.Windows.Forms.TextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtcalorias = new System.Windows.Forms.TextBox();
            this.lblcaloria = new System.Windows.Forms.Label();
            this.txtingredientes = new System.Windows.Forms.TextBox();
            this.lblingrediente = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.txtvalor10);
            this.panel1.Controls.Add(this.lblrua);
            this.panel1.Controls.Add(this.txtvalorcompra);
            this.panel1.Controls.Add(this.lblcep);
            this.panel1.Controls.Add(this.txtcalorias);
            this.panel1.Controls.Add(this.lblcaloria);
            this.panel1.Controls.Add(this.txtingredientes);
            this.panel1.Controls.Add(this.lblingrediente);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Location = new System.Drawing.Point(201, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 139);
            this.panel1.TabIndex = 4;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(297, 94);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 22;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(297, 65);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 21;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            // 
            // txtvalor10
            // 
            this.txtvalor10.Location = new System.Drawing.Point(136, 86);
            this.txtvalor10.Name = "txtvalor10";
            this.txtvalor10.Size = new System.Drawing.Size(136, 20);
            this.txtvalor10.TabIndex = 10;
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.Location = new System.Drawing.Point(133, 70);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(139, 13);
            this.lblrua.TabIndex = 9;
            this.lblrua.Text = "Valor com 10% de aumento:";
            // 
            // txtvalorcompra
            // 
            this.txtvalorcompra.Location = new System.Drawing.Point(17, 86);
            this.txtvalorcompra.Name = "txtvalorcompra";
            this.txtvalorcompra.Size = new System.Drawing.Size(100, 20);
            this.txtvalorcompra.TabIndex = 8;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(14, 70);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(87, 13);
            this.lblcep.TabIndex = 7;
            this.lblcep.Text = "Valor de compra:";
            // 
            // txtcalorias
            // 
            this.txtcalorias.Location = new System.Drawing.Point(262, 32);
            this.txtcalorias.Name = "txtcalorias";
            this.txtcalorias.Size = new System.Drawing.Size(93, 20);
            this.txtcalorias.TabIndex = 6;
            // 
            // lblcaloria
            // 
            this.lblcaloria.AutoSize = true;
            this.lblcaloria.Location = new System.Drawing.Point(259, 16);
            this.lblcaloria.Name = "lblcaloria";
            this.lblcaloria.Size = new System.Drawing.Size(47, 13);
            this.lblcaloria.TabIndex = 5;
            this.lblcaloria.Text = "Calorias:";
            // 
            // txtingredientes
            // 
            this.txtingredientes.Location = new System.Drawing.Point(136, 32);
            this.txtingredientes.Name = "txtingredientes";
            this.txtingredientes.Size = new System.Drawing.Size(100, 20);
            this.txtingredientes.TabIndex = 4;
            // 
            // lblingrediente
            // 
            this.lblingrediente.AutoSize = true;
            this.lblingrediente.Location = new System.Drawing.Point(133, 16);
            this.lblingrediente.Name = "lblingrediente";
            this.lblingrediente.Size = new System.Drawing.Size(68, 13);
            this.lblingrediente.TabIndex = 3;
            this.lblingrediente.Text = "Ingredientes:";
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
            // FrmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAlimento";
            this.Text = "Alimento";
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
        private System.Windows.Forms.TextBox txtvalor10;
        private System.Windows.Forms.Label lblrua;
        private System.Windows.Forms.TextBox txtvalorcompra;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.TextBox txtcalorias;
        private System.Windows.Forms.Label lblcaloria;
        private System.Windows.Forms.TextBox txtingredientes;
        private System.Windows.Forms.Label lblingrediente;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
    }
}