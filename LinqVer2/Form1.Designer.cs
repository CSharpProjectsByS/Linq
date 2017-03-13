namespace LinqVer2
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
            this.RemoveFromCButton = new System.Windows.Forms.Button();
            this.AddToCollectionButton = new System.Windows.Forms.Button();
            this.NewValue = new System.Windows.Forms.TextBox();
            this.CollectionLB = new System.Windows.Forms.ListBox();
            this.ResetCollectB = new System.Windows.Forms.Button();
            this.AmountOfNewCollection = new System.Windows.Forms.TextBox();
            this.RandNewValuesB = new System.Windows.Forms.Button();
            this.FiltresGB = new System.Windows.Forms.GroupBox();
            this.ModVTB = new System.Windows.Forms.TextBox();
            this.GreaterTVTB = new System.Windows.Forms.TextBox();
            this.ModVRB = new System.Windows.Forms.RadioButton();
            this.EvenRadioButton = new System.Windows.Forms.RadioButton();
            this.GreaterTV = new System.Windows.Forms.RadioButton();
            this.SmallerTZRB = new System.Windows.Forms.RadioButton();
            this.GreaterTZRB = new System.Windows.Forms.RadioButton();
            this.SortingGB = new System.Windows.Forms.GroupBox();
            this.DescendingABCRB = new System.Windows.Forms.RadioButton();
            this.AscendingaABCRB = new System.Windows.Forms.RadioButton();
            this.DescendingRB = new System.Windows.Forms.RadioButton();
            this.AscendingRB = new System.Windows.Forms.RadioButton();
            this.OperationGB = new System.Windows.Forms.GroupBox();
            this.XPowTB = new System.Windows.Forms.TextBox();
            this.XMultiplyTB = new System.Windows.Forms.TextBox();
            this.XPowRB = new System.Windows.Forms.RadioButton();
            this.XMultiplyRB = new System.Windows.Forms.RadioButton();
            this.XXRB = new System.Windows.Forms.RadioButton();
            this.X2RB = new System.Windows.Forms.RadioButton();
            this.Komb1 = new System.Windows.Forms.Button();
            this.Komb2B = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.GoFirstAloneButton = new System.Windows.Forms.Button();
            this.GoSecondAloneButton = new System.Windows.Forms.Button();
            this.GoThirdAlone = new System.Windows.Forms.Button();
            this.OldCollectionLB = new System.Windows.Forms.ListBox();
            this.FiltresGB.SuspendLayout();
            this.SortingGB.SuspendLayout();
            this.OperationGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveFromCButton
            // 
            this.RemoveFromCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RemoveFromCButton.Location = new System.Drawing.Point(12, 12);
            this.RemoveFromCButton.Name = "RemoveFromCButton";
            this.RemoveFromCButton.Size = new System.Drawing.Size(47, 30);
            this.RemoveFromCButton.TabIndex = 0;
            this.RemoveFromCButton.Text = "-";
            this.RemoveFromCButton.UseVisualStyleBackColor = true;
            this.RemoveFromCButton.Click += new System.EventHandler(this.RemoveFromCButton_Click);
            // 
            // AddToCollectionButton
            // 
            this.AddToCollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddToCollectionButton.Location = new System.Drawing.Point(122, 12);
            this.AddToCollectionButton.Name = "AddToCollectionButton";
            this.AddToCollectionButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddToCollectionButton.Size = new System.Drawing.Size(55, 30);
            this.AddToCollectionButton.TabIndex = 1;
            this.AddToCollectionButton.Text = "+";
            this.AddToCollectionButton.UseVisualStyleBackColor = true;
            this.AddToCollectionButton.Click += new System.EventHandler(this.AddToCollectionButton_Click);
            // 
            // NewValue
            // 
            this.NewValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewValue.Location = new System.Drawing.Point(65, 12);
            this.NewValue.Name = "NewValue";
            this.NewValue.Size = new System.Drawing.Size(51, 26);
            this.NewValue.TabIndex = 2;
            // 
            // CollectionLB
            // 
            this.CollectionLB.BackColor = System.Drawing.SystemColors.Info;
            this.CollectionLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CollectionLB.FormattingEnabled = true;
            this.CollectionLB.ItemHeight = 20;
            this.CollectionLB.Location = new System.Drawing.Point(12, 48);
            this.CollectionLB.Name = "CollectionLB";
            this.CollectionLB.Size = new System.Drawing.Size(165, 264);
            this.CollectionLB.TabIndex = 3;
            // 
            // ResetCollectB
            // 
            this.ResetCollectB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResetCollectB.Location = new System.Drawing.Point(12, 330);
            this.ResetCollectB.Name = "ResetCollectB";
            this.ResetCollectB.Size = new System.Drawing.Size(34, 34);
            this.ResetCollectB.TabIndex = 4;
            this.ResetCollectB.Text = "x";
            this.ResetCollectB.UseVisualStyleBackColor = true;
            this.ResetCollectB.Click += new System.EventHandler(this.ResetCollectB_Click);
            // 
            // AmountOfNewCollection
            // 
            this.AmountOfNewCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AmountOfNewCollection.Location = new System.Drawing.Point(52, 331);
            this.AmountOfNewCollection.Name = "AmountOfNewCollection";
            this.AmountOfNewCollection.Size = new System.Drawing.Size(47, 26);
            this.AmountOfNewCollection.TabIndex = 5;
            this.AmountOfNewCollection.Text = "5";
            // 
            // RandNewValuesB
            // 
            this.RandNewValuesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RandNewValuesB.Location = new System.Drawing.Point(105, 331);
            this.RandNewValuesB.Name = "RandNewValuesB";
            this.RandNewValuesB.Size = new System.Drawing.Size(75, 33);
            this.RandNewValuesB.TabIndex = 6;
            this.RandNewValuesB.Text = "Losuj";
            this.RandNewValuesB.UseVisualStyleBackColor = true;
            this.RandNewValuesB.Click += new System.EventHandler(this.RandNewValuesB_Click);
            // 
            // FiltresGB
            // 
            this.FiltresGB.Controls.Add(this.GoFirstAloneButton);
            this.FiltresGB.Controls.Add(this.ModVTB);
            this.FiltresGB.Controls.Add(this.GreaterTVTB);
            this.FiltresGB.Controls.Add(this.ModVRB);
            this.FiltresGB.Controls.Add(this.EvenRadioButton);
            this.FiltresGB.Controls.Add(this.GreaterTV);
            this.FiltresGB.Controls.Add(this.SmallerTZRB);
            this.FiltresGB.Controls.Add(this.GreaterTZRB);
            this.FiltresGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FiltresGB.Location = new System.Drawing.Point(375, 12);
            this.FiltresGB.Name = "FiltresGB";
            this.FiltresGB.Size = new System.Drawing.Size(148, 317);
            this.FiltresGB.TabIndex = 8;
            this.FiltresGB.TabStop = false;
            this.FiltresGB.Text = "Filtry";
            // 
            // ModVTB
            // 
            this.ModVTB.Location = new System.Drawing.Point(53, 143);
            this.ModVTB.Name = "ModVTB";
            this.ModVTB.Size = new System.Drawing.Size(76, 26);
            this.ModVTB.TabIndex = 7;
            // 
            // GreaterTVTB
            // 
            this.GreaterTVTB.Location = new System.Drawing.Point(53, 90);
            this.GreaterTVTB.Name = "GreaterTVTB";
            this.GreaterTVTB.Size = new System.Drawing.Size(76, 26);
            this.GreaterTVTB.TabIndex = 6;
            // 
            // ModVRB
            // 
            this.ModVRB.AutoSize = true;
            this.ModVRB.Location = new System.Drawing.Point(6, 144);
            this.ModVRB.Name = "ModVRB";
            this.ModVRB.Size = new System.Drawing.Size(50, 24);
            this.ModVRB.TabIndex = 4;
            this.ModVRB.TabStop = true;
            this.ModVRB.Text = "% ";
            this.ModVRB.UseVisualStyleBackColor = true;
            this.ModVRB.CheckedChanged += new System.EventHandler(this.ModVRB_CheckedChanged);
            // 
            // EvenRadioButton
            // 
            this.EvenRadioButton.AutoSize = true;
            this.EvenRadioButton.Location = new System.Drawing.Point(6, 117);
            this.EvenRadioButton.Name = "EvenRadioButton";
            this.EvenRadioButton.Size = new System.Drawing.Size(59, 24);
            this.EvenRadioButton.TabIndex = 3;
            this.EvenRadioButton.TabStop = true;
            this.EvenRadioButton.Text = "% 2";
            this.EvenRadioButton.UseVisualStyleBackColor = true;
            this.EvenRadioButton.CheckedChanged += new System.EventHandler(this.EvenRadioButton_CheckedChanged);
            // 
            // GreaterTV
            // 
            this.GreaterTV.AutoSize = true;
            this.GreaterTV.Location = new System.Drawing.Point(6, 90);
            this.GreaterTV.Name = "GreaterTV";
            this.GreaterTV.Size = new System.Drawing.Size(45, 24);
            this.GreaterTV.TabIndex = 2;
            this.GreaterTV.TabStop = true;
            this.GreaterTV.Text = "> ";
            this.GreaterTV.UseVisualStyleBackColor = true;
            this.GreaterTV.CheckedChanged += new System.EventHandler(this.GreaterTV_CheckedChanged);
            // 
            // SmallerTZRB
            // 
            this.SmallerTZRB.AutoSize = true;
            this.SmallerTZRB.Location = new System.Drawing.Point(6, 63);
            this.SmallerTZRB.Name = "SmallerTZRB";
            this.SmallerTZRB.Size = new System.Drawing.Size(54, 24);
            this.SmallerTZRB.TabIndex = 1;
            this.SmallerTZRB.TabStop = true;
            this.SmallerTZRB.Text = "< 0";
            this.SmallerTZRB.UseVisualStyleBackColor = true;
            this.SmallerTZRB.CheckedChanged += new System.EventHandler(this.SmallerTZRB_CheckedChanged);
            // 
            // GreaterTZRB
            // 
            this.GreaterTZRB.AutoSize = true;
            this.GreaterTZRB.Location = new System.Drawing.Point(6, 36);
            this.GreaterTZRB.Name = "GreaterTZRB";
            this.GreaterTZRB.Size = new System.Drawing.Size(54, 24);
            this.GreaterTZRB.TabIndex = 0;
            this.GreaterTZRB.TabStop = true;
            this.GreaterTZRB.Text = "> 0";
            this.GreaterTZRB.UseVisualStyleBackColor = true;
            this.GreaterTZRB.CheckedChanged += new System.EventHandler(this.GreaterTZRB_CheckedChanged);
            // 
            // SortingGB
            // 
            this.SortingGB.Controls.Add(this.GoSecondAloneButton);
            this.SortingGB.Controls.Add(this.DescendingABCRB);
            this.SortingGB.Controls.Add(this.AscendingaABCRB);
            this.SortingGB.Controls.Add(this.DescendingRB);
            this.SortingGB.Controls.Add(this.AscendingRB);
            this.SortingGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SortingGB.Location = new System.Drawing.Point(540, 12);
            this.SortingGB.Name = "SortingGB";
            this.SortingGB.Size = new System.Drawing.Size(160, 317);
            this.SortingGB.TabIndex = 9;
            this.SortingGB.TabStop = false;
            this.SortingGB.Text = "Sortowanie";
            // 
            // DescendingABCRB
            // 
            this.DescendingABCRB.AutoSize = true;
            this.DescendingABCRB.Location = new System.Drawing.Point(17, 118);
            this.DescendingABCRB.Name = "DescendingABCRB";
            this.DescendingABCRB.Size = new System.Drawing.Size(137, 24);
            this.DescendingABCRB.TabIndex = 4;
            this.DescendingABCRB.TabStop = true;
            this.DescendingABCRB.Text = "Malejąco ABC";
            this.DescendingABCRB.UseVisualStyleBackColor = true;
            this.DescendingABCRB.CheckedChanged += new System.EventHandler(this.DescendingABCRB_CheckedChanged);
            // 
            // AscendingaABCRB
            // 
            this.AscendingaABCRB.AutoSize = true;
            this.AscendingaABCRB.Location = new System.Drawing.Point(17, 91);
            this.AscendingaABCRB.Name = "AscendingaABCRB";
            this.AscendingaABCRB.Size = new System.Drawing.Size(136, 24);
            this.AscendingaABCRB.TabIndex = 3;
            this.AscendingaABCRB.TabStop = true;
            this.AscendingaABCRB.Text = "Rosnąco ABC";
            this.AscendingaABCRB.UseVisualStyleBackColor = true;
            this.AscendingaABCRB.CheckedChanged += new System.EventHandler(this.AscendingaABCRB_CheckedChanged);
            // 
            // DescendingRB
            // 
            this.DescendingRB.AutoSize = true;
            this.DescendingRB.Location = new System.Drawing.Point(17, 63);
            this.DescendingRB.Name = "DescendingRB";
            this.DescendingRB.Size = new System.Drawing.Size(97, 24);
            this.DescendingRB.TabIndex = 2;
            this.DescendingRB.TabStop = true;
            this.DescendingRB.Text = "Malejąco";
            this.DescendingRB.UseVisualStyleBackColor = true;
            this.DescendingRB.CheckedChanged += new System.EventHandler(this.DescendingRB_CheckedChanged);
            // 
            // AscendingRB
            // 
            this.AscendingRB.AutoSize = true;
            this.AscendingRB.Location = new System.Drawing.Point(17, 36);
            this.AscendingRB.Name = "AscendingRB";
            this.AscendingRB.Size = new System.Drawing.Size(96, 24);
            this.AscendingRB.TabIndex = 1;
            this.AscendingRB.TabStop = true;
            this.AscendingRB.Text = "Rosnąco";
            this.AscendingRB.UseVisualStyleBackColor = true;
            this.AscendingRB.CheckedChanged += new System.EventHandler(this.AscendingRB_CheckedChanged);
            // 
            // OperationGB
            // 
            this.OperationGB.Controls.Add(this.GoThirdAlone);
            this.OperationGB.Controls.Add(this.XPowTB);
            this.OperationGB.Controls.Add(this.XMultiplyTB);
            this.OperationGB.Controls.Add(this.XPowRB);
            this.OperationGB.Controls.Add(this.XMultiplyRB);
            this.OperationGB.Controls.Add(this.XXRB);
            this.OperationGB.Controls.Add(this.X2RB);
            this.OperationGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OperationGB.Location = new System.Drawing.Point(717, 12);
            this.OperationGB.Name = "OperationGB";
            this.OperationGB.Size = new System.Drawing.Size(150, 317);
            this.OperationGB.TabIndex = 10;
            this.OperationGB.TabStop = false;
            this.OperationGB.Text = "Operacje";
            // 
            // XPowTB
            // 
            this.XPowTB.Location = new System.Drawing.Point(65, 119);
            this.XPowTB.Name = "XPowTB";
            this.XPowTB.Size = new System.Drawing.Size(76, 26);
            this.XPowTB.TabIndex = 10;
            // 
            // XMultiplyTB
            // 
            this.XMultiplyTB.Location = new System.Drawing.Point(65, 91);
            this.XMultiplyTB.Name = "XMultiplyTB";
            this.XMultiplyTB.Size = new System.Drawing.Size(76, 26);
            this.XMultiplyTB.TabIndex = 9;
            // 
            // XPowRB
            // 
            this.XPowRB.AutoSize = true;
            this.XPowRB.Location = new System.Drawing.Point(15, 118);
            this.XPowRB.Name = "XPowRB";
            this.XPowRB.Size = new System.Drawing.Size(55, 24);
            this.XPowRB.TabIndex = 8;
            this.XPowRB.TabStop = true;
            this.XPowRB.Text = "x ^ ";
            this.XPowRB.UseVisualStyleBackColor = true;
            this.XPowRB.CheckedChanged += new System.EventHandler(this.XPowRB_CheckedChanged);
            // 
            // XMultiplyRB
            // 
            this.XMultiplyRB.AutoSize = true;
            this.XMultiplyRB.Location = new System.Drawing.Point(15, 91);
            this.XMultiplyRB.Name = "XMultiplyRB";
            this.XMultiplyRB.Size = new System.Drawing.Size(49, 24);
            this.XMultiplyRB.TabIndex = 7;
            this.XMultiplyRB.TabStop = true;
            this.XMultiplyRB.Text = "x *";
            this.XMultiplyRB.UseVisualStyleBackColor = true;
            this.XMultiplyRB.CheckedChanged += new System.EventHandler(this.XMultiplyRB_CheckedChanged);
            // 
            // XXRB
            // 
            this.XXRB.AutoSize = true;
            this.XXRB.Location = new System.Drawing.Point(15, 63);
            this.XXRB.Name = "XXRB";
            this.XXRB.Size = new System.Drawing.Size(54, 24);
            this.XXRB.TabIndex = 6;
            this.XXRB.TabStop = true;
            this.XXRB.Text = "x^2";
            this.XXRB.UseVisualStyleBackColor = true;
            this.XXRB.CheckedChanged += new System.EventHandler(this.XXRB_CheckedChanged);
            // 
            // X2RB
            // 
            this.X2RB.AutoSize = true;
            this.X2RB.Location = new System.Drawing.Point(15, 36);
            this.X2RB.Name = "X2RB";
            this.X2RB.Size = new System.Drawing.Size(47, 24);
            this.X2RB.TabIndex = 5;
            this.X2RB.TabStop = true;
            this.X2RB.Text = "2x";
            this.X2RB.UseVisualStyleBackColor = true;
            this.X2RB.CheckedChanged += new System.EventHandler(this.X2RB_CheckedChanged);
            // 
            // Komb1
            // 
            this.Komb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Komb1.Location = new System.Drawing.Point(375, 339);
            this.Komb1.Name = "Komb1";
            this.Komb1.Size = new System.Drawing.Size(148, 33);
            this.Komb1.TabIndex = 11;
            this.Komb1.Text = "Komb1";
            this.Komb1.UseVisualStyleBackColor = true;
            this.Komb1.Click += new System.EventHandler(this.button5_Click);
            // 
            // Komb2B
            // 
            this.Komb2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Komb2B.Location = new System.Drawing.Point(540, 339);
            this.Komb2B.Name = "Komb2B";
            this.Komb2B.Size = new System.Drawing.Size(160, 33);
            this.Komb2B.TabIndex = 12;
            this.Komb2B.Text = "Komb2";
            this.Komb2B.UseVisualStyleBackColor = true;
            this.Komb2B.Click += new System.EventHandler(this.Komb2B_Click);
            // 
            // GoButton
            // 
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GoButton.Location = new System.Drawing.Point(725, 339);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(144, 33);
            this.GoButton.TabIndex = 13;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // GoFirstAloneButton
            // 
            this.GoFirstAloneButton.Location = new System.Drawing.Point(6, 280);
            this.GoFirstAloneButton.Name = "GoFirstAloneButton";
            this.GoFirstAloneButton.Size = new System.Drawing.Size(136, 31);
            this.GoFirstAloneButton.TabIndex = 8;
            this.GoFirstAloneButton.Text = "Go";
            this.GoFirstAloneButton.UseVisualStyleBackColor = true;
            this.GoFirstAloneButton.Click += new System.EventHandler(this.GoFirstAloneButton_Click);
            // 
            // GoSecondAloneButton
            // 
            this.GoSecondAloneButton.Location = new System.Drawing.Point(6, 280);
            this.GoSecondAloneButton.Name = "GoSecondAloneButton";
            this.GoSecondAloneButton.Size = new System.Drawing.Size(148, 31);
            this.GoSecondAloneButton.TabIndex = 5;
            this.GoSecondAloneButton.Text = "Go";
            this.GoSecondAloneButton.UseVisualStyleBackColor = true;
            this.GoSecondAloneButton.Click += new System.EventHandler(this.GoSecondAloneButton_Click);
            // 
            // GoThirdAlone
            // 
            this.GoThirdAlone.Location = new System.Drawing.Point(15, 280);
            this.GoThirdAlone.Name = "GoThirdAlone";
            this.GoThirdAlone.Size = new System.Drawing.Size(126, 32);
            this.GoThirdAlone.TabIndex = 11;
            this.GoThirdAlone.Text = "Go";
            this.GoThirdAlone.UseVisualStyleBackColor = true;
            this.GoThirdAlone.Click += new System.EventHandler(this.GoThirdAlone_Click);
            // 
            // OldCollectionLB
            // 
            this.OldCollectionLB.BackColor = System.Drawing.SystemColors.Info;
            this.OldCollectionLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OldCollectionLB.FormattingEnabled = true;
            this.OldCollectionLB.ItemHeight = 20;
            this.OldCollectionLB.Location = new System.Drawing.Point(194, 48);
            this.OldCollectionLB.Name = "OldCollectionLB";
            this.OldCollectionLB.Size = new System.Drawing.Size(165, 264);
            this.OldCollectionLB.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 384);
            this.Controls.Add(this.OldCollectionLB);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.Komb2B);
            this.Controls.Add(this.Komb1);
            this.Controls.Add(this.OperationGB);
            this.Controls.Add(this.SortingGB);
            this.Controls.Add(this.FiltresGB);
            this.Controls.Add(this.RandNewValuesB);
            this.Controls.Add(this.AmountOfNewCollection);
            this.Controls.Add(this.ResetCollectB);
            this.Controls.Add(this.CollectionLB);
            this.Controls.Add(this.NewValue);
            this.Controls.Add(this.AddToCollectionButton);
            this.Controls.Add(this.RemoveFromCButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FiltresGB.ResumeLayout(false);
            this.FiltresGB.PerformLayout();
            this.SortingGB.ResumeLayout(false);
            this.SortingGB.PerformLayout();
            this.OperationGB.ResumeLayout(false);
            this.OperationGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveFromCButton;
        private System.Windows.Forms.Button AddToCollectionButton;
        private System.Windows.Forms.TextBox NewValue;
        private System.Windows.Forms.ListBox CollectionLB;
        private System.Windows.Forms.Button ResetCollectB;
        private System.Windows.Forms.TextBox AmountOfNewCollection;
        private System.Windows.Forms.Button RandNewValuesB;
        private System.Windows.Forms.GroupBox FiltresGB;
        private System.Windows.Forms.TextBox ModVTB;
        private System.Windows.Forms.TextBox GreaterTVTB;
        private System.Windows.Forms.RadioButton ModVRB;
        private System.Windows.Forms.RadioButton EvenRadioButton;
        private System.Windows.Forms.RadioButton GreaterTV;
        private System.Windows.Forms.RadioButton SmallerTZRB;
        private System.Windows.Forms.RadioButton GreaterTZRB;
        private System.Windows.Forms.GroupBox SortingGB;
        private System.Windows.Forms.RadioButton DescendingABCRB;
        private System.Windows.Forms.RadioButton AscendingaABCRB;
        private System.Windows.Forms.RadioButton DescendingRB;
        private System.Windows.Forms.RadioButton AscendingRB;
        private System.Windows.Forms.GroupBox OperationGB;
        private System.Windows.Forms.TextBox XPowTB;
        private System.Windows.Forms.TextBox XMultiplyTB;
        private System.Windows.Forms.RadioButton XPowRB;
        private System.Windows.Forms.RadioButton XMultiplyRB;
        private System.Windows.Forms.RadioButton XXRB;
        private System.Windows.Forms.RadioButton X2RB;
        private System.Windows.Forms.Button Komb1;
        private System.Windows.Forms.Button Komb2B;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button GoFirstAloneButton;
        private System.Windows.Forms.Button GoSecondAloneButton;
        private System.Windows.Forms.Button GoThirdAlone;
        private System.Windows.Forms.ListBox OldCollectionLB;
    }
}

