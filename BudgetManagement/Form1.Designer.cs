namespace BudgetManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.descriptionColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.chartComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.remainLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionColumn,
            this.amountColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(10, 64);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 282);
            this.dataGridView1.TabIndex = 2;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.Name = "descriptionColumn";
            // 
            // amountColumn
            // 
            this.amountColumn.HeaderText = "Amount";
            this.amountColumn.Name = "amountColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "INCOME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(764, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Budget Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "COST";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionColumn2,
            this.amountColumn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView2.Location = new System.Drawing.Point(10, 383);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(493, 252);
            this.dataGridView2.TabIndex = 4;
            // 
            // descriptionColumn2
            // 
            this.descriptionColumn2.HeaderText = "Description";
            this.descriptionColumn2.Name = "descriptionColumn2";
            // 
            // amountColumn2
            // 
            this.amountColumn2.HeaderText = "Amount";
            this.amountColumn2.Name = "amountColumn2";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-6, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(516, 2);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(509, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 700);
            this.label5.TabIndex = 8;
            // 
            // chart3
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(516, 112);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.LimeGreen;
            series1.LabelToolTip = "#VAL{C2}";
            series1.Legend = "Legend1";
            series1.Name = "Income";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.LabelToolTip = "#VAL{C2}";
            series2.Legend = "Legend1";
            series2.Name = "Costs";
            this.chart3.Series.Add(series1);
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(530, 300);
            this.chart3.TabIndex = 9;
            this.chart3.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Income vs. Costs";
            this.chart3.Titles.Add(title1);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Location = new System.Drawing.Point(542, 77);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(102, 29);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.exportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.Location = new System.Drawing.Point(650, 77);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(89, 29);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "Export";
            this.exportButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.exportButton, "An image will be saved to \"C:/charts/\"");
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.openButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.ForeColor = System.Drawing.Color.White;
            this.openButton.Location = new System.Drawing.Point(6, 2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 26);
            this.openButton.TabIndex = 12;
            this.openButton.Text = " Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(-6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(516, 2);
            this.label6.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(87, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 26);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.toolTip2.SetToolTip(this.saveButton, "Files will be saved in \"C:/charts/\"");
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // chartComboBox
            // 
            this.chartComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.chartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chartComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chartComboBox.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartComboBox.ForeColor = System.Drawing.Color.Black;
            this.chartComboBox.FormattingEnabled = true;
            this.chartComboBox.Location = new System.Drawing.Point(542, 50);
            this.chartComboBox.Name = "chartComboBox";
            this.chartComboBox.Size = new System.Drawing.Size(197, 25);
            this.chartComboBox.Sorted = true;
            this.chartComboBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(539, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Type Chart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(548, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total amount of income:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(548, 533);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total amount of costs:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(548, 589);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total amount remaining:";
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLabel.ForeColor = System.Drawing.Color.Black;
            this.incomeLabel.Location = new System.Drawing.Point(876, 495);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(0, 20);
            this.incomeLabel.TabIndex = 21;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.ForeColor = System.Drawing.Color.Black;
            this.costLabel.Location = new System.Drawing.Point(876, 534);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(0, 20);
            this.costLabel.TabIndex = 22;
            // 
            // remainLabel
            // 
            this.remainLabel.AutoSize = true;
            this.remainLabel.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainLabel.ForeColor = System.Drawing.Color.Black;
            this.remainLabel.Location = new System.Drawing.Point(876, 589);
            this.remainLabel.Name = "remainLabel";
            this.remainLabel.Size = new System.Drawing.Size(0, 20);
            this.remainLabel.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(550, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(420, 2);
            this.label11.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 638);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.remainLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chartComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn2;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ComboBox chartComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label remainLabel;
        private System.Windows.Forms.Label label11;
    }
}

