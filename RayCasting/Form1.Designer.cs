namespace RayCasting
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFullscreen = new System.Windows.Forms.Panel();
            this.listBoxFulscreen = new System.Windows.Forms.ListBox();
            this.panelCustom = new System.Windows.Forms.Panel();
            this.radioButtonFullscreen = new System.Windows.Forms.RadioButton();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFullscreen.SuspendLayout();
            this.panelCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFullscreen
            // 
            this.panelFullscreen.Controls.Add(this.listBoxFulscreen);
            this.panelFullscreen.Location = new System.Drawing.Point(12, 39);
            this.panelFullscreen.Name = "panelFullscreen";
            this.panelFullscreen.Size = new System.Drawing.Size(393, 273);
            this.panelFullscreen.TabIndex = 0;
            // 
            // listBoxFulscreen
            // 
            this.listBoxFulscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFulscreen.FormattingEnabled = true;
            this.listBoxFulscreen.ItemHeight = 16;
            this.listBoxFulscreen.Location = new System.Drawing.Point(0, 0);
            this.listBoxFulscreen.Name = "listBoxFulscreen";
            this.listBoxFulscreen.Size = new System.Drawing.Size(393, 273);
            this.listBoxFulscreen.TabIndex = 0;
            // 
            // panelCustom
            // 
            this.panelCustom.Controls.Add(this.label2);
            this.panelCustom.Controls.Add(this.label1);
            this.panelCustom.Controls.Add(this.numericUpDownHeight);
            this.panelCustom.Controls.Add(this.numericUpDownWidth);
            this.panelCustom.Enabled = false;
            this.panelCustom.Location = new System.Drawing.Point(411, 39);
            this.panelCustom.Name = "panelCustom";
            this.panelCustom.Size = new System.Drawing.Size(377, 273);
            this.panelCustom.TabIndex = 1;
            // 
            // radioButtonFullscreen
            // 
            this.radioButtonFullscreen.AutoSize = true;
            this.radioButtonFullscreen.Checked = true;
            this.radioButtonFullscreen.Location = new System.Drawing.Point(12, 12);
            this.radioButtonFullscreen.Name = "radioButtonFullscreen";
            this.radioButtonFullscreen.Size = new System.Drawing.Size(104, 21);
            this.radioButtonFullscreen.TabIndex = 2;
            this.radioButtonFullscreen.TabStop = true;
            this.radioButtonFullscreen.Text = "Pełny ekran";
            this.radioButtonFullscreen.UseVisualStyleBackColor = true;
            this.radioButtonFullscreen.CheckedChanged += new System.EventHandler(this.RadioButtonFullscreen_CheckedChanged);
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(411, 12);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(131, 21);
            this.radioButtonCustom.TabIndex = 3;
            this.radioButtonCustom.Text = "Niestandardowe";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            this.radioButtonCustom.CheckedChanged += new System.EventHandler(this.RadioButtonCustom_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 318);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownWidth.TabIndex = 0;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(149, 3);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHeight.TabIndex = 1;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "px";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.radioButtonCustom);
            this.Controls.Add(this.radioButtonFullscreen);
            this.Controls.Add(this.panelCustom);
            this.Controls.Add(this.panelFullscreen);
            this.Name = "MainWindow";
            this.Text = "xD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelFullscreen.ResumeLayout(false);
            this.panelCustom.ResumeLayout(false);
            this.panelCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFullscreen;
        private System.Windows.Forms.Panel panelCustom;
        private System.Windows.Forms.ListBox listBoxFulscreen;
        private System.Windows.Forms.RadioButton radioButtonFullscreen;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
    }
}

