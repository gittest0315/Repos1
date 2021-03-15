
namespace TestAquireUserToken
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.Label();
            this.TokenInfoText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultText
            // 
            this.ResultText.AutoSize = true;
            this.ResultText.Location = new System.Drawing.Point(41, 38);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(61, 12);
            this.ResultText.TabIndex = 1;
            this.ResultText.Text = "ResultText";
            // 
            // TokenInfoText
            // 
            this.TokenInfoText.AutoSize = true;
            this.TokenInfoText.Location = new System.Drawing.Point(293, 38);
            this.TokenInfoText.Name = "TokenInfoText";
            this.TokenInfoText.Size = new System.Drawing.Size(78, 12);
            this.TokenInfoText.TabIndex = 2;
            this.TokenInfoText.Text = "TokenInfoText";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 175);
            this.Controls.Add(this.TokenInfoText);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ResultText;
        private System.Windows.Forms.Label TokenInfoText;
    }
}

