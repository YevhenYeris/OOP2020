namespace FifthAssignment
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectFigure = new System.Windows.Forms.ComboBox();
            this.inputData = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.selectActionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.selectAction = new System.Windows.Forms.ComboBox();
            this.calculate = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.inputData.SuspendLayout();
            this.selectActionLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.selectFigure, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputData, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectActionLayout, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.resultBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectFigure
            // 
            this.selectFigure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFigure.FormattingEnabled = true;
            this.selectFigure.Items.AddRange(new object[] {
            "Трикутник",
            "Круг",
            "Прямокутник",
            "Квадрат",
            "Ромб"});
            this.selectFigure.Location = new System.Drawing.Point(3, 3);
            this.selectFigure.Name = "selectFigure";
            this.selectFigure.Size = new System.Drawing.Size(394, 28);
            this.selectFigure.TabIndex = 0;
            this.selectFigure.SelectedIndexChanged += new System.EventHandler(this.selectFigure_SelectedIndexChanged);
            // 
            // inputData
            // 
            this.inputData.ColumnCount = 2;
            this.inputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.91878F));
            this.inputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.08121F));
            this.inputData.Controls.Add(this.label1, 0, 0);
            this.inputData.Controls.Add(this.label2, 0, 1);
            this.inputData.Controls.Add(this.label3, 0, 2);
            this.inputData.Controls.Add(this.textBox1, 1, 0);
            this.inputData.Controls.Add(this.textBox2, 1, 1);
            this.inputData.Controls.Add(this.textBox3, 1, 2);
            this.inputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputData.Location = new System.Drawing.Point(403, 3);
            this.inputData.Name = "inputData";
            this.inputData.RowCount = 3;
            this.inputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.inputData.Size = new System.Drawing.Size(394, 219);
            this.inputData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 76);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 67);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(113, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(113, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 27);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(113, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(278, 27);
            this.textBox3.TabIndex = 5;
            // 
            // selectActionLayout
            // 
            this.selectActionLayout.ColumnCount = 2;
            this.selectActionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.16751F));
            this.selectActionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.83249F));
            this.selectActionLayout.Controls.Add(this.selectAction, 0, 0);
            this.selectActionLayout.Controls.Add(this.calculate, 1, 0);
            this.selectActionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectActionLayout.Location = new System.Drawing.Point(3, 228);
            this.selectActionLayout.Name = "selectActionLayout";
            this.selectActionLayout.RowCount = 1;
            this.selectActionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectActionLayout.Size = new System.Drawing.Size(394, 219);
            this.selectActionLayout.TabIndex = 2;
            // 
            // selectAction
            // 
            this.selectAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAction.FormattingEnabled = true;
            this.selectAction.Items.AddRange(new object[] {
            "Периметр",
            "Площа"});
            this.selectAction.Location = new System.Drawing.Point(3, 3);
            this.selectAction.Name = "selectAction";
            this.selectAction.Size = new System.Drawing.Size(235, 28);
            this.selectAction.TabIndex = 0;
            this.selectAction.SelectedIndexChanged += new System.EventHandler(this.selectLayout_SelectedIndexChanged);
            // 
            // calculate
            // 
            this.calculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculate.Location = new System.Drawing.Point(244, 3);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(147, 213);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Знайти";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // resultBox
            // 
            this.resultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultBox.Location = new System.Drawing.Point(403, 228);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(394, 219);
            this.resultBox.TabIndex = 3;
            this.resultBox.Text = "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.inputData.ResumeLayout(false);
            this.inputData.PerformLayout();
            this.selectActionLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox selectFigure;
        private System.Windows.Forms.TableLayoutPanel inputData;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TableLayoutPanel selectActionLayout;
        private System.Windows.Forms.ComboBox ccc;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox selectAction;
    }
}

