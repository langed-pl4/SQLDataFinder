namespace SQLDataFinder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "tabela", "coluna", "valor" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtHost = new TextBox();
            label2 = new Label();
            txtUser = new TextBox();
            label3 = new Label();
            txtPass = new TextBox();
            label4 = new Label();
            txtDB = new ComboBox();
            textBox1 = new TextBox();
            label5 = new Label();
            btnPesquisar = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            context1 = new ContextMenuStrip(components);
            tsSelect = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblTable = new ToolStripStatusLabel();
            uPDATEToClipboardToolStripMenuItem = new ToolStripMenuItem();
            context1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Hostname ou IP:";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(126, 23);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(193, 23);
            txtHost.TabIndex = 1;
            txtHost.Text = "DALVM21";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 110);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome do Banco:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(126, 52);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(193, 23);
            txtUser.TabIndex = 5;
            txtUser.Text = "infodba";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 52);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Usuário:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(126, 81);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(193, 23);
            txtPass.TabIndex = 7;
            txtPass.Text = "infodba";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 81);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Senha:";
            // 
            // txtDB
            // 
            txtDB.FormattingEnabled = true;
            txtDB.Location = new Point(126, 110);
            txtDB.Name = "txtDB";
            txtDB.Size = new Size(193, 23);
            txtDB.TabIndex = 8;
            txtDB.DropDown += txtDB_DropDown;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "TcRAExcel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 139);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 9;
            label5.Text = "Pesquisar Por:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(244, 168);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.ContextMenuStrip = context1;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(325, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(517, 188);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tabela";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Coluna";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Valor";
            columnHeader3.Width = 150;
            // 
            // context1
            // 
            context1.Items.AddRange(new ToolStripItem[] { tsSelect, uPDATEToClipboardToolStripMenuItem });
            context1.Name = "cmdSelectToClip";
            context1.Size = new Size(186, 70);
            // 
            // tsSelect
            // 
            tsSelect.Name = "tsSelect";
            tsSelect.Size = new Size(185, 22);
            tsSelect.Text = "&SELECT to Clipboard";
            tsSelect.Click += tsSelect_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripStatusLabel1, lblTable });
            statusStrip1.Location = new Point(0, 231);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(850, 22);
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(89, 17);
            toolStripStatusLabel1.Text = "Verificando em:";
            // 
            // lblTable
            // 
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(16, 17);
            lblTable.Text = "...";
            // 
            // uPDATEToClipboardToolStripMenuItem
            // 
            uPDATEToClipboardToolStripMenuItem.Name = "uPDATEToClipboardToolStripMenuItem";
            uPDATEToClipboardToolStripMenuItem.Size = new Size(185, 22);
            uPDATEToClipboardToolStripMenuItem.Text = "&UPDATE to Clipboard";
            uPDATEToClipboardToolStripMenuItem.Click += uPDATEToClipboardToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 253);
            Controls.Add(statusStrip1);
            Controls.Add(listView1);
            Controls.Add(btnPesquisar);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(txtDB);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtHost);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "SQLDataFinder";
            context1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHost;
        private Label label2;
        private TextBox txtUser;
        private Label label3;
        private TextBox txtPass;
        private Label label4;
        private ComboBox txtDB;
        private TextBox textBox1;
        private Label label5;
        private Button btnPesquisar;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblTable;
        private ContextMenuStrip context1;
        private ToolStripMenuItem tsSelect;
        private ToolStripMenuItem uPDATEToClipboardToolStripMenuItem;
    }
}