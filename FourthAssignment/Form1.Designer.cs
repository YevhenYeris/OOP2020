namespace FourthAssignment
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
            this.selectAction = new System.Windows.Forms.ComboBox();
            this.sidesInput = new System.Windows.Forms.TableLayoutPanel();
            this.sideB = new System.Windows.Forms.TextBox();
            this.sideC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sideA = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sidesInput.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectAction
            // 
            this.selectAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAction.FormattingEnabled = true;
            this.selectAction.Items.AddRange(new object[] {
            "Периметр",
            "Кути"});
            this.selectAction.Location = new System.Drawing.Point(156, 62);
            this.selectAction.Name = "selectAction";
            this.selectAction.Size = new System.Drawing.Size(125, 28);
            this.selectAction.TabIndex = 0;
            this.selectAction.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sidesInput
            // 
            this.sidesInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidesInput.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.sidesInput.ColumnCount = 2;
            this.sidesInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.30303F));
            this.sidesInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.69697F));
            this.sidesInput.Controls.Add(this.sideB, 1, 1);
            this.sidesInput.Controls.Add(this.sideC, 1, 2);
            this.sidesInput.Controls.Add(this.label1, 0, 0);
            this.sidesInput.Controls.Add(this.label2, 0, 1);
            this.sidesInput.Controls.Add(this.label3, 0, 2);
            this.sidesInput.Controls.Add(this.sideA, 1, 0);
            this.sidesInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidesInput.Location = new System.Drawing.Point(3, 3);
            this.sidesInput.Name = "sidesInput";
            this.sidesInput.Padding = new System.Windows.Forms.Padding(10);
            this.sidesInput.RowCount = 3;
            this.sidesInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sidesInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sidesInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.sidesInput.Size = new System.Drawing.Size(147, 147);
            this.sidesInput.TabIndex = 1;
            // 
            // sideB
            // 
            this.sideB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideB.Location = new System.Drawing.Point(52, 55);
            this.sideB.Name = "sideB";
            this.sideB.Size = new System.Drawing.Size(81, 27);
            this.sideB.TabIndex = 1;
            this.sideB.Text = "0";
            this.sideB.TextChanged += new System.EventHandler(this.sideB_TextChanged);
            // 
            // sideC
            // 
            this.sideC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideC.Location = new System.Drawing.Point(52, 96);
            this.sideC.Name = "sideC";
            this.sideC.Size = new System.Drawing.Size(81, 27);
            this.sideC.TabIndex = 2;
            this.sideC.Text = "0";
            this.sideC.TextChanged += new System.EventHandler(this.sideC_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 40);
            this.label1.TabIndex = 3;
            this.label1.Tag = "";
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "b";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "c";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sideA
            // 
            this.sideA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideA.Location = new System.Drawing.Point(52, 14);
            this.sideA.Name = "sideA";
            this.sideA.Size = new System.Drawing.Size(81, 27);
            this.sideA.TabIndex = 0;
            this.sideA.Text = "0";
            this.sideA.TextChanged += new System.EventHandler(this.sideA_TextChanged);
            // 
            // calculate
            // 
            this.calculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculate.Location = new System.Drawing.Point(287, 3);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(70, 147);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Знайти";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Location = new System.Drawing.Point(363, 3);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(116, 147);
            this.result.TabIndex = 4;
            this.result.Text = "";
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.71622F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.28378F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.Controls.Add(this.sidesInput, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.result, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.calculate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectAction, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 153);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 153);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "Form1";
            this.Text = "Площа трикутника";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidesInput.ResumeLayout(false);
            this.sidesInput.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selectAction;
        private System.Windows.Forms.TableLayoutPanel sidesInput;
        private System.Windows.Forms.TextBox sideA;
        private System.Windows.Forms.TextBox sideB;
        private System.Windows.Forms.TextBox sideC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

