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
            this.SortingGB = new System.Windows.Forms.GroupBox();
            this.OperationGB = new System.Windows.Forms.GroupBox();
            this.GreaterTZRB = new System.Windows.Forms.RadioButton();
            this.SmallerTZRB = new System.Windows.Forms.RadioButton();
            this.GreaterTV = new System.Windows.Forms.RadioButton();
            this.EvenRadioButton = new System.Windows.Forms.RadioButton();
            this.ModVRB = new System.Windows.Forms.RadioButton();
            this.GreaterTVTB = new System.Windows.Forms.TextBox();
            this.ModVTB = new System.Windows.Forms.TextBox();
            this.AscendingRB = new System.Windows.Forms.RadioButton();
            this.DescendingRB = new System.Windows.Forms.RadioButton();
            this.AscendingaABCRB = new System.Windows.Forms.RadioButton();
            this.DescendingABCRB = new System.Windows.Forms.RadioButton();
            this.XPowRB = new System.Windows.Forms.RadioButton();
            this.XMultiplyRB = new System.Windows.Forms.RadioButton();
            this.XXRB = new System.Windows.Forms.RadioButton();
            this.X2RB = new System.Windows.Forms.RadioButton();
            this.XMultiplyTB = new System.Windows.Forms.TextBox();
            this.XPowTB = new System.Windows.Forms.TextBox();
            this.Komb1 = new System.Windows.Forms.Button();
            this.Komb2B = new System.Windows.Forms.Button();
            this.FiltresGB.SuspendLayout();
            this.SortingGB.SuspendLayout();
            this.OperationGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveFromCButton
            // 
            this.RemoveFromCButton.Location = new System.Drawing.Point(12, 12);
            this.RemoveFromCButton.Name = "RemoveFromCButton";
            this.RemoveFromCButton.Size = new System.Drawing.Size(47, 30);
            this.RemoveFromCButton.TabIndex = 0;
            this.RemoveFromCButton.Text = "-";
            this.RemoveFromCButton.UseVisualStyleBackColor = true;
            // 
            // AddToCollectionButton
            // 
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
            this.NewValue.Location = new System.Drawing.Point(65, 12);
            this.NewValue.Name = "NewValue";
            this.NewValue.Size = new System.Drawing.Size(51, 22);
            this.NewValue.TabIndex = 2;
            // 
            // CollectionLB
            // 
            this.CollectionLB.BackColor = System.Drawing.SystemColors.Info;
            this.CollectionLB.FormattingEnabled = true;
            this.CollectionLB.ItemHeight = 16;
            this.CollectionLB.Location = new System.Drawing.Point(12, 48);
            this.CollectionLB.Name = "CollectionLB";
            this.CollectionLB.Size = new System.Drawing.Size(165, 276);
            this.CollectionLB.TabIndex = 3;
            // 
            // ResetCollectB
            // 
            this.ResetCollectB.Location = new System.Drawing.Point(12, 330);
            this.ResetCollectB.Name = "ResetCollectB";
            this.ResetCollectB.Size = new System.Drawing.Size(34, 34);
            this.ResetCollectB.TabIndex = 4;
            this.ResetCollectB.Text = "x";
            this.ResetCollectB.UseVisualStyleBackColor = true;
            // 
            // AmountOfNewCollection
            // 
            this.AmountOfNewCollection.Location = new System.Drawing.Point(52, 331);
            this.AmountOfNewCollection.Name = "AmountOfNewCollection";
            this.AmountOfNewCollection.Size = new System.Drawing.Size(47, 22);
            this.AmountOfNewCollection.TabIndex = 5;
            // 
            // RandNewValuesB
            // 
            this.RandNewValuesB.Location = new System.Drawing.Point(105, 331);
            this.RandNewValuesB.Name = "RandNewValuesB";
            this.RandNewValuesB.Size = new System.Drawing.Size(75, 33);
            this.RandNewValuesB.TabIndex = 6;
            this.RandNewValuesB.Text = "Losuj";
            this.RandNewValuesB.UseVisualStyleBackColor = true;
            // 
            // FiltresGB
            // 
            this.FiltresGB.Controls.Add(this.ModVTB);
            this.FiltresGB.Controls.Add(this.GreaterTVTB);
            this.FiltresGB.Controls.Add(this.ModVRB);
            this.FiltresGB.Controls.Add(this.EvenRadioButton);
            this.FiltresGB.Controls.Add(this.GreaterTV);
            this.FiltresGB.Controls.Add(this.SmallerTZRB);
            this.FiltresGB.Controls.Add(this.GreaterTZRB);
            this.FiltresGB.Location = new System.Drawing.Point(205, 12);
            this.FiltresGB.Name = "FiltresGB";
            this.FiltresGB.Size = new System.Drawing.Size(148, 317);
            this.FiltresGB.TabIndex = 8;
            this.FiltresGB.TabStop = false;
            this.FiltresGB.Text = "Filtry";
            // 
            // SortingGB
            // 
            this.SortingGB.Controls.Add(this.DescendingABCRB);
            this.SortingGB.Controls.Add(this.AscendingaABCRB);
            this.SortingGB.Controls.Add(this.DescendingRB);
            this.SortingGB.Controls.Add(this.AscendingRB);
            this.SortingGB.Location = new System.Drawing.Point(370, 12);
            this.SortingGB.Name = "SortingGB";
            this.SortingGB.Size = new System.Drawing.Size(160, 317);
            this.SortingGB.TabIndex = 9;
            this.SortingGB.TabStop = false;
            this.SortingGB.Text = "Sortowanie";
            // 
            // OperationGB
            // 
            this.OperationGB.Controls.Add(this.XPowTB);
            this.OperationGB.Controls.Add(this.XMultiplyTB);
            this.OperationGB.Controls.Add(this.XPowRB);
            this.OperationGB.Controls.Add(this.XMultiplyRB);
            this.OperationGB.Controls.Add(this.XXRB);
            this.OperationGB.Controls.Add(this.X2RB);
            this.OperationGB.Location = new System.Drawing.Point(547, 12);
            this.OperationGB.Name = "OperationGB";
            this.OperationGB.Size = new System.Drawing.Size(150, 317);
            this.OperationGB.TabIndex = 10;
            this.OperationGB.TabStop = false;
            this.OperationGB.Text = "Operacje";
            // 
            // GreaterTZRB
            // 
            this.GreaterTZRB.AutoSize = true;
            this.GreaterTZRB.Location = new System.Drawing.Point(6, 36);
            this.GreaterTZRB.Name = "GreaterTZRB";
            this.GreaterTZRB.Size = new System.Drawing.Size(49, 21);
            this.GreaterTZRB.TabIndex = 0;
            this.GreaterTZRB.TabStop = true;
            this.GreaterTZRB.Text = "> 0";
            this.GreaterTZRB.UseVisualStyleBackColor = true;
            this.GreaterTZRB.CheckedChanged += new System.EventHandler(this.GreaterTZRB_CheckedChanged);
            // 
            // SmallerTZRB
            // 
            this.SmallerTZRB.AutoSize = true;
            this.SmallerTZRB.Location = new System.Drawing.Point(6, 63);
            this.SmallerTZRB.Name = "SmallerTZRB";
            this.SmallerTZRB.Size = new System.Drawing.Size(49, 21);
            this.SmallerTZRB.TabIndex = 1;
            this.SmallerTZRB.TabStop = true;
            this.SmallerTZRB.Text = "< 0";
            this.SmallerTZRB.UseVisualStyleBackColor = true;
            this.SmallerTZRB.CheckedChanged += new System.EventHandler(this.SmallerTZRB_CheckedChanged);
            // 
            // GreaterTV
            // 
            this.GreaterTV.AutoSize = true;
            this.GreaterTV.Location = new System.Drawing.Point(6, 90);
            this.GreaterTV.Name = "GreaterTV";
            this.GreaterTV.Size = new System.Drawing.Size(41, 21);
            this.GreaterTV.TabIndex = 2;
            this.GreaterTV.TabStop = true;
            this.GreaterTV.Text = "> ";
            this.GreaterTV.UseVisualStyleBackColor = true;
            this.GreaterTV.CheckedChanged += new System.EventHandler(this.GreaterTV_CheckedChanged);
            // 
            // EvenRadioButton
            // 
            this.EvenRadioButton.AutoSize = true;
            this.EvenRadioButton.Location = new System.Drawing.Point(6, 117);
            this.EvenRadioButton.Name = "EvenRadioButton";
            this.EvenRadioButton.Size = new System.Drawing.Size(53, 21);
            this.EvenRadioButton.TabIndex = 3;
            this.EvenRadioButton.TabStop = true;
            this.EvenRadioButton.Text = "% 2";
            this.EvenRadioButton.UseVisualStyleBackColor = true;
            this.EvenRadioButton.CheckedChanged += new System.EventHandler(this.EvenRadioButton_CheckedChanged);
            // 
            // ModVRB
            // 
            this.ModVRB.AutoSize = true;
            this.ModVRB.Location = new System.Drawing.Point(6, 144);
            this.ModVRB.Name = "ModVRB";
            this.ModVRB.Size = new System.Drawing.Size(45, 21);
            this.ModVRB.TabIndex = 4;
            this.ModVRB.TabStop = true;
            this.ModVRB.Text = "% ";
            this.ModVRB.UseVisualStyleBackColor = true;
            this.ModVRB.CheckedChanged += new System.EventHandler(this.ModVRB_CheckedChanged);
            // 
            // GreaterTVTB
            // 
            this.GreaterTVTB.Location = new System.Drawing.Point(53, 90);
            this.GreaterTVTB.Name = "GreaterTVTB";
            this.GreaterTVTB.Size = new System.Drawing.Size(76, 22);
            this.GreaterTVTB.TabIndex = 6;
            // 
            // ModVTB
            // 
            this.ModVTB.Location = new System.Drawing.Point(53, 143);
            this.ModVTB.Name = "ModVTB";
            this.ModVTB.Size = new System.Drawing.Size(76, 22);
            this.ModVTB.TabIndex = 7;
            // 
            // AscendingRB
            // 
            this.AscendingRB.AutoSize = true;
            this.AscendingRB.Location = new System.Drawing.Point(17, 36);
            this.AscendingRB.Name = "AscendingRB";
            this.AscendingRB.Size = new System.Drawing.Size(85, 21);
            this.AscendingRB.TabIndex = 1;
            this.AscendingRB.TabStop = true;
            this.AscendingRB.Text = "Rosnąco";
            this.AscendingRB.UseVisualStyleBackColor = true;
            this.AscendingRB.CheckedChanged += new System.EventHandler(this.AscendingRB_CheckedChanged);
            // 
            // DescendingRB
            // 
            this.DescendingRB.AutoSize = true;
            this.DescendingRB.Location = new System.Drawing.Point(17, 63);
            this.DescendingRB.Name = "DescendingRB";
            this.DescendingRB.Size = new System.Drawing.Size(85, 21);
            this.DescendingRB.TabIndex = 2;
            this.DescendingRB.TabStop = true;
            this.DescendingRB.Text = "Malejąco";
            this.DescendingRB.UseVisualStyleBackColor = true;
            // 
            // AscendingaABCRB
            // 
            this.AscendingaABCRB.AutoSize = true;
            this.AscendingaABCRB.Location = new System.Drawing.Point(17, 91);
            this.AscendingaABCRB.Name = "AscendingaABCRB";
            this.AscendingaABCRB.Size = new System.Drawing.Size(116, 21);
            this.AscendingaABCRB.TabIndex = 3;
            this.AscendingaABCRB.TabStop = true;
            this.AscendingaABCRB.Text = "Rosnąco ABC";
            this.AscendingaABCRB.UseVisualStyleBackColor = true;
            // 
            // DescendingABCRB
            // 
            this.DescendingABCRB.AutoSize = true;
            this.DescendingABCRB.Location = new System.Drawing.Point(17, 118);
            this.DescendingABCRB.Name = "DescendingABCRB";
            this.DescendingABCRB.Size = new System.Drawing.Size(116, 21);
            this.DescendingABCRB.TabIndex = 4;
            this.DescendingABCRB.TabStop = true;
            this.DescendingABCRB.Text = "Malejąco ABC";
            this.DescendingABCRB.UseVisualStyleBackColor = true;
            // 
            // XPowRB
            // 
            this.XPowRB.AutoSize = true;
            this.XPowRB.Location = new System.Drawing.Point(15, 118);
            this.XPowRB.Name = "XPowRB";
            this.XPowRB.Size = new System.Drawing.Size(50, 21);
            this.XPowRB.TabIndex = 8;
            this.XPowRB.TabStop = true;
            this.XPowRB.Text = "x ^ ";
            this.XPowRB.UseVisualStyleBackColor = true;
            // 
            // XMultiplyRB
            // 
            this.XMultiplyRB.AutoSize = true;
            this.XMultiplyRB.Location = new System.Drawing.Point(15, 91);
            this.XMultiplyRB.Name = "XMultiplyRB";
            this.XMultiplyRB.Size = new System.Drawing.Size(44, 21);
            this.XMultiplyRB.TabIndex = 7;
            this.XMultiplyRB.TabStop = true;
            this.XMultiplyRB.Text = "x *";
            this.XMultiplyRB.UseVisualStyleBackColor = true;
            // 
            // XXRB
            // 
            this.XXRB.AutoSize = true;
            this.XXRB.Location = new System.Drawing.Point(15, 63);
            this.XXRB.Name = "XXRB";
            this.XXRB.Size = new System.Drawing.Size(50, 21);
            this.XXRB.TabIndex = 6;
            this.XXRB.TabStop = true;
            this.XXRB.Text = "x^2";
            this.XXRB.UseVisualStyleBackColor = true;
            // 
            // X2RB
            // 
            this.X2RB.AutoSize = true;
            this.X2RB.Location = new System.Drawing.Point(15, 36);
            this.X2RB.Name = "X2RB";
            this.X2RB.Size = new System.Drawing.Size(43, 21);
            this.X2RB.TabIndex = 5;
            this.X2RB.TabStop = true;
            this.X2RB.Text = "2x";
            this.X2RB.UseVisualStyleBackColor = true;
            // 
            // XMultiplyTB
            // 
            this.XMultiplyTB.Location = new System.Drawing.Point(65, 91);
            this.XMultiplyTB.Name = "XMultiplyTB";
            this.XMultiplyTB.Size = new System.Drawing.Size(76, 22);
            this.XMultiplyTB.TabIndex = 9;
            // 
            // XPowTB
            // 
            this.XPowTB.Location = new System.Drawing.Point(65, 119);
            this.XPowTB.Name = "XPowTB";
            this.XPowTB.Size = new System.Drawing.Size(76, 22);
            this.XPowTB.TabIndex = 10;
            // 
            // Komb1
            // 
            this.Komb1.Location = new System.Drawing.Point(205, 339);
            this.Komb1.Name = "Komb1";
            this.Komb1.Size = new System.Drawing.Size(148, 33);
            this.Komb1.TabIndex = 11;
            this.Komb1.Text = "Komb1";
            this.Komb1.UseVisualStyleBackColor = true;
            this.Komb1.Click += new System.EventHandler(this.button5_Click);
            // 
            // Komb2B
            // 
            this.Komb2B.Location = new System.Drawing.Point(370, 339);
            this.Komb2B.Name = "Komb2B";
            this.Komb2B.Size = new System.Drawing.Size(160, 33);
            this.Komb2B.TabIndex = 12;
            this.Komb2B.Text = "Komb2";
            this.Komb2B.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 384);
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
    }
}

