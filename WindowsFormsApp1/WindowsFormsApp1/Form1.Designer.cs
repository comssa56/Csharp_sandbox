namespace WindowsFormsApp1
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
            this.HelloWorldBtn = new System.Windows.Forms.Button();
            this.HelloWorldLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SquareParamY = new System.Windows.Forms.TextBox();
            this.SquareParamX = new System.Windows.Forms.TextBox();
            this.SquareParamYLabel = new System.Windows.Forms.Label();
            this.SquareParamXLabel = new System.Windows.Forms.Label();
            this.SquareCalcResultLabel = new System.Windows.Forms.Label();
            this.SquareCalcResult = new System.Windows.Forms.Label();
            this.MixStr = new System.Windows.Forms.Label();
            this.mixStrElem1Label = new System.Windows.Forms.Label();
            this.mixStrElem1 = new System.Windows.Forms.TextBox();
            this.mixStrElem2Label = new System.Windows.Forms.Label();
            this.mixStrElem2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mixStrResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelloWorldBtn
            // 
            this.HelloWorldBtn.Location = new System.Drawing.Point(118, 12);
            this.HelloWorldBtn.Name = "HelloWorldBtn";
            this.HelloWorldBtn.Size = new System.Drawing.Size(223, 172);
            this.HelloWorldBtn.TabIndex = 0;
            this.HelloWorldBtn.Text = "おせ！！";
            this.HelloWorldBtn.UseVisualStyleBackColor = true;
            this.HelloWorldBtn.Click += new System.EventHandler(this.HelloWorldBtnClick);
            this.HelloWorldBtn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HelloWorldBtnKeyUp);
            // 
            // HelloWorldLabel
            // 
            this.HelloWorldLabel.AutoSize = true;
            this.HelloWorldLabel.Location = new System.Drawing.Point(164, 226);
            this.HelloWorldLabel.Name = "HelloWorldLabel";
            this.HelloWorldLabel.Size = new System.Drawing.Size(126, 36);
            this.HelloWorldLabel.TabIndex = 1;
            this.HelloWorldLabel.Text = "にゃーん";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(42, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "秘密の箱";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.HimitsuBoxDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.HimitsuBoxDragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "・四角形の面積";
            // 
            // SquareParamY
            // 
            this.SquareParamY.Location = new System.Drawing.Point(654, 162);
            this.SquareParamY.Name = "SquareParamY";
            this.SquareParamY.Size = new System.Drawing.Size(250, 43);
            this.SquareParamY.TabIndex = 4;
            this.SquareParamY.TextChanged += new System.EventHandler(this.SquareParamY_TextChanged);
            // 
            // SquareParamX
            // 
            this.SquareParamX.Location = new System.Drawing.Point(654, 223);
            this.SquareParamX.Name = "SquareParamX";
            this.SquareParamX.Size = new System.Drawing.Size(250, 43);
            this.SquareParamX.TabIndex = 5;
            this.SquareParamX.TextChanged += new System.EventHandler(this.SquareParamX_TextChanged);
            // 
            // SquareParamYLabel
            // 
            this.SquareParamYLabel.AutoSize = true;
            this.SquareParamYLabel.Location = new System.Drawing.Point(580, 171);
            this.SquareParamYLabel.Name = "SquareParamYLabel";
            this.SquareParamYLabel.Size = new System.Drawing.Size(51, 36);
            this.SquareParamYLabel.TabIndex = 6;
            this.SquareParamYLabel.Text = "縦";
            // 
            // SquareParamXLabel
            // 
            this.SquareParamXLabel.AutoSize = true;
            this.SquareParamXLabel.Location = new System.Drawing.Point(580, 226);
            this.SquareParamXLabel.Name = "SquareParamXLabel";
            this.SquareParamXLabel.Size = new System.Drawing.Size(51, 36);
            this.SquareParamXLabel.TabIndex = 7;
            this.SquareParamXLabel.Text = "横";
            // 
            // SquareCalcResultLabel
            // 
            this.SquareCalcResultLabel.AutoSize = true;
            this.SquareCalcResultLabel.Location = new System.Drawing.Point(574, 298);
            this.SquareCalcResultLabel.Name = "SquareCalcResultLabel";
            this.SquareCalcResultLabel.Size = new System.Drawing.Size(159, 36);
            this.SquareCalcResultLabel.TabIndex = 8;
            this.SquareCalcResultLabel.Text = "計算結果";
            // 
            // SquareCalcResult
            // 
            this.SquareCalcResult.AutoSize = true;
            this.SquareCalcResult.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SquareCalcResult.Location = new System.Drawing.Point(648, 362);
            this.SquareCalcResult.Name = "SquareCalcResult";
            this.SquareCalcResult.Size = new System.Drawing.Size(0, 88);
            this.SquareCalcResult.TabIndex = 9;
            // 
            // MixStr
            // 
            this.MixStr.AutoSize = true;
            this.MixStr.Location = new System.Drawing.Point(1022, 98);
            this.MixStr.Name = "MixStr";
            this.MixStr.Size = new System.Drawing.Size(206, 36);
            this.MixStr.TabIndex = 10;
            this.MixStr.Text = "・文字の合成";
            // 
            // mixStrElem1Label
            // 
            this.mixStrElem1Label.AutoSize = true;
            this.mixStrElem1Label.Location = new System.Drawing.Point(1022, 171);
            this.mixStrElem1Label.Name = "mixStrElem1Label";
            this.mixStrElem1Label.Size = new System.Drawing.Size(105, 36);
            this.mixStrElem1Label.TabIndex = 11;
            this.mixStrElem1Label.Text = "文字1";
            // 
            // mixStrElem1
            // 
            this.mixStrElem1.Location = new System.Drawing.Point(1142, 168);
            this.mixStrElem1.Name = "mixStrElem1";
            this.mixStrElem1.Size = new System.Drawing.Size(250, 43);
            this.mixStrElem1.TabIndex = 12;
            this.mixStrElem1.TextChanged += new System.EventHandler(this.MixStrUpdate);
            // 
            // mixStrElem2Label
            // 
            this.mixStrElem2Label.AutoSize = true;
            this.mixStrElem2Label.Location = new System.Drawing.Point(1022, 230);
            this.mixStrElem2Label.Name = "mixStrElem2Label";
            this.mixStrElem2Label.Size = new System.Drawing.Size(105, 36);
            this.mixStrElem2Label.TabIndex = 13;
            this.mixStrElem2Label.Text = "文字2";
            // 
            // mixStrElem2
            // 
            this.mixStrElem2.Location = new System.Drawing.Point(1142, 227);
            this.mixStrElem2.Name = "mixStrElem2";
            this.mixStrElem2.Size = new System.Drawing.Size(250, 43);
            this.mixStrElem2.TabIndex = 14;
            this.mixStrElem2.TextChanged += new System.EventHandler(this.MixStrUpdate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1022, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "合成結果";
            // 
            // mixStrResult
            // 
            this.mixStrResult.AutoSize = true;
            this.mixStrResult.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mixStrResult.Location = new System.Drawing.Point(1117, 362);
            this.mixStrResult.Name = "mixStrResult";
            this.mixStrResult.Size = new System.Drawing.Size(0, 88);
            this.mixStrResult.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 633);
            this.Controls.Add(this.mixStrResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mixStrElem2);
            this.Controls.Add(this.mixStrElem2Label);
            this.Controls.Add(this.mixStrElem1);
            this.Controls.Add(this.mixStrElem1Label);
            this.Controls.Add(this.MixStr);
            this.Controls.Add(this.SquareCalcResult);
            this.Controls.Add(this.SquareCalcResultLabel);
            this.Controls.Add(this.SquareParamXLabel);
            this.Controls.Add(this.SquareParamYLabel);
            this.Controls.Add(this.SquareParamX);
            this.Controls.Add(this.SquareParamY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HelloWorldLabel);
            this.Controls.Add(this.HelloWorldBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HelloWorldLabel;
        private System.Windows.Forms.Button HelloWorldBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SquareParamY;
        private System.Windows.Forms.TextBox SquareParamX;
        private System.Windows.Forms.Label SquareParamYLabel;
        private System.Windows.Forms.Label SquareParamXLabel;
        private System.Windows.Forms.Label SquareCalcResultLabel;
        private System.Windows.Forms.Label SquareCalcResult;
        private System.Windows.Forms.Label MixStr;
        private System.Windows.Forms.Label mixStrElem1Label;
        private System.Windows.Forms.TextBox mixStrElem1;
        private System.Windows.Forms.Label mixStrElem2Label;
        private System.Windows.Forms.TextBox mixStrElem2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mixStrResult;
    }
}

