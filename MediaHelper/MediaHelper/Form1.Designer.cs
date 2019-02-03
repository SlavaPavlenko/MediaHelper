namespace MediaHelper
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
            this.components = new System.ComponentModel.Container();
            this.Find_btn = new System.Windows.Forms.Button();
            this.Music_listb = new System.Windows.Forms.ListBox();
            this.Play_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Pause_btn = new System.Windows.Forms.Button();
            this.Playing_track = new System.Windows.Forms.LinkLabel();
            this.Playing_track_lbl = new System.Windows.Forms.Label();
            this.Next_btn = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            this.btnControl = new System.Windows.Forms.Timer(this.components);
            this.Previous_btn = new System.Windows.Forms.Button();
            this.Path_tb = new System.Windows.Forms.TextBox();
            this.Apply_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Find_btn
            // 
            this.Find_btn.Location = new System.Drawing.Point(12, 113);
            this.Find_btn.Name = "Find_btn";
            this.Find_btn.Size = new System.Drawing.Size(75, 23);
            this.Find_btn.TabIndex = 0;
            this.Find_btn.Text = "Find";
            this.Find_btn.UseVisualStyleBackColor = true;
            this.Find_btn.Click += new System.EventHandler(this.Find_btn_Click);
            // 
            // Music_listb
            // 
            this.Music_listb.FormattingEnabled = true;
            this.Music_listb.Location = new System.Drawing.Point(12, 12);
            this.Music_listb.Name = "Music_listb";
            this.Music_listb.Size = new System.Drawing.Size(454, 95);
            this.Music_listb.TabIndex = 1;
            this.Music_listb.Click += new System.EventHandler(this.Music_listb_Click);
            // 
            // Play_btn
            // 
            this.Play_btn.Enabled = false;
            this.Play_btn.Location = new System.Drawing.Point(93, 113);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(75, 23);
            this.Play_btn.TabIndex = 2;
            this.Play_btn.Text = "Play";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Enabled = false;
            this.Stop_btn.Location = new System.Drawing.Point(255, 113);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(75, 23);
            this.Stop_btn.TabIndex = 3;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Pause_btn
            // 
            this.Pause_btn.Enabled = false;
            this.Pause_btn.Location = new System.Drawing.Point(174, 113);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(75, 23);
            this.Pause_btn.TabIndex = 4;
            this.Pause_btn.Text = "Pause";
            this.Pause_btn.UseVisualStyleBackColor = true;
            this.Pause_btn.Click += new System.EventHandler(this.Pause_btn_Click);
            // 
            // Playing_track
            // 
            this.Playing_track.AutoSize = true;
            this.Playing_track.Location = new System.Drawing.Point(87, 210);
            this.Playing_track.Name = "Playing_track";
            this.Playing_track.Size = new System.Drawing.Size(0, 13);
            this.Playing_track.TabIndex = 5;
            this.Playing_track.Click += new System.EventHandler(this.Playing_track_Click);
            // 
            // Playing_track_lbl
            // 
            this.Playing_track_lbl.AutoSize = true;
            this.Playing_track_lbl.Location = new System.Drawing.Point(12, 210);
            this.Playing_track_lbl.Name = "Playing_track_lbl";
            this.Playing_track_lbl.Size = new System.Drawing.Size(67, 13);
            this.Playing_track_lbl.TabIndex = 6;
            this.Playing_track_lbl.Text = "Playing now:";
            // 
            // Next_btn
            // 
            this.Next_btn.Enabled = false;
            this.Next_btn.Location = new System.Drawing.Point(174, 154);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(75, 23);
            this.Next_btn.TabIndex = 7;
            this.Next_btn.Text = "Next";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(12, 182);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(21, 13);
            this.log.TabIndex = 8;
            this.log.Text = "log";
            // 
            // btnControl
            // 
            this.btnControl.Enabled = true;
            this.btnControl.Tick += new System.EventHandler(this.btnControl_Tick);
            // 
            // Previous_btn
            // 
            this.Previous_btn.Location = new System.Drawing.Point(93, 154);
            this.Previous_btn.Name = "Previous_btn";
            this.Previous_btn.Size = new System.Drawing.Size(75, 23);
            this.Previous_btn.TabIndex = 9;
            this.Previous_btn.Text = "Previous";
            this.Previous_btn.UseVisualStyleBackColor = true;
            this.Previous_btn.Click += new System.EventHandler(this.Previous_btn_Click);
            // 
            // Path_tb
            // 
            this.Path_tb.Location = new System.Drawing.Point(255, 200);
            this.Path_tb.Name = "Path_tb";
            this.Path_tb.Size = new System.Drawing.Size(211, 20);
            this.Path_tb.TabIndex = 10;
            // 
            // Apply_btn
            // 
            this.Apply_btn.Location = new System.Drawing.Point(390, 171);
            this.Apply_btn.Name = "Apply_btn";
            this.Apply_btn.Size = new System.Drawing.Size(75, 23);
            this.Apply_btn.TabIndex = 11;
            this.Apply_btn.Text = "Apply";
            this.Apply_btn.UseVisualStyleBackColor = true;
            this.Apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 232);
            this.Controls.Add(this.Apply_btn);
            this.Controls.Add(this.Path_tb);
            this.Controls.Add(this.Previous_btn);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.Playing_track_lbl);
            this.Controls.Add(this.Playing_track);
            this.Controls.Add(this.Pause_btn);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.Music_listb);
            this.Controls.Add(this.Find_btn);
            this.Name = "Form1";
            this.Text = "MediaHelper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Find_btn;
        private System.Windows.Forms.ListBox Music_listb;
        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button Pause_btn;
        private System.Windows.Forms.LinkLabel Playing_track;
        private System.Windows.Forms.Label Playing_track_lbl;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Timer btnControl;
        private System.Windows.Forms.Button Previous_btn;
        private System.Windows.Forms.TextBox Path_tb;
        private System.Windows.Forms.Button Apply_btn;
    }
}

