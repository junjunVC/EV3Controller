namespace EV3Controller
{
    partial class Controller
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.Connect = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.PortNameLabel = new System.Windows.Forms.Label();
            this.PortNameTaxtBox = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(206, 32);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 20;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(118, 98);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(38, 23);
            this.Forward.TabIndex = 40;
            this.Forward.Text = "↑";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(206, 61);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 30;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // PortNameLabel
            // 
            this.PortNameLabel.AutoSize = true;
            this.PortNameLabel.Location = new System.Drawing.Point(22, 37);
            this.PortNameLabel.Name = "PortNameLabel";
            this.PortNameLabel.Size = new System.Drawing.Size(59, 12);
            this.PortNameLabel.TabIndex = 3;
            this.PortNameLabel.Text = "Port Name";
            // 
            // PortNameTaxtBox
            // 
            this.PortNameTaxtBox.Location = new System.Drawing.Point(87, 34);
            this.PortNameTaxtBox.Name = "PortNameTaxtBox";
            this.PortNameTaxtBox.Size = new System.Drawing.Size(100, 19);
            this.PortNameTaxtBox.TabIndex = 10;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(118, 127);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(38, 23);
            this.Stop.TabIndex = 60;
            this.Stop.Text = "・";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(162, 127);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(38, 23);
            this.Right.TabIndex = 70;
            this.Right.Text = "→";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(74, 127);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(38, 23);
            this.Left.TabIndex = 50;
            this.Left.Text = "←";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(118, 156);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(38, 23);
            this.Back.TabIndex = 80;
            this.Back.Text = "↓";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayLabel.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DisplayLabel.Location = new System.Drawing.Point(78, 198);
            this.DisplayLabel.MaximumSize = new System.Drawing.Size(120, 40);
            this.DisplayLabel.MinimumSize = new System.Drawing.Size(120, 40);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(120, 40);
            this.DisplayLabel.TabIndex = 45;
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 262);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.PortNameTaxtBox);
            this.Controls.Add(this.PortNameLabel);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Connect);
            this.Name = "Controller";
            this.Text = "Controller";
            this.Load += new System.EventHandler(this.Controller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label PortNameLabel;
        private System.Windows.Forms.TextBox PortNameTaxtBox;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label DisplayLabel;
    }
}

