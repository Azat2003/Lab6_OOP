namespace PR2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.squareButton = new System.Windows.Forms.Button();
            this.ringButton = new System.Windows.Forms.Button();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.rollUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EllipseDraw = new System.Windows.Forms.Button();
            this.RingDraw = new System.Windows.Forms.Button();
            this.RectangleDraw = new System.Windows.Forms.Button();
            this.SquareDraw = new System.Windows.Forms.Button();
            this.helpySecondX = new System.Windows.Forms.Label();
            this.helpySecondY = new System.Windows.Forms.Label();
            this.fourthInputLine = new System.Windows.Forms.TextBox();
            this.thirdInputLine = new System.Windows.Forms.TextBox();
            this.helpySecondLine = new System.Windows.Forms.Label();
            this.secondInputLine = new System.Windows.Forms.TextBox();
            this.helpyFirstY = new System.Windows.Forms.Label();
            this.firstInputLine = new System.Windows.Forms.TextBox();
            this.helpyFirstX = new System.Windows.Forms.Label();
            this.helpyFirstLine = new System.Windows.Forms.Label();
            this.moveButton = new System.Windows.Forms.Button();
            this.changeRingButton = new System.Windows.Forms.Button();
            this.figuresList = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmActionDeleteButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.confirmActionChangeRectangleButton = new System.Windows.Forms.Button();
            this.changeRectangleButton = new System.Windows.Forms.Button();
            this.confirmActionChangeRingButton = new System.Windows.Forms.Button();
            this.cancelActionButton = new System.Windows.Forms.Button();
            this.confirmActionMoveButton = new System.Windows.Forms.Button();
            this.helpySecondActionText = new System.Windows.Forms.Label();
            this.helpyFirstActionText = new System.Windows.Forms.Label();
            this.secondActionInputPanel = new System.Windows.Forms.TextBox();
            this.firstActionInputPanel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // squareButton
            // 
            this.squareButton.BackColor = System.Drawing.Color.Red;
            this.squareButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareButton.Location = new System.Drawing.Point(585, 12);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(86, 23);
            this.squareButton.TabIndex = 2;
            this.squareButton.Text = "Квадрат";
            this.squareButton.UseVisualStyleBackColor = false;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // ringButton
            // 
            this.ringButton.BackColor = System.Drawing.Color.Red;
            this.ringButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ringButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ringButton.Location = new System.Drawing.Point(585, 41);
            this.ringButton.Name = "ringButton";
            this.ringButton.Size = new System.Drawing.Size(86, 23);
            this.ringButton.TabIndex = 3;
            this.ringButton.Text = "Окружность";
            this.ringButton.UseVisualStyleBackColor = false;
            this.ringButton.Click += new System.EventHandler(this.ringButton_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.BackColor = System.Drawing.Color.Red;
            this.ellipseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton.Location = new System.Drawing.Point(677, 41);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(99, 23);
            this.ellipseButton.TabIndex = 4;
            this.ellipseButton.Text = "Эллипс";
            this.ellipseButton.UseVisualStyleBackColor = false;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.BackColor = System.Drawing.Color.Red;
            this.rectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Location = new System.Drawing.Point(677, 12);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(99, 23);
            this.rectangleButton.TabIndex = 5;
            this.rectangleButton.Text = "Прямоугольник";
            this.rectangleButton.UseVisualStyleBackColor = false;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // rollUp
            // 
            this.rollUp.BackColor = System.Drawing.Color.Navy;
            this.rollUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rollUp.BackgroundImage")));
            this.rollUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rollUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollUp.Enabled = false;
            this.rollUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rollUp.ForeColor = System.Drawing.Color.Navy;
            this.rollUp.Location = new System.Drawing.Point(178, 154);
            this.rollUp.Name = "rollUp";
            this.rollUp.Size = new System.Drawing.Size(27, 28);
            this.rollUp.TabIndex = 15;
            this.rollUp.UseVisualStyleBackColor = false;
            this.rollUp.Visible = false;
            this.rollUp.Click += new System.EventHandler(this.rollUp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.helpySecondX);
            this.panel1.Controls.Add(this.rollUp);
            this.panel1.Controls.Add(this.helpySecondY);
            this.panel1.Controls.Add(this.fourthInputLine);
            this.panel1.Controls.Add(this.thirdInputLine);
            this.panel1.Controls.Add(this.helpySecondLine);
            this.panel1.Controls.Add(this.secondInputLine);
            this.panel1.Controls.Add(this.helpyFirstY);
            this.panel1.Controls.Add(this.firstInputLine);
            this.panel1.Controls.Add(this.helpyFirstX);
            this.panel1.Controls.Add(this.helpyFirstLine);
            this.panel1.Location = new System.Drawing.Point(585, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 182);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // EllipseDraw
            // 
            this.EllipseDraw.BackColor = System.Drawing.Color.Navy;
            this.EllipseDraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EllipseDraw.BackgroundImage")));
            this.EllipseDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EllipseDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EllipseDraw.Enabled = false;
            this.EllipseDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EllipseDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EllipseDraw.ForeColor = System.Drawing.Color.Navy;
            this.EllipseDraw.Location = new System.Drawing.Point(479, 224);
            this.EllipseDraw.Name = "EllipseDraw";
            this.EllipseDraw.Size = new System.Drawing.Size(45, 37);
            this.EllipseDraw.TabIndex = 28;
            this.EllipseDraw.UseVisualStyleBackColor = false;
            this.EllipseDraw.Visible = false;
            this.EllipseDraw.Click += new System.EventHandler(this.EllipseDraw_Click);
            // 
            // RingDraw
            // 
            this.RingDraw.BackColor = System.Drawing.Color.Navy;
            this.RingDraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RingDraw.BackgroundImage")));
            this.RingDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RingDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RingDraw.Enabled = false;
            this.RingDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RingDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RingDraw.ForeColor = System.Drawing.Color.Navy;
            this.RingDraw.Location = new System.Drawing.Point(401, 166);
            this.RingDraw.Name = "RingDraw";
            this.RingDraw.Size = new System.Drawing.Size(45, 37);
            this.RingDraw.TabIndex = 27;
            this.RingDraw.UseVisualStyleBackColor = false;
            this.RingDraw.Visible = false;
            this.RingDraw.Click += new System.EventHandler(this.RingDraw_Click);
            // 
            // RectangleDraw
            // 
            this.RectangleDraw.BackColor = System.Drawing.Color.Navy;
            this.RectangleDraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RectangleDraw.BackgroundImage")));
            this.RectangleDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RectangleDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RectangleDraw.Enabled = false;
            this.RectangleDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectangleDraw.ForeColor = System.Drawing.Color.Navy;
            this.RectangleDraw.Location = new System.Drawing.Point(438, 121);
            this.RectangleDraw.Name = "RectangleDraw";
            this.RectangleDraw.Size = new System.Drawing.Size(45, 37);
            this.RectangleDraw.TabIndex = 26;
            this.RectangleDraw.UseVisualStyleBackColor = false;
            this.RectangleDraw.Visible = false;
            this.RectangleDraw.Click += new System.EventHandler(this.RectangleDraw_Click);
            // 
            // SquareDraw
            // 
            this.SquareDraw.BackColor = System.Drawing.Color.Navy;
            this.SquareDraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SquareDraw.BackgroundImage")));
            this.SquareDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SquareDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SquareDraw.Enabled = false;
            this.SquareDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquareDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareDraw.ForeColor = System.Drawing.Color.Navy;
            this.SquareDraw.Location = new System.Drawing.Point(537, 178);
            this.SquareDraw.Name = "SquareDraw";
            this.SquareDraw.Size = new System.Drawing.Size(45, 37);
            this.SquareDraw.TabIndex = 25;
            this.SquareDraw.UseVisualStyleBackColor = false;
            this.SquareDraw.Visible = false;
            this.SquareDraw.Click += new System.EventHandler(this.SquareDraw_Click);
            // 
            // helpySecondX
            // 
            this.helpySecondX.AutoSize = true;
            this.helpySecondX.Enabled = false;
            this.helpySecondX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpySecondX.Location = new System.Drawing.Point(3, 96);
            this.helpySecondX.Name = "helpySecondX";
            this.helpySecondX.Size = new System.Drawing.Size(25, 20);
            this.helpySecondX.TabIndex = 24;
            this.helpySecondX.Text = "X:";
            this.helpySecondX.Visible = false;
            // 
            // helpySecondY
            // 
            this.helpySecondY.AutoSize = true;
            this.helpySecondY.Enabled = false;
            this.helpySecondY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpySecondY.Location = new System.Drawing.Point(99, 96);
            this.helpySecondY.Name = "helpySecondY";
            this.helpySecondY.Size = new System.Drawing.Size(24, 20);
            this.helpySecondY.TabIndex = 23;
            this.helpySecondY.Text = "Y:";
            this.helpySecondY.Visible = false;
            // 
            // fourthInputLine
            // 
            this.fourthInputLine.Enabled = false;
            this.fourthInputLine.Location = new System.Drawing.Point(124, 92);
            this.fourthInputLine.Name = "fourthInputLine";
            this.fourthInputLine.Size = new System.Drawing.Size(66, 20);
            this.fourthInputLine.TabIndex = 22;
            this.fourthInputLine.Visible = false;
            // 
            // thirdInputLine
            // 
            this.thirdInputLine.Enabled = false;
            this.thirdInputLine.Location = new System.Drawing.Point(27, 92);
            this.thirdInputLine.Name = "thirdInputLine";
            this.thirdInputLine.Size = new System.Drawing.Size(66, 20);
            this.thirdInputLine.TabIndex = 21;
            this.thirdInputLine.Visible = false;
            // 
            // helpySecondLine
            // 
            this.helpySecondLine.AutoSize = true;
            this.helpySecondLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpySecondLine.Location = new System.Drawing.Point(3, 63);
            this.helpySecondLine.Name = "helpySecondLine";
            this.helpySecondLine.Size = new System.Drawing.Size(181, 25);
            this.helpySecondLine.TabIndex = 17;
            this.helpySecondLine.Text = "Сторона квадрата";
            this.helpySecondLine.Visible = false;
            // 
            // secondInputLine
            // 
            this.secondInputLine.Enabled = false;
            this.secondInputLine.Location = new System.Drawing.Point(124, 29);
            this.secondInputLine.Name = "secondInputLine";
            this.secondInputLine.Size = new System.Drawing.Size(66, 20);
            this.secondInputLine.TabIndex = 20;
            this.secondInputLine.Visible = false;
            // 
            // helpyFirstY
            // 
            this.helpyFirstY.AutoSize = true;
            this.helpyFirstY.Enabled = false;
            this.helpyFirstY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpyFirstY.Location = new System.Drawing.Point(99, 33);
            this.helpyFirstY.Name = "helpyFirstY";
            this.helpyFirstY.Size = new System.Drawing.Size(24, 20);
            this.helpyFirstY.TabIndex = 19;
            this.helpyFirstY.Text = "Y:";
            this.helpyFirstY.Visible = false;
            // 
            // firstInputLine
            // 
            this.firstInputLine.Enabled = false;
            this.firstInputLine.Location = new System.Drawing.Point(27, 29);
            this.firstInputLine.Name = "firstInputLine";
            this.firstInputLine.Size = new System.Drawing.Size(66, 20);
            this.firstInputLine.TabIndex = 18;
            this.firstInputLine.Visible = false;
            // 
            // helpyFirstX
            // 
            this.helpyFirstX.AutoSize = true;
            this.helpyFirstX.Enabled = false;
            this.helpyFirstX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpyFirstX.Location = new System.Drawing.Point(3, 33);
            this.helpyFirstX.Name = "helpyFirstX";
            this.helpyFirstX.Size = new System.Drawing.Size(25, 20);
            this.helpyFirstX.TabIndex = 17;
            this.helpyFirstX.Text = "X:";
            this.helpyFirstX.Visible = false;
            // 
            // helpyFirstLine
            // 
            this.helpyFirstLine.AutoSize = true;
            this.helpyFirstLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpyFirstLine.Location = new System.Drawing.Point(-3, 0);
            this.helpyFirstLine.Name = "helpyFirstLine";
            this.helpyFirstLine.Size = new System.Drawing.Size(270, 20);
            this.helpyFirstLine.TabIndex = 3;
            this.helpyFirstLine.Text = "Координаты центра квадрата \r\n";
            this.helpyFirstLine.Visible = false;
            // 
            // moveButton
            // 
            this.moveButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.moveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveButton.Location = new System.Drawing.Point(3, 145);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(86, 44);
            this.moveButton.TabIndex = 17;
            this.moveButton.Text = "Переместить";
            this.moveButton.UseVisualStyleBackColor = false;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // changeRingButton
            // 
            this.changeRingButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.changeRingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changeRingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeRingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeRingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeRingButton.Location = new System.Drawing.Point(3, 46);
            this.changeRingButton.Name = "changeRingButton";
            this.changeRingButton.Size = new System.Drawing.Size(86, 42);
            this.changeRingButton.TabIndex = 18;
            this.changeRingButton.Text = "Изменить окружность";
            this.changeRingButton.UseVisualStyleBackColor = false;
            this.changeRingButton.Click += new System.EventHandler(this.changeRingButton_Click);
            // 
            // figuresList
            // 
            this.figuresList.Enabled = false;
            this.figuresList.FormattingEnabled = true;
            this.figuresList.Location = new System.Drawing.Point(92, 68);
            this.figuresList.Name = "figuresList";
            this.figuresList.Size = new System.Drawing.Size(113, 124);
            this.figuresList.TabIndex = 19;
            this.figuresList.Visible = false;
            this.figuresList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.figuresList_ItemCheck);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.confirmActionDeleteButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.confirmActionChangeRectangleButton);
            this.panel2.Controls.Add(this.changeRectangleButton);
            this.panel2.Controls.Add(this.confirmActionChangeRingButton);
            this.panel2.Controls.Add(this.cancelActionButton);
            this.panel2.Controls.Add(this.confirmActionMoveButton);
            this.panel2.Controls.Add(this.helpySecondActionText);
            this.panel2.Controls.Add(this.helpyFirstActionText);
            this.panel2.Controls.Add(this.secondActionInputPanel);
            this.panel2.Controls.Add(this.figuresList);
            this.panel2.Controls.Add(this.firstActionInputPanel);
            this.panel2.Controls.Add(this.changeRingButton);
            this.panel2.Controls.Add(this.moveButton);
            this.panel2.Location = new System.Drawing.Point(585, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 192);
            this.panel2.TabIndex = 20;
            // 
            // confirmActionDeleteButton
            // 
            this.confirmActionDeleteButton.BackColor = System.Drawing.Color.Red;
            this.confirmActionDeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmActionDeleteButton.BackgroundImage")));
            this.confirmActionDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmActionDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmActionDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmActionDeleteButton.ForeColor = System.Drawing.Color.Red;
            this.confirmActionDeleteButton.Location = new System.Drawing.Point(136, 34);
            this.confirmActionDeleteButton.Name = "confirmActionDeleteButton";
            this.confirmActionDeleteButton.Size = new System.Drawing.Size(30, 30);
            this.confirmActionDeleteButton.TabIndex = 26;
            this.confirmActionDeleteButton.UseVisualStyleBackColor = false;
            this.confirmActionDeleteButton.Visible = false;
            this.confirmActionDeleteButton.Click += new System.EventHandler(this.confirmActionDeleteButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(97, 34);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(33, 30);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // confirmActionChangeRectangleButton
            // 
            this.confirmActionChangeRectangleButton.BackColor = System.Drawing.Color.Red;
            this.confirmActionChangeRectangleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmActionChangeRectangleButton.BackgroundImage")));
            this.confirmActionChangeRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmActionChangeRectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmActionChangeRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmActionChangeRectangleButton.ForeColor = System.Drawing.Color.Red;
            this.confirmActionChangeRectangleButton.Location = new System.Drawing.Point(136, 34);
            this.confirmActionChangeRectangleButton.Name = "confirmActionChangeRectangleButton";
            this.confirmActionChangeRectangleButton.Size = new System.Drawing.Size(30, 30);
            this.confirmActionChangeRectangleButton.TabIndex = 25;
            this.confirmActionChangeRectangleButton.UseVisualStyleBackColor = false;
            this.confirmActionChangeRectangleButton.Visible = false;
            this.confirmActionChangeRectangleButton.Click += new System.EventHandler(this.confirmActionChangeRectangleButton_Click);
            // 
            // changeRectangleButton
            // 
            this.changeRectangleButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.changeRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changeRectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeRectangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeRectangleButton.Location = new System.Drawing.Point(3, 94);
            this.changeRectangleButton.Name = "changeRectangleButton";
            this.changeRectangleButton.Size = new System.Drawing.Size(86, 45);
            this.changeRectangleButton.TabIndex = 25;
            this.changeRectangleButton.Text = "Изменить прямоугольник";
            this.changeRectangleButton.UseVisualStyleBackColor = false;
            this.changeRectangleButton.Click += new System.EventHandler(this.changeRectangleButton_Click);
            // 
            // confirmActionChangeRingButton
            // 
            this.confirmActionChangeRingButton.BackColor = System.Drawing.Color.Red;
            this.confirmActionChangeRingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmActionChangeRingButton.BackgroundImage")));
            this.confirmActionChangeRingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmActionChangeRingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmActionChangeRingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmActionChangeRingButton.ForeColor = System.Drawing.Color.Red;
            this.confirmActionChangeRingButton.Location = new System.Drawing.Point(136, 34);
            this.confirmActionChangeRingButton.Name = "confirmActionChangeRingButton";
            this.confirmActionChangeRingButton.Size = new System.Drawing.Size(30, 30);
            this.confirmActionChangeRingButton.TabIndex = 24;
            this.confirmActionChangeRingButton.UseVisualStyleBackColor = false;
            this.confirmActionChangeRingButton.Visible = false;
            this.confirmActionChangeRingButton.Click += new System.EventHandler(this.confirmActionChangeRingButton_Click);
            // 
            // cancelActionButton
            // 
            this.cancelActionButton.BackColor = System.Drawing.Color.Red;
            this.cancelActionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelActionButton.BackgroundImage")));
            this.cancelActionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelActionButton.ForeColor = System.Drawing.Color.Red;
            this.cancelActionButton.Location = new System.Drawing.Point(172, 34);
            this.cancelActionButton.Name = "cancelActionButton";
            this.cancelActionButton.Size = new System.Drawing.Size(30, 30);
            this.cancelActionButton.TabIndex = 24;
            this.cancelActionButton.UseVisualStyleBackColor = false;
            this.cancelActionButton.Visible = false;
            this.cancelActionButton.Click += new System.EventHandler(this.cancelActionButton_Click);
            // 
            // confirmActionMoveButton
            // 
            this.confirmActionMoveButton.BackColor = System.Drawing.Color.Red;
            this.confirmActionMoveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmActionMoveButton.BackgroundImage")));
            this.confirmActionMoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmActionMoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmActionMoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmActionMoveButton.ForeColor = System.Drawing.Color.Red;
            this.confirmActionMoveButton.Location = new System.Drawing.Point(136, 34);
            this.confirmActionMoveButton.Name = "confirmActionMoveButton";
            this.confirmActionMoveButton.Size = new System.Drawing.Size(30, 30);
            this.confirmActionMoveButton.TabIndex = 23;
            this.confirmActionMoveButton.UseVisualStyleBackColor = false;
            this.confirmActionMoveButton.Visible = false;
            this.confirmActionMoveButton.Click += new System.EventHandler(this.confirmActionMoveButton_Click);
            // 
            // helpySecondActionText
            // 
            this.helpySecondActionText.AutoSize = true;
            this.helpySecondActionText.Enabled = false;
            this.helpySecondActionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpySecondActionText.Location = new System.Drawing.Point(102, 10);
            this.helpySecondActionText.Name = "helpySecondActionText";
            this.helpySecondActionText.Size = new System.Drawing.Size(24, 20);
            this.helpySecondActionText.TabIndex = 22;
            this.helpySecondActionText.Text = "Y:";
            this.helpySecondActionText.Visible = false;
            // 
            // helpyFirstActionText
            // 
            this.helpyFirstActionText.AutoSize = true;
            this.helpyFirstActionText.Enabled = false;
            this.helpyFirstActionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpyFirstActionText.Location = new System.Drawing.Point(3, 9);
            this.helpyFirstActionText.Name = "helpyFirstActionText";
            this.helpyFirstActionText.Size = new System.Drawing.Size(25, 20);
            this.helpyFirstActionText.TabIndex = 21;
            this.helpyFirstActionText.Text = "X:";
            this.helpyFirstActionText.Visible = false;
            // 
            // secondActionInputPanel
            // 
            this.secondActionInputPanel.Enabled = false;
            this.secondActionInputPanel.Location = new System.Drawing.Point(127, 8);
            this.secondActionInputPanel.Name = "secondActionInputPanel";
            this.secondActionInputPanel.Size = new System.Drawing.Size(56, 20);
            this.secondActionInputPanel.TabIndex = 20;
            this.secondActionInputPanel.Visible = false;
            // 
            // firstActionInputPanel
            // 
            this.firstActionInputPanel.Enabled = false;
            this.firstActionInputPanel.Location = new System.Drawing.Point(30, 9);
            this.firstActionInputPanel.Name = "firstActionInputPanel";
            this.firstActionInputPanel.Size = new System.Drawing.Size(56, 20);
            this.firstActionInputPanel.TabIndex = 19;
            this.firstActionInputPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SquareDraw);
            this.Controls.Add(this.RectangleDraw);
            this.Controls.Add(this.RingDraw);
            this.Controls.Add(this.EllipseDraw);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.ellipseButton);
            this.Controls.Add(this.ringButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button ringButton;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button rollUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox secondInputLine;
        private System.Windows.Forms.Label helpyFirstY;
        private System.Windows.Forms.TextBox firstInputLine;
        private System.Windows.Forms.Label helpyFirstX;
        private System.Windows.Forms.Label helpyFirstLine;
        private System.Windows.Forms.Label helpySecondX;
        private System.Windows.Forms.Label helpySecondY;
        private System.Windows.Forms.TextBox fourthInputLine;
        private System.Windows.Forms.TextBox thirdInputLine;
        private System.Windows.Forms.Label helpySecondLine;
        private System.Windows.Forms.Button SquareDraw;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button changeRingButton;
        private System.Windows.Forms.CheckedListBox figuresList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelActionButton;
        private System.Windows.Forms.Button confirmActionMoveButton;
        private System.Windows.Forms.Label helpySecondActionText;
        private System.Windows.Forms.Label helpyFirstActionText;
        private System.Windows.Forms.TextBox secondActionInputPanel;
        private System.Windows.Forms.TextBox firstActionInputPanel;
        private System.Windows.Forms.Button changeRectangleButton;
        private System.Windows.Forms.Button RectangleDraw;
        private System.Windows.Forms.Button RingDraw;
        private System.Windows.Forms.Button EllipseDraw;
        private System.Windows.Forms.Button confirmActionChangeRingButton;
        private System.Windows.Forms.Button confirmActionChangeRectangleButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button confirmActionDeleteButton;
    }
}

