namespace Trash.GomixExample
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.byteUnitTextBox1 = new Trash.GoMix.ByteUnitTextBox();
            this.SuspendLayout();
            // 
            // byteUnitTextBox1
            // 
            this.byteUnitTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.byteUnitTextBox1.Encoder = ((System.Text.Encoding)(resources.GetObject("byteUnitTextBox1.Encoder")));
            this.byteUnitTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.byteUnitTextBox1.Location = new System.Drawing.Point(14, 15);
            this.byteUnitTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.byteUnitTextBox1.Multiline = true;
            this.byteUnitTextBox1.Name = "byteUnitTextBox1";
            this.byteUnitTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.byteUnitTextBox1.Size = new System.Drawing.Size(436, 301);
            this.byteUnitTextBox1.TabIndex = 0;
            this.byteUnitTextBox1.TextChanged += new System.EventHandler(this.byteUnitTextBox1_TextChanged);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 332);
            this.Controls.Add(this.byteUnitTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TestForm";
            this.Text = "TestForm - 0 Byte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GoMix.ByteUnitTextBox byteUnitTextBox1;
    }
}