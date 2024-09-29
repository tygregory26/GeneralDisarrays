namespace FeatureInterface
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RunningButton = new Button();
            movingBox = new Panel();
            movingBox.SuspendLayout();
            SuspendLayout();
            // 
            // RunningButton
            // 
            RunningButton.Location = new Point(62, 44);
            RunningButton.Name = "RunningButton";
            RunningButton.Size = new Size(102, 43);
            RunningButton.TabIndex = 0;
            RunningButton.Text = "Push me!";
            RunningButton.UseVisualStyleBackColor = true;
            // 
            // movingBox
            // 
            movingBox.Controls.Add(RunningButton);
            movingBox.Location = new Point(66, 155);
            movingBox.Name = "movingBox";
            movingBox.Size = new Size(241, 130);
            movingBox.TabIndex = 1;
            movingBox.MouseEnter += movingBox_MouseEnter;
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(movingBox);
            Name = "mainWindow";
            Text = "Features";
            movingBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button RunningButton;
        private Panel movingBox;
    }
}
