namespace _1A2B_遊戲
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.newGameButton = new System.Windows.Forms.Button();
			this.guessButton = new System.Windows.Forms.Button();
			this.guessTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// newGameButton
			// 
			this.newGameButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.newGameButton.Location = new System.Drawing.Point(381, 397);
			this.newGameButton.Name = "newGameButton";
			this.newGameButton.Size = new System.Drawing.Size(108, 37);
			this.newGameButton.TabIndex = 4;
			this.newGameButton.Text = "新遊戲";
			this.newGameButton.UseVisualStyleBackColor = true;
			this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
			// 
			// guessButton
			// 
			this.guessButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.guessButton.Location = new System.Drawing.Point(381, 37);
			this.guessButton.Name = "guessButton";
			this.guessButton.Size = new System.Drawing.Size(108, 34);
			this.guessButton.TabIndex = 2;
			this.guessButton.Text = "猜數字";
			this.guessButton.UseVisualStyleBackColor = true;
			this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
			// 
			// guessTextBox
			// 
			this.guessTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.guessTextBox.Location = new System.Drawing.Point(221, 37);
			this.guessTextBox.MaxLength = 4;
			this.guessTextBox.Name = "guessTextBox";
			this.guessTextBox.Size = new System.Drawing.Size(134, 33);
			this.guessTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(29, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(186, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "請輸入一個四位數字:";
			// 
			// resultTextBox
			// 
			this.resultTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultTextBox.Location = new System.Drawing.Point(44, 76);
			this.resultTextBox.Multiline = true;
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.ReadOnly = true;
			this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.resultTextBox.Size = new System.Drawing.Size(319, 358);
			this.resultTextBox.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 455);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.guessTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.guessButton);
			this.Controls.Add(this.newGameButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "1A2B遊戲";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button newGameButton;
		private System.Windows.Forms.Button guessButton;
		private System.Windows.Forms.TextBox guessTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox resultTextBox;
	}
}

