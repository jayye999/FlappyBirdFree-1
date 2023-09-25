namespace Flappy_Bird_Windows_Form
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ScoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.restartImage = new System.Windows.Forms.PictureBox();
            this.PipeButton = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.Group = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.restartImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Black;
            this.ScoreText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScoreText.Font = new System.Drawing.Font("Arial", 18.32727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.ForeColor = System.Drawing.Color.Yellow;
            this.ScoreText.Location = new System.Drawing.Point(81, 700);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(138, 35);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score: 0 ";
            this.ScoreText.Click += new System.EventHandler(this.Label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimereEvent);
            // 
            // restartImage
            // 
            this.restartImage.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.back_arrow_7468287;
            this.restartImage.Location = new System.Drawing.Point(12, 12);
            this.restartImage.Name = "restartImage";
            this.restartImage.Size = new System.Drawing.Size(91, 84);
            this.restartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restartImage.TabIndex = 5;
            this.restartImage.TabStop = false;
            this.restartImage.Click += new System.EventHandler(this.ReStartClickEvent);
            // 
            // PipeButton
            // 
            this.PipeButton.Image = ((System.Drawing.Image)(resources.GetObject("PipeButton.Image")));
            this.PipeButton.Location = new System.Drawing.Point(388, 440);
            this.PipeButton.Name = "PipeButton";
            this.PipeButton.Size = new System.Drawing.Size(117, 234);
            this.PipeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeButton.TabIndex = 3;
            this.PipeButton.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(109, 12);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(78, 61);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 1;
            this.FlappyBird.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(481, -21);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(113, 261);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 0;
            this.PipeTop.TabStop = false;
            // 
            // Group
            // 
            this.Group.Image = ((System.Drawing.Image)(resources.GetObject("Group.Image")));
            this.Group.Location = new System.Drawing.Point(-22, 674);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(873, 90);
            this.Group.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Group.TabIndex = 2;
            this.Group.TabStop = false;
            this.Group.Click += new System.EventHandler(this.Group_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(730, 739);
            this.Controls.Add(this.restartImage);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.PipeButton);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.Group);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Flappy Bird ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.restartImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox Group;
        private System.Windows.Forms.PictureBox PipeButton;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox restartImage;
    }
}

