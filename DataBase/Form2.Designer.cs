namespace DataBase
{
    partial class Form2
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
            dtgvAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dtgvAlumnos
            // 
            dtgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAlumnos.Location = new Point(238, 125);
            dtgvAlumnos.Name = "dtgvAlumnos";
            dtgvAlumnos.RowHeadersWidth = 62;
            dtgvAlumnos.Size = new Size(518, 290);
            dtgvAlumnos.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvAlumnos);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dtgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvAlumnos;
    }
}