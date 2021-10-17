
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
            this.SuspendLayout();
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.textBoxMethod.Location = new System.Drawing.Point(210, 422);
            this.textBoxMethod.Multiline = true;
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.ReadOnly = true;
            this.textBoxMethod.Size = new System.Drawing.Size(485, 269);
            this.textBoxMethod.TabIndex = 11;
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.textBoxIngredients.Location = new System.Drawing.Point(210, 232);
            this.textBoxIngredients.Multiline = true;
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.ReadOnly = true;
            this.textBoxIngredients.Size = new System.Drawing.Size(485, 167);
            this.textBoxIngredients.TabIndex = 10;
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelMethod.Location = new System.Drawing.Point(31, 422);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(105, 35);
            this.labelMethod.TabIndex = 9;
            this.labelMethod.Text = "Method";
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelIngredients.Location = new System.Drawing.Point(31, 232);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(153, 35);
            this.labelIngredients.TabIndex = 8;
            this.labelIngredients.Text = "Ingredients";
            // 
            // DisplayRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 724);
            this.Controls.Add(this.textBoxMethod);
            this.Controls.Add(this.textBoxIngredients);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.labelIngredients);
            this.Name = "DisplayRecipe";
            this.Text = "Display Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.TextBox textBoxIngredients;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Label labelIngredients;
    }
}