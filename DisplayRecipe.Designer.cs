
namespace _324_phase_3
{
    partial class DisplayRecipe
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
            this.textBoxMethod = new System.Windows.Forms.TextBox();
            this.textBoxIngredients = new System.Windows.Forms.TextBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.labelRecipeTitle = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.pictureBoxShare = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxRecipe = new System.Windows.Forms.PictureBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelShare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.textBoxMethod.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.textBoxMethod.Location = new System.Drawing.Point(35, 544);
            this.textBoxMethod.Multiline = true;
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.ReadOnly = true;
            this.textBoxMethod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMethod.Size = new System.Drawing.Size(665, 269);
            this.textBoxMethod.TabIndex = 11;
            this.textBoxMethod.TabStop = false;
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.textBoxIngredients.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.textBoxIngredients.Location = new System.Drawing.Point(35, 321);
            this.textBoxIngredients.Multiline = true;
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.ReadOnly = true;
            this.textBoxIngredients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIngredients.Size = new System.Drawing.Size(665, 167);
            this.textBoxIngredients.TabIndex = 10;
            this.textBoxIngredients.TabStop = false;
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelMethod.Location = new System.Drawing.Point(29, 508);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(105, 35);
            this.labelMethod.TabIndex = 9;
            this.labelMethod.Text = "Method";
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelIngredients.Location = new System.Drawing.Point(29, 273);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(153, 35);
            this.labelIngredients.TabIndex = 8;
            this.labelIngredients.Text = "Ingredients";
            // 
            // labelRecipeTitle
            // 
            this.labelRecipeTitle.AutoSize = true;
            this.labelRecipeTitle.Font = new System.Drawing.Font("Trebuchet MS", 36F);
            this.labelRecipeTitle.Location = new System.Drawing.Point(71, 12);
            this.labelRecipeTitle.MinimumSize = new System.Drawing.Size(500, 70);
            this.labelRecipeTitle.Name = "labelRecipeTitle";
            this.labelRecipeTitle.Size = new System.Drawing.Size(500, 70);
            this.labelRecipeTitle.TabIndex = 14;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Trebuchet MS", 50F);
            this.labelBack.Location = new System.Drawing.Point(8, 4);
            this.labelBack.MinimumSize = new System.Drawing.Size(70, 70);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(70, 84);
            this.labelBack.TabIndex = 15;
            this.labelBack.Text = "<";
            this.labelBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click_1);
            // 
            // pictureBoxShare
            // 
            this.pictureBoxShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShare.Image = global::_324_phase_3.Properties.Resources.share;
            this.pictureBoxShare.Location = new System.Drawing.Point(647, 12);
            this.pictureBoxShare.Name = "pictureBoxShare";
            this.pictureBoxShare.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShare.TabIndex = 17;
            this.pictureBoxShare.TabStop = false;
            this.pictureBoxShare.Click += new System.EventHandler(this.pictureBoxShare_Click);
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Image = global::_324_phase_3.Properties.Resources.delete;
            this.pictureBoxDelete.Location = new System.Drawing.Point(587, 12);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDelete.TabIndex = 16;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // pictureBoxRecipe
            // 
            this.pictureBoxRecipe.Location = new System.Drawing.Point(21, 106);
            this.pictureBoxRecipe.Name = "pictureBoxRecipe";
            this.pictureBoxRecipe.Size = new System.Drawing.Size(695, 157);
            this.pictureBoxRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRecipe.TabIndex = 13;
            this.pictureBoxRecipe.TabStop = false;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDelete.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.labelDelete.Location = new System.Drawing.Point(593, 69);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(50, 18);
            this.labelDelete.TabIndex = 22;
            this.labelDelete.Text = "Delete";
            this.labelDelete.Click += new System.EventHandler(this.labelDelete_Click);
            // 
            // labelShare
            // 
            this.labelShare.AutoSize = true;
            this.labelShare.BackColor = System.Drawing.Color.Transparent;
            this.labelShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelShare.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.labelShare.Location = new System.Drawing.Point(656, 70);
            this.labelShare.Name = "labelShare";
            this.labelShare.Size = new System.Drawing.Size(43, 18);
            this.labelShare.TabIndex = 23;
            this.labelShare.Text = "Share";
            this.labelShare.Click += new System.EventHandler(this.labelShare_Click);
            // 
            // DisplayRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(741, 825);
            this.Controls.Add(this.labelRecipeTitle);
            this.Controls.Add(this.labelShare);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.pictureBoxShare);
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.pictureBoxRecipe);
            this.Controls.Add(this.textBoxMethod);
            this.Controls.Add(this.textBoxIngredients);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.labelIngredients);
            this.Name = "DisplayRecipe";
            this.Text = "Display Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.TextBox textBoxIngredients;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.PictureBox pictureBoxRecipe;
        private System.Windows.Forms.Label labelRecipeTitle;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBoxShare;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelShare;
    }
}