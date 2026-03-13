namespace SuperSudokuSolver
{
    partial class MainForm
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
            panel1 = new Panel();
            openFileDialogPicture = new OpenFileDialog();
            MainSplitContainer = new SplitContainer();
            pictureBox = new PictureBox();
            buttonChoosePicture = new Button();
            buttonSolve = new Button();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 328);
            panel1.TabIndex = 0;
            // 
            // openFileDialogPicture
            // 
            openFileDialogPicture.FileName = "openFileDialog1";
            openFileDialogPicture.Filter = "\"jpeg|*.jpeg|png|*.png|jpg|*.jpg\"";
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(0, 0);
            MainSplitContainer.Name = "MainSplitContainer";
            MainSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(pictureBox);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(buttonChoosePicture);
            MainSplitContainer.Panel2.Controls.Add(buttonSolve);
            MainSplitContainer.Size = new Size(706, 328);
            MainSplitContainer.SplitterDistance = 235;
            MainSplitContainer.TabIndex = 1;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(706, 235);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // buttonChoosePicture
            // 
            buttonChoosePicture.Location = new Point(12, 14);
            buttonChoosePicture.Name = "buttonChoosePicture";
            buttonChoosePicture.Size = new Size(142, 23);
            buttonChoosePicture.TabIndex = 1;
            buttonChoosePicture.Text = "Выбрать изображение";
            buttonChoosePicture.UseVisualStyleBackColor = true;
            buttonChoosePicture.Click += buttonChoosePicture_Click;
            // 
            // buttonSolve
            // 
            buttonSolve.Location = new Point(160, 14);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(75, 23);
            buttonSolve.TabIndex = 0;
            buttonSolve.Text = "Решить";
            buttonSolve.UseVisualStyleBackColor = true;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(706, 328);
            Controls.Add(MainSplitContainer);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Super Sudoku Solver";
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel1.PerformLayout();
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private OpenFileDialog openFileDialogPicture;
        private SplitContainer MainSplitContainer;
        private PictureBox pictureBox;
        private Button buttonChoosePicture;
        private Button buttonSolve;
    }
}