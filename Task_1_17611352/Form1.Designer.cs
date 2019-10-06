namespace Task_1_17611352
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Unit_Display_Label = new System.Windows.Forms.Label();
            this.Round_Display_Label = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Pause_Button = new System.Windows.Forms.Button();
            this.Display_Group_Box = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Test_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Unit_Display_Label
            // 
            this.Unit_Display_Label.AutoSize = true;
            this.Unit_Display_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit_Display_Label.Location = new System.Drawing.Point(12, 9);
            this.Unit_Display_Label.Name = "Unit_Display_Label";
            this.Unit_Display_Label.Size = new System.Drawing.Size(177, 25);
            this.Unit_Display_Label.TabIndex = 0;
            this.Unit_Display_Label.Text = "Unit Display Space";
            // 
            // Round_Display_Label
            // 
            this.Round_Display_Label.AutoSize = true;
            this.Round_Display_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Round_Display_Label.Location = new System.Drawing.Point(547, 9);
            this.Round_Display_Label.Name = "Round_Display_Label";
            this.Round_Display_Label.Size = new System.Drawing.Size(177, 25);
            this.Round_Display_Label.TabIndex = 1;
            this.Round_Display_Label.Text = "Round Display Box";
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.Location = new System.Drawing.Point(229, 54);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(77, 38);
            this.Start_Button.TabIndex = 2;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Pause_Button
            // 
            this.Pause_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause_Button.Location = new System.Drawing.Point(400, 54);
            this.Pause_Button.Name = "Pause_Button";
            this.Pause_Button.Size = new System.Drawing.Size(77, 38);
            this.Pause_Button.TabIndex = 3;
            this.Pause_Button.Text = "Pause";
            this.Pause_Button.UseVisualStyleBackColor = true;
            this.Pause_Button.Click += new System.EventHandler(this.Pause_Button_Click);
            // 
            // Display_Group_Box
            // 
            this.Display_Group_Box.Location = new System.Drawing.Point(24, 123);
            this.Display_Group_Box.Name = "Display_Group_Box";
            this.Display_Group_Box.Size = new System.Drawing.Size(706, 425);
            this.Display_Group_Box.TabIndex = 4;
            this.Display_Group_Box.TabStop = false;
            this.Display_Group_Box.Text = "Battlefield";
            this.Display_Group_Box.Enter += new System.EventHandler(this.Display_Group_Box_Enter);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Test_Label
            // 
            this.Test_Label.AutoSize = true;
            this.Test_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_Label.Location = new System.Drawing.Point(592, 88);
            this.Test_Label.Name = "Test_Label";
            this.Test_Label.Size = new System.Drawing.Size(181, 25);
            this.Test_Label.TabIndex = 5;
            this.Test_Label.Text = "Death_Test_Health";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 571);
            this.Controls.Add(this.Test_Label);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Display_Group_Box);
            this.Controls.Add(this.Pause_Button);
            this.Controls.Add(this.Round_Display_Label);
            this.Controls.Add(this.Unit_Display_Label);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Unit_Display_Label;
        private System.Windows.Forms.Label Round_Display_Label;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Pause_Button;
        private System.Windows.Forms.GroupBox Display_Group_Box;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Test_Label;
    }
}

