namespace baseballSimul
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.BlueInput = new System.Windows.Forms.NumericUpDown();
            this.RedInput = new System.Windows.Forms.NumericUpDown();
            this.Reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BlueInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(599, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blue Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(598, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Red  Team";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(601, 161);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(182, 41);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "실행";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BlueInput
            // 
            this.BlueInput.Location = new System.Drawing.Point(712, 89);
            this.BlueInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BlueInput.Name = "BlueInput";
            this.BlueInput.Size = new System.Drawing.Size(71, 21);
            this.BlueInput.TabIndex = 5;
            // 
            // RedInput
            // 
            this.RedInput.Location = new System.Drawing.Point(712, 120);
            this.RedInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RedInput.Name = "RedInput";
            this.RedInput.Size = new System.Drawing.Size(71, 21);
            this.RedInput.TabIndex = 6;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(601, 218);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(182, 41);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "초기화";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 122);
            this.label3.TabIndex = 10;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "- 설명 -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "- 사용방법 -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(26, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 52);
            this.label6.TabIndex = 13;
            this.label6.Text = "1. Blue Team 과 Red Team 의 점수를 각각 입력해줍니다.\r\n   (단, Blue Team의 점수가 Red Team의 점수보다 높아" +
    "야 함)\r\n2. 실행을 눌러 결과를 확인한다.\r\n3. 초기화 버튼을 눌러 다른 결과도 확인해본다.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(600, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "- 점수입력 -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 316);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.RedInput);
            this.Controls.Add(this.BlueInput);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "야구게임 시뮬레이션";
            ((System.ComponentModel.ISupportInitialize)(this.BlueInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.NumericUpDown BlueInput;
        private System.Windows.Forms.NumericUpDown RedInput;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

