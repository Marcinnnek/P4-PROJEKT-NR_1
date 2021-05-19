
namespace P4_PROJEKT_NR_1
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
            this.dataGridViewEmployess = new System.Windows.Forms.DataGridView();
            this.buttonShowEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployess)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployess
            // 
            this.dataGridViewEmployess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEmployess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployess.Location = new System.Drawing.Point(12, 136);
            this.dataGridViewEmployess.MinimumSize = new System.Drawing.Size(15, 0);
            this.dataGridViewEmployess.Name = "dataGridViewEmployess";
            this.dataGridViewEmployess.RowHeadersWidth = 47;
            this.dataGridViewEmployess.RowTemplate.Height = 28;
            this.dataGridViewEmployess.Size = new System.Drawing.Size(776, 302);
            this.dataGridViewEmployess.TabIndex = 0;
            // 
            // buttonShowEmployee
            // 
            this.buttonShowEmployee.Location = new System.Drawing.Point(297, 47);
            this.buttonShowEmployee.Name = "buttonShowEmployee";
            this.buttonShowEmployee.Size = new System.Drawing.Size(179, 55);
            this.buttonShowEmployee.TabIndex = 1;
            this.buttonShowEmployee.Text = "Pokaż pracowników";
            this.buttonShowEmployee.UseVisualStyleBackColor = true;
            this.buttonShowEmployee.Click += new System.EventHandler(this.buttonShowEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowEmployee);
            this.Controls.Add(this.dataGridViewEmployess);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployess;
        private System.Windows.Forms.Button buttonShowEmployee;
    }
}

