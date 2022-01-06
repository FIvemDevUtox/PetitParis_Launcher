namespace PetitParis_Launcher
{
    partial class parametres
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
            this.checkBox_lightMode = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_police = new System.Windows.Forms.Button();
            this.button_foreColor = new System.Windows.Forms.Button();
            this.button_backColor = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button_changeBackground = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_lightMode
            // 
            this.checkBox_lightMode.AutoSize = true;
            this.checkBox_lightMode.Location = new System.Drawing.Point(61, 147);
            this.checkBox_lightMode.Name = "checkBox_lightMode";
            this.checkBox_lightMode.Size = new System.Drawing.Size(157, 19);
            this.checkBox_lightMode.TabIndex = 0;
            this.checkBox_lightMode.Text = "Mettre les icons en blanc";
            this.checkBox_lightMode.UseVisualStyleBackColor = true;
            this.checkBox_lightMode.CheckedChanged += new System.EventHandler(this.checkBox_lightMode_CheckedChanged);
            // 
            // button_police
            // 
            this.button_police.Location = new System.Drawing.Point(12, 12);
            this.button_police.Name = "button_police";
            this.button_police.Size = new System.Drawing.Size(259, 23);
            this.button_police.TabIndex = 1;
            this.button_police.Text = "Changer la police d\'écriture";
            this.button_police.UseVisualStyleBackColor = true;
            this.button_police.Click += new System.EventHandler(this.button_police_Click);
            // 
            // button_foreColor
            // 
            this.button_foreColor.Location = new System.Drawing.Point(12, 41);
            this.button_foreColor.Name = "button_foreColor";
            this.button_foreColor.Size = new System.Drawing.Size(259, 23);
            this.button_foreColor.TabIndex = 2;
            this.button_foreColor.Text = "Changer la couleur des polices";
            this.button_foreColor.UseVisualStyleBackColor = true;
            this.button_foreColor.Click += new System.EventHandler(this.button_foreColor_Click);
            // 
            // button_backColor
            // 
            this.button_backColor.Location = new System.Drawing.Point(12, 70);
            this.button_backColor.Name = "button_backColor";
            this.button_backColor.Size = new System.Drawing.Size(259, 23);
            this.button_backColor.TabIndex = 3;
            this.button_backColor.Text = "Changer la couleur des boutons";
            this.button_backColor.UseVisualStyleBackColor = true;
            this.button_backColor.Click += new System.EventHandler(this.button_backColor_Click);
            // 
            // button_changeBackground
            // 
            this.button_changeBackground.Location = new System.Drawing.Point(12, 99);
            this.button_changeBackground.Name = "button_changeBackground";
            this.button_changeBackground.Size = new System.Drawing.Size(259, 23);
            this.button_changeBackground.TabIndex = 4;
            this.button_changeBackground.Text = "Changer l\'image du launcher";
            this.button_changeBackground.UseVisualStyleBackColor = true;
            this.button_changeBackground.Click += new System.EventHandler(this.button_changeBackground_Click);
            // 
            // parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 178);
            this.Controls.Add(this.button_changeBackground);
            this.Controls.Add(this.button_backColor);
            this.Controls.Add(this.button_foreColor);
            this.Controls.Add(this.button_police);
            this.Controls.Add(this.checkBox_lightMode);
            this.Name = "parametres";
            this.ShowIcon = false;
            this.Text = "parametres";
            this.Load += new System.EventHandler(this.parametres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBox_lightMode;
        private ColorDialog colorDialog1;
        private Button button_police;
        private Button button_foreColor;
        private Button button_backColor;
        private FontDialog fontDialog1;
        private Button button_changeBackground;
    }
}