
namespace BasicCalculator
{
    partial class Form1
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EQUALSButton = new System.Windows.Forms.Button();
            this.DOTButton = new System.Windows.Forms.Button();
            this.ZEROButton = new System.Windows.Forms.Button();
            this.PLUSButton = new System.Windows.Forms.Button();
            this.THREEButton = new System.Windows.Forms.Button();
            this.TWOButton = new System.Windows.Forms.Button();
            this.ONEButton = new System.Windows.Forms.Button();
            this.MINUSButton = new System.Windows.Forms.Button();
            this.SIXButton = new System.Windows.Forms.Button();
            this.FIVEButton = new System.Windows.Forms.Button();
            this.FOURButton = new System.Windows.Forms.Button();
            this.MULTIPLYButton = new System.Windows.Forms.Button();
            this.NINEButton = new System.Windows.Forms.Button();
            this.EIGHTButton = new System.Windows.Forms.Button();
            this.SEVENButton = new System.Windows.Forms.Button();
            this.MODULOButton = new System.Windows.Forms.Button();
            this.DELButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(12, 12);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(639, 31);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.AutoSize = true;
            this.CalculationResultText.Location = new System.Drawing.Point(15, 68);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(424, 25);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Please enter a equation  and press enter or equal (=)";
            this.CalculationResultText.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.ColumnCount = 4;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.Controls.Add(this.EQUALSButton, 3, 4);
            this.ButtonPanel.Controls.Add(this.DOTButton, 2, 4);
            this.ButtonPanel.Controls.Add(this.ZEROButton, 1, 4);
            this.ButtonPanel.Controls.Add(this.PLUSButton, 3, 3);
            this.ButtonPanel.Controls.Add(this.THREEButton, 2, 3);
            this.ButtonPanel.Controls.Add(this.TWOButton, 1, 3);
            this.ButtonPanel.Controls.Add(this.ONEButton, 0, 3);
            this.ButtonPanel.Controls.Add(this.MINUSButton, 3, 2);
            this.ButtonPanel.Controls.Add(this.SIXButton, 2, 2);
            this.ButtonPanel.Controls.Add(this.FIVEButton, 1, 2);
            this.ButtonPanel.Controls.Add(this.FOURButton, 0, 2);
            this.ButtonPanel.Controls.Add(this.MULTIPLYButton, 3, 1);
            this.ButtonPanel.Controls.Add(this.NINEButton, 2, 1);
            this.ButtonPanel.Controls.Add(this.EIGHTButton, 1, 1);
            this.ButtonPanel.Controls.Add(this.SEVENButton, 0, 1);
            this.ButtonPanel.Controls.Add(this.MODULOButton, 3, 0);
            this.ButtonPanel.Controls.Add(this.DELButton, 2, 0);
            this.ButtonPanel.Controls.Add(this.CButton, 1, 0);
            this.ButtonPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonPanel.Location = new System.Drawing.Point(12, 182);
            this.ButtonPanel.MinimumSize = new System.Drawing.Size(460, 420);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 5;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.Size = new System.Drawing.Size(658, 473);
            this.ButtonPanel.TabIndex = 2;
            this.ButtonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_2);
            // 
            // EQUALSButton
            // 
            this.EQUALSButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EQUALSButton.Location = new System.Drawing.Point(495, 379);
            this.EQUALSButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.EQUALSButton.Name = "EQUALSButton";
            this.EQUALSButton.Size = new System.Drawing.Size(160, 91);
            this.EQUALSButton.TabIndex = 19;
            this.EQUALSButton.Text = "=";
            this.EQUALSButton.UseVisualStyleBackColor = true;
            this.EQUALSButton.Click += new System.EventHandler(this.EQUALSButton_Click);
            // 
            // DOTButton
            // 
            this.DOTButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOTButton.Location = new System.Drawing.Point(331, 379);
            this.DOTButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.DOTButton.Name = "DOTButton";
            this.DOTButton.Size = new System.Drawing.Size(158, 91);
            this.DOTButton.TabIndex = 18;
            this.DOTButton.Text = ".";
            this.DOTButton.UseVisualStyleBackColor = true;
            this.DOTButton.Click += new System.EventHandler(this.DOTButton_Click);
            // 
            // ZEROButton
            // 
            this.ZEROButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZEROButton.Location = new System.Drawing.Point(167, 379);
            this.ZEROButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.ZEROButton.Name = "ZEROButton";
            this.ZEROButton.Size = new System.Drawing.Size(158, 91);
            this.ZEROButton.TabIndex = 17;
            this.ZEROButton.Text = "0";
            this.ZEROButton.UseVisualStyleBackColor = true;
            this.ZEROButton.Click += new System.EventHandler(this.ZEROButton_Click);
            // 
            // PLUSButton
            // 
            this.PLUSButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PLUSButton.Location = new System.Drawing.Point(495, 285);
            this.PLUSButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.PLUSButton.Name = "PLUSButton";
            this.PLUSButton.Size = new System.Drawing.Size(160, 88);
            this.PLUSButton.TabIndex = 15;
            this.PLUSButton.Text = "+";
            this.PLUSButton.UseVisualStyleBackColor = true;
            this.PLUSButton.Click += new System.EventHandler(this.PLUSButton_Click);
            // 
            // THREEButton
            // 
            this.THREEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.THREEButton.Location = new System.Drawing.Point(331, 285);
            this.THREEButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.THREEButton.Name = "THREEButton";
            this.THREEButton.Size = new System.Drawing.Size(158, 88);
            this.THREEButton.TabIndex = 14;
            this.THREEButton.Text = "3";
            this.THREEButton.UseVisualStyleBackColor = true;
            this.THREEButton.Click += new System.EventHandler(this.THREEButton_Click);
            // 
            // TWOButton
            // 
            this.TWOButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWOButton.Location = new System.Drawing.Point(167, 285);
            this.TWOButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.TWOButton.Name = "TWOButton";
            this.TWOButton.Size = new System.Drawing.Size(158, 88);
            this.TWOButton.TabIndex = 13;
            this.TWOButton.Text = "2";
            this.TWOButton.UseVisualStyleBackColor = true;
            this.TWOButton.Click += new System.EventHandler(this.TWOButton_Click);
            // 
            // ONEButton
            // 
            this.ONEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ONEButton.Location = new System.Drawing.Point(3, 285);
            this.ONEButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.ONEButton.Name = "ONEButton";
            this.ONEButton.Size = new System.Drawing.Size(158, 88);
            this.ONEButton.TabIndex = 12;
            this.ONEButton.Text = "1";
            this.ONEButton.UseVisualStyleBackColor = true;
            this.ONEButton.Click += new System.EventHandler(this.ONEButton_Click);
            // 
            // MINUSButton
            // 
            this.MINUSButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MINUSButton.Location = new System.Drawing.Point(495, 191);
            this.MINUSButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.MINUSButton.Name = "MINUSButton";
            this.MINUSButton.Size = new System.Drawing.Size(160, 88);
            this.MINUSButton.TabIndex = 11;
            this.MINUSButton.Text = "-";
            this.MINUSButton.UseVisualStyleBackColor = true;
            this.MINUSButton.Click += new System.EventHandler(this.MINUSButton_Click);
            // 
            // SIXButton
            // 
            this.SIXButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SIXButton.Location = new System.Drawing.Point(331, 191);
            this.SIXButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.SIXButton.Name = "SIXButton";
            this.SIXButton.Size = new System.Drawing.Size(158, 88);
            this.SIXButton.TabIndex = 10;
            this.SIXButton.Text = "6";
            this.SIXButton.UseVisualStyleBackColor = true;
            this.SIXButton.Click += new System.EventHandler(this.SIXButton_Click);
            // 
            // FIVEButton
            // 
            this.FIVEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FIVEButton.Location = new System.Drawing.Point(167, 191);
            this.FIVEButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.FIVEButton.Name = "FIVEButton";
            this.FIVEButton.Size = new System.Drawing.Size(158, 88);
            this.FIVEButton.TabIndex = 9;
            this.FIVEButton.Text = "5";
            this.FIVEButton.UseVisualStyleBackColor = true;
            this.FIVEButton.Click += new System.EventHandler(this.FIVEButton_Click);
            // 
            // FOURButton
            // 
            this.FOURButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FOURButton.Location = new System.Drawing.Point(3, 191);
            this.FOURButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.FOURButton.Name = "FOURButton";
            this.FOURButton.Size = new System.Drawing.Size(158, 88);
            this.FOURButton.TabIndex = 8;
            this.FOURButton.Text = "4";
            this.FOURButton.UseVisualStyleBackColor = true;
            this.FOURButton.Click += new System.EventHandler(this.FOURButton_Click);
            // 
            // MULTIPLYButton
            // 
            this.MULTIPLYButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MULTIPLYButton.Location = new System.Drawing.Point(495, 97);
            this.MULTIPLYButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.MULTIPLYButton.Name = "MULTIPLYButton";
            this.MULTIPLYButton.Size = new System.Drawing.Size(160, 88);
            this.MULTIPLYButton.TabIndex = 7;
            this.MULTIPLYButton.Text = "X";
            this.MULTIPLYButton.UseVisualStyleBackColor = true;
            this.MULTIPLYButton.Click += new System.EventHandler(this.MULTIPLYButton_Click);
            // 
            // NINEButton
            // 
            this.NINEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NINEButton.Location = new System.Drawing.Point(331, 97);
            this.NINEButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.NINEButton.Name = "NINEButton";
            this.NINEButton.Size = new System.Drawing.Size(158, 88);
            this.NINEButton.TabIndex = 6;
            this.NINEButton.Text = "9";
            this.NINEButton.UseVisualStyleBackColor = true;
            this.NINEButton.Click += new System.EventHandler(this.NINEButton_Click);
            // 
            // EIGHTButton
            // 
            this.EIGHTButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EIGHTButton.Location = new System.Drawing.Point(167, 97);
            this.EIGHTButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.EIGHTButton.Name = "EIGHTButton";
            this.EIGHTButton.Size = new System.Drawing.Size(158, 88);
            this.EIGHTButton.TabIndex = 5;
            this.EIGHTButton.Text = "8";
            this.EIGHTButton.UseVisualStyleBackColor = true;
            this.EIGHTButton.Click += new System.EventHandler(this.EIGHTButton_Click);
            // 
            // SEVENButton
            // 
            this.SEVENButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SEVENButton.Location = new System.Drawing.Point(3, 97);
            this.SEVENButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.SEVENButton.Name = "SEVENButton";
            this.SEVENButton.Size = new System.Drawing.Size(158, 88);
            this.SEVENButton.TabIndex = 4;
            this.SEVENButton.Text = "7";
            this.SEVENButton.UseVisualStyleBackColor = true;
            this.SEVENButton.Click += new System.EventHandler(this.SEVENButton_Click);
            // 
            // MODULOButton
            // 
            this.MODULOButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MODULOButton.Location = new System.Drawing.Point(495, 3);
            this.MODULOButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.MODULOButton.Name = "MODULOButton";
            this.MODULOButton.Size = new System.Drawing.Size(160, 88);
            this.MODULOButton.TabIndex = 3;
            this.MODULOButton.Text = "%";
            this.MODULOButton.UseVisualStyleBackColor = true;
            this.MODULOButton.Click += new System.EventHandler(this.MODULOButton_Click);
            // 
            // DELButton
            // 
            this.DELButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DELButton.Location = new System.Drawing.Point(331, 3);
            this.DELButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.DELButton.Name = "DELButton";
            this.DELButton.Size = new System.Drawing.Size(158, 88);
            this.DELButton.TabIndex = 2;
            this.DELButton.Text = "DEL";
            this.DELButton.UseVisualStyleBackColor = true;
            this.DELButton.Click += new System.EventHandler(this.DELButton_Click);
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(167, 3);
            this.CButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(158, 88);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.MinimumSize = new System.Drawing.Size(109, 78);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(158, 88);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EQUALSButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(682, 690);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.Name = "Form1";
            this.Text = "Basic calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button EQUALSButton;
        private System.Windows.Forms.Button DOTButton;
        private System.Windows.Forms.Button ZEROButton;
        private System.Windows.Forms.Button PLUSButton;
        private System.Windows.Forms.Button THREEButton;
        private System.Windows.Forms.Button TWOButton;
        private System.Windows.Forms.Button ONEButton;
        private System.Windows.Forms.Button MINUSButton;
        private System.Windows.Forms.Button SIXButton;
        private System.Windows.Forms.Button FIVEButton;
        private System.Windows.Forms.Button FOURButton;
        private System.Windows.Forms.Button MULTIPLYButton;
        private System.Windows.Forms.Button NINEButton;
        private System.Windows.Forms.Button EIGHTButton;
        private System.Windows.Forms.Button SEVENButton;
        private System.Windows.Forms.Button MODULOButton;
        private System.Windows.Forms.Button DELButton;
        private System.Windows.Forms.Button CButton;
    }
}

