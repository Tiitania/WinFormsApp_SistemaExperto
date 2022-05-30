
namespace WinFormsApp_ProyectoEquipo
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1_Ingresar = new System.Windows.Forms.Button();
            this.button2_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_Ingresar
            // 
            this.button1_Ingresar.Location = new System.Drawing.Point(98, 342);
            this.button1_Ingresar.Name = "button1_Ingresar";
            this.button1_Ingresar.Size = new System.Drawing.Size(138, 37);
            this.button1_Ingresar.TabIndex = 0;
            this.button1_Ingresar.Text = "Ingresar";
            this.button1_Ingresar.UseVisualStyleBackColor = true;
            // 
            // button2_Salir
            // 
            this.button2_Salir.Location = new System.Drawing.Point(561, 342);
            this.button2_Salir.Name = "button2_Salir";
            this.button2_Salir.Size = new System.Drawing.Size(138, 38);
            this.button2_Salir.TabIndex = 1;
            this.button2_Salir.Text = "Salir";
            this.button2_Salir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.BackgroundImage = global::WinFormsApp_ProyectoEquipo.Properties.Resources.index_main_block1_1_20211118;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 425);
            this.Controls.Add(this.button2_Salir);
            this.Controls.Add(this.button1_Ingresar);
            this.Name = "Form1";
            this.Text = "Compralo tu mismo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1_Ingresar;
        private System.Windows.Forms.Button button2_Salir;
    }
}

