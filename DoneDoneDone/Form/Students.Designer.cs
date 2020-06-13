namespace DoneDoneDone
{
    partial class FormStudents
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_idrequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_namerequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_descriptionrequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_namedepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_idrequest,
            this.dgv_namerequest,
            this.dgv_descriptionrequest,
            this.dgv_namedepartment});
            this.dataGridView1.Location = new System.Drawing.Point(44, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 109);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgv_idrequest
            // 
            this.dgv_idrequest.DataPropertyName = "idrequest";
            this.dgv_idrequest.HeaderText = "MÃ";
            this.dgv_idrequest.Name = "dgv_idrequest";
            // 
            // dgv_namerequest
            // 
            this.dgv_namerequest.DataPropertyName = "namerequest";
            this.dgv_namerequest.HeaderText = "YÊU CẦU";
            this.dgv_namerequest.Name = "dgv_namerequest";
            // 
            // dgv_descriptionrequest
            // 
            this.dgv_descriptionrequest.DataPropertyName = "descriptionrequest";
            this.dgv_descriptionrequest.HeaderText = "MÔ TẢ";
            this.dgv_descriptionrequest.Name = "dgv_descriptionrequest";
            // 
            // dgv_namedepartment
            // 
            this.dgv_namedepartment.DataPropertyName = "namedepartment";
            this.dgv_namedepartment.HeaderText = "PHÒNG BAN";
            this.dgv_namedepartment.Name = "dgv_namedepartment";
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormStudents";
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_idrequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_namerequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_descriptionrequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_namedepartment;
    }
}