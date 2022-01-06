namespace PetitParis_Launcher
{
    partial class CacheRemover
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(776, 220);
            this.checkedListBox1.TabIndex = 0;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(12, 238);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(145, 35);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Annuler";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(643, 238);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(145, 35);
            this.button_remove.TabIndex = 2;
            this.button_remove.Text = "Supprimer le cache";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // CacheRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "CacheRemover";
            this.Text = "CacheRemover";
            this.Load += new System.EventHandler(this.CacheRemover_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button button_delete;
        private Button button_remove;
    }
}