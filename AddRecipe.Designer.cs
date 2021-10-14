
namespace _324_phase_3
{
    partial class AddRecipe
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxIngredients = new System.Windows.Forms.TextBox();
            this.textBoxMethod = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelVideo = new System.Windows.Forms.Label();
            this.labelAddRecipe = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxUpload = new System.Windows.Forms.PictureBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelTitle.Location = new System.Drawing.Point(16, 104);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(72, 35);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelPicture.Location = new System.Drawing.Point(14, 157);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(102, 35);
            this.labelPicture.TabIndex = 1;
            this.labelPicture.Text = "Picture";
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelIngredients.Location = new System.Drawing.Point(16, 339);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(153, 35);
            this.labelIngredients.TabIndex = 3;
            this.labelIngredients.Text = "Ingredients";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelMethod.Location = new System.Drawing.Point(16, 529);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(105, 35);
            this.labelMethod.TabIndex = 4;
            this.labelMethod.Text = "Method";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.textBoxTitle.Location = new System.Drawing.Point(195, 104);
            this.textBoxTitle.MinimumSize = new System.Drawing.Size(72, 35);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(485, 35);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.textBoxIngredients.Location = new System.Drawing.Point(195, 339);
            this.textBoxIngredients.Multiline = true;
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.Size = new System.Drawing.Size(485, 167);
            this.textBoxIngredients.TabIndex = 6;
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.textBoxMethod.Location = new System.Drawing.Point(195, 529);
            this.textBoxMethod.Multiline = true;
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.Size = new System.Drawing.Size(485, 269);
            this.textBoxMethod.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.buttonAdd.Location = new System.Drawing.Point(173, 829);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 85);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.buttonCancel.Location = new System.Drawing.Point(379, 829);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(170, 85);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelVideo.Location = new System.Drawing.Point(14, 192);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(97, 35);
            this.labelVideo.TabIndex = 2;
            this.labelVideo.Text = "/Video";
            // 
            // labelAddRecipe
            // 
            this.labelAddRecipe.AutoSize = true;
            this.labelAddRecipe.Font = new System.Drawing.Font("Trebuchet MS", 36F);
            this.labelAddRecipe.Location = new System.Drawing.Point(12, 9);
            this.labelAddRecipe.MinimumSize = new System.Drawing.Size(668, 70);
            this.labelAddRecipe.Name = "labelAddRecipe";
            this.labelAddRecipe.Size = new System.Drawing.Size(668, 70);
            this.labelAddRecipe.TabIndex = 10;
            this.labelAddRecipe.Text = "Add Recipe";
            this.labelAddRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxUpload
            // 
            this.pictureBoxUpload.Location = new System.Drawing.Point(195, 207);
            this.pictureBoxUpload.Name = "pictureBoxUpload";
            this.pictureBoxUpload.Size = new System.Drawing.Size(482, 108);
            this.pictureBoxUpload.TabIndex = 11;
            this.pictureBoxUpload.TabStop = false;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.buttonUpload.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonUpload.Location = new System.Drawing.Point(195, 161);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(482, 44);
            this.buttonUpload.TabIndex = 12;
            this.buttonUpload.Text = "upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(716, 931);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.pictureBoxUpload);
            this.Controls.Add(this.labelAddRecipe);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMethod);
            this.Controls.Add(this.textBoxIngredients);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.labelIngredients);
            this.Controls.Add(this.labelVideo);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.labelTitle);
            this.Name = "AddRecipe";
            this.Text = "Add Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxIngredients;
        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelVideo;
        private System.Windows.Forms.Label labelAddRecipe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxUpload;
        private System.Windows.Forms.Button buttonUpload;
    }
}