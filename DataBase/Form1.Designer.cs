namespace DataBase
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
            dtgvCarrera = new DataGridView();
            btnConect = new Button();
            dtgvAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvCarrera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dtgvCarrera
            // 
            dtgvCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCarrera.Location = new Point(44, 127);
            dtgvCarrera.Name = "dtgvCarrera";
            dtgvCarrera.RowHeadersWidth = 62;
            dtgvCarrera.Size = new Size(518, 290);
            dtgvCarrera.TabIndex = 1;
            // 
            // btnConect
            // 
            btnConect.Location = new Point(99, 37);
            btnConect.Name = "btnConect";
            btnConect.Size = new Size(112, 34);
            btnConect.TabIndex = 2;
            btnConect.Text = "Conect";
            btnConect.UseVisualStyleBackColor = true;
            btnConect.Click += btnConect_Click;
            // 
            // dtgvAlumnos
            // 
            dtgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAlumnos.Location = new Point(600, 127);
            dtgvAlumnos.Name = "dtgvAlumnos";
            dtgvAlumnos.RowHeadersWidth = 62;
            dtgvAlumnos.Size = new Size(518, 290);
            dtgvAlumnos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 450);
            Controls.Add(dtgvAlumnos);
            Controls.Add(btnConect);
            Controls.Add(dtgvCarrera);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgvCarrera).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvCarrera;
        private Button btnConect;
        private DataGridView dtgvAlumnos;
    }
}
