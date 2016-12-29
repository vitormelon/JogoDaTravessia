namespace JogoDaTravessia
{
    partial class Jogo
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
            this.listaOrigem = new System.Windows.Forms.CheckedListBox();
            this.transportaParaDestino = new System.Windows.Forms.Button();
            this.transportaParaOrigem = new System.Windows.Forms.Button();
            this.listaDestino = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaOrigem
            // 
            this.listaOrigem.FormattingEnabled = true;
            this.listaOrigem.Location = new System.Drawing.Point(12, 40);
            this.listaOrigem.Name = "listaOrigem";
            this.listaOrigem.Size = new System.Drawing.Size(181, 244);
            this.listaOrigem.TabIndex = 0;
            // 
            // transportaParaDestino
            // 
            this.transportaParaDestino.Location = new System.Drawing.Point(199, 153);
            this.transportaParaDestino.Name = "transportaParaDestino";
            this.transportaParaDestino.Size = new System.Drawing.Size(88, 23);
            this.transportaParaDestino.TabIndex = 2;
            this.transportaParaDestino.Text = "Transportar -->";
            this.transportaParaDestino.UseVisualStyleBackColor = true;
            this.transportaParaDestino.Click += new System.EventHandler(this.transportaParaDestino_Click);
            // 
            // transportaParaOrigem
            // 
            this.transportaParaOrigem.Location = new System.Drawing.Point(398, 153);
            this.transportaParaOrigem.Name = "transportaParaOrigem";
            this.transportaParaOrigem.Size = new System.Drawing.Size(90, 23);
            this.transportaParaOrigem.TabIndex = 3;
            this.transportaParaOrigem.Text = "<-- Transportar";
            this.transportaParaOrigem.UseVisualStyleBackColor = true;
            this.transportaParaOrigem.Click += new System.EventHandler(this.transportaParaOrigem_Click);
            // 
            // listaDestino
            // 
            this.listaDestino.FormattingEnabled = true;
            this.listaDestino.Location = new System.Drawing.Point(494, 40);
            this.listaDestino.Name = "listaDestino";
            this.listaDestino.Size = new System.Drawing.Size(181, 244);
            this.listaDestino.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino";
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaDestino);
            this.Controls.Add(this.transportaParaOrigem);
            this.Controls.Add(this.transportaParaDestino);
            this.Controls.Add(this.listaOrigem);
            this.Name = "Jogo";
            this.Text = "Jogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listaOrigem;
        private System.Windows.Forms.Button transportaParaDestino;
        private System.Windows.Forms.Button transportaParaOrigem;
        private System.Windows.Forms.CheckedListBox listaDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}