
namespace Sorts
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbAdvanceSort = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoHeapSort = new System.Windows.Forms.RadioButton();
            this.rdoQuickSort = new System.Windows.Forms.RadioButton();
            this.rdoMergeSort = new System.Windows.Forms.RadioButton();
            this.grbBasicSort = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoInsertionSort = new System.Windows.Forms.RadioButton();
            this.rdoBubleSort = new System.Windows.Forms.RadioButton();
            this.rdoSelectionSort = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdoCreatingArray = new System.Windows.Forms.RadioButton();
            this.rdoType = new System.Windows.Forms.RadioButton();
            this.btnCreatingArray = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTimeExecute = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbAdvanceSort.SuspendLayout();
            this.grbBasicSort.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbAdvanceSort);
            this.groupBox1.Controls.Add(this.grbBasicSort);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn thuật toán sắp xếp";
            // 
            // grbAdvanceSort
            // 
            this.grbAdvanceSort.Controls.Add(this.label2);
            this.grbAdvanceSort.Controls.Add(this.rdoHeapSort);
            this.grbAdvanceSort.Controls.Add(this.rdoQuickSort);
            this.grbAdvanceSort.Controls.Add(this.rdoMergeSort);
            this.grbAdvanceSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAdvanceSort.Location = new System.Drawing.Point(213, 16);
            this.grbAdvanceSort.Name = "grbAdvanceSort";
            this.grbAdvanceSort.Size = new System.Drawing.Size(241, 142);
            this.grbAdvanceSort.TabIndex = 1;
            this.grbAdvanceSort.TabStop = false;
            this.grbAdvanceSort.Text = "Các thuật toán sắp xếp nâng cao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Các thuật toán này có độ phức tạp\r\ntrung bình là: O(N∗logN)";
            // 
            // rdoHeapSort
            // 
            this.rdoHeapSort.AutoSize = true;
            this.rdoHeapSort.Location = new System.Drawing.Point(9, 111);
            this.rdoHeapSort.Name = "rdoHeapSort";
            this.rdoHeapSort.Size = new System.Drawing.Size(167, 17);
            this.rdoHeapSort.TabIndex = 5;
            this.rdoHeapSort.TabStop = true;
            this.rdoHeapSort.Text = "Sắp xếp vun đống (HeapSort)";
            this.rdoHeapSort.UseVisualStyleBackColor = true;
            this.rdoHeapSort.Click += new System.EventHandler(this.rdoHeapSort_Click);
            // 
            // rdoQuickSort
            // 
            this.rdoQuickSort.AutoSize = true;
            this.rdoQuickSort.Location = new System.Drawing.Point(9, 56);
            this.rdoQuickSort.Name = "rdoQuickSort";
            this.rdoQuickSort.Size = new System.Drawing.Size(153, 17);
            this.rdoQuickSort.TabIndex = 3;
            this.rdoQuickSort.TabStop = true;
            this.rdoQuickSort.Text = "Sắp xếp nhanh (QuickSort)";
            this.rdoQuickSort.UseVisualStyleBackColor = true;
            this.rdoQuickSort.Click += new System.EventHandler(this.rdoQuickSort_Click);
            // 
            // rdoMergeSort
            // 
            this.rdoMergeSort.AutoSize = true;
            this.rdoMergeSort.Location = new System.Drawing.Point(9, 84);
            this.rdoMergeSort.Name = "rdoMergeSort";
            this.rdoMergeSort.Size = new System.Drawing.Size(143, 17);
            this.rdoMergeSort.TabIndex = 4;
            this.rdoMergeSort.TabStop = true;
            this.rdoMergeSort.Text = "Sắp xếp trộn (MergeSort)";
            this.rdoMergeSort.UseVisualStyleBackColor = true;
            this.rdoMergeSort.Click += new System.EventHandler(this.rdoMergeSort_Click);
            // 
            // grbBasicSort
            // 
            this.grbBasicSort.Controls.Add(this.label1);
            this.grbBasicSort.Controls.Add(this.rdoInsertionSort);
            this.grbBasicSort.Controls.Add(this.rdoBubleSort);
            this.grbBasicSort.Controls.Add(this.rdoSelectionSort);
            this.grbBasicSort.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbBasicSort.Location = new System.Drawing.Point(3, 16);
            this.grbBasicSort.Name = "grbBasicSort";
            this.grbBasicSort.Size = new System.Drawing.Size(210, 142);
            this.grbBasicSort.TabIndex = 0;
            this.grbBasicSort.TabStop = false;
            this.grbBasicSort.Text = "Các thuật toán sắp xếp cơ bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Các thuật toán này có độ phức tạp\r\ntrung bình là: O(N^2) ";
            // 
            // rdoInsertionSort
            // 
            this.rdoInsertionSort.AutoSize = true;
            this.rdoInsertionSort.Location = new System.Drawing.Point(12, 111);
            this.rdoInsertionSort.Name = "rdoInsertionSort";
            this.rdoInsertionSort.Size = new System.Drawing.Size(159, 17);
            this.rdoInsertionSort.TabIndex = 2;
            this.rdoInsertionSort.TabStop = true;
            this.rdoInsertionSort.Text = "Sắp xếp chèn (InsertionSort)";
            this.rdoInsertionSort.UseVisualStyleBackColor = true;
            this.rdoInsertionSort.Click += new System.EventHandler(this.rdoInsertionSort_Click);
            // 
            // rdoBubleSort
            // 
            this.rdoBubleSort.AutoSize = true;
            this.rdoBubleSort.Location = new System.Drawing.Point(12, 84);
            this.rdoBubleSort.Name = "rdoBubleSort";
            this.rdoBubleSort.Size = new System.Drawing.Size(160, 17);
            this.rdoBubleSort.TabIndex = 1;
            this.rdoBubleSort.TabStop = true;
            this.rdoBubleSort.Text = "Sắp xếp nổi bọt (BubbleSort)";
            this.rdoBubleSort.UseVisualStyleBackColor = true;
            this.rdoBubleSort.Click += new System.EventHandler(this.rdoBubleSort_Click);
            // 
            // rdoSelectionSort
            // 
            this.rdoSelectionSort.AutoSize = true;
            this.rdoSelectionSort.Checked = true;
            this.rdoSelectionSort.Location = new System.Drawing.Point(12, 56);
            this.rdoSelectionSort.Name = "rdoSelectionSort";
            this.rdoSelectionSort.Size = new System.Drawing.Size(163, 17);
            this.rdoSelectionSort.TabIndex = 0;
            this.rdoSelectionSort.TabStop = true;
            this.rdoSelectionSort.Text = "Sắp xếp chọn (SelectionSort)";
            this.rdoSelectionSort.UseVisualStyleBackColor = true;
            this.rdoSelectionSort.Click += new System.EventHandler(this.rdoSelectionSort_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbInput);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 161);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 179);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Input";
            // 
            // rtbInput
            // 
            this.rtbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInput.Location = new System.Drawing.Point(3, 80);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(451, 96);
            this.rtbInput.TabIndex = 4;
            this.rtbInput.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdoCreatingArray);
            this.groupBox6.Controls.Add(this.rdoType);
            this.groupBox6.Controls.Add(this.btnCreatingArray);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.txtN);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(451, 64);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // rdoCreatingArray
            // 
            this.rdoCreatingArray.AutoSize = true;
            this.rdoCreatingArray.Location = new System.Drawing.Point(6, 0);
            this.rdoCreatingArray.Name = "rdoCreatingArray";
            this.rdoCreatingArray.Size = new System.Drawing.Size(115, 17);
            this.rdoCreatingArray.TabIndex = 6;
            this.rdoCreatingArray.TabStop = true;
            this.rdoCreatingArray.Text = "Sinh mảng tự động";
            this.rdoCreatingArray.UseVisualStyleBackColor = true;
            this.rdoCreatingArray.CheckedChanged += new System.EventHandler(this.rdoCreatingArray_CheckedChanged);
            // 
            // rdoType
            // 
            this.rdoType.AutoSize = true;
            this.rdoType.Location = new System.Drawing.Point(144, 0);
            this.rdoType.Name = "rdoType";
            this.rdoType.Size = new System.Drawing.Size(68, 17);
            this.rdoType.TabIndex = 7;
            this.rdoType.TabStop = true;
            this.rdoType.Text = "Nhập tay";
            this.rdoType.UseVisualStyleBackColor = true;
            this.rdoType.CheckedChanged += new System.EventHandler(this.rdoType_CheckedChanged);
            // 
            // btnCreatingArray
            // 
            this.btnCreatingArray.Location = new System.Drawing.Point(194, 25);
            this.btnCreatingArray.Name = "btnCreatingArray";
            this.btnCreatingArray.Size = new System.Drawing.Size(75, 23);
            this.btnCreatingArray.TabIndex = 2;
            this.btnCreatingArray.Text = "Tạo mảng";
            this.btnCreatingArray.UseVisualStyleBackColor = true;
            this.btnCreatingArray.Click += new System.EventHandler(this.btnCreatingArray_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đưa vào kích \r\nthước mảng: ";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(88, 27);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(74, 20);
            this.txtN.TabIndex = 1;
            this.txtN.Text = "10";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rtbOutput);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 340);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(457, 207);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutput.Location = new System.Drawing.Point(3, 69);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(451, 135);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTimeExecute);
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 53);
            this.panel1.TabIndex = 0;
            // 
            // lbTimeExecute
            // 
            this.lbTimeExecute.AutoSize = true;
            this.lbTimeExecute.Location = new System.Drawing.Point(9, 34);
            this.lbTimeExecute.Name = "lbTimeExecute";
            this.lbTimeExecute.Size = new System.Drawing.Size(101, 13);
            this.lbTimeExecute.TabIndex = 0;
            this.lbTimeExecute.Text = "Thời gian thực hiện:";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(457, 547);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorts";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.groupBox1.ResumeLayout(false);
            this.grbAdvanceSort.ResumeLayout(false);
            this.grbAdvanceSort.PerformLayout();
            this.grbBasicSort.ResumeLayout(false);
            this.grbBasicSort.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbAdvanceSort;
        private System.Windows.Forms.GroupBox grbBasicSort;
        private System.Windows.Forms.RadioButton rdoInsertionSort;
        private System.Windows.Forms.RadioButton rdoBubleSort;
        private System.Windows.Forms.RadioButton rdoSelectionSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTimeExecute;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdoCreatingArray;
        private System.Windows.Forms.RadioButton rdoType;
        private System.Windows.Forms.Button btnCreatingArray;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.RadioButton rdoHeapSort;
        private System.Windows.Forms.RadioButton rdoQuickSort;
        private System.Windows.Forms.RadioButton rdoMergeSort;
        private System.Windows.Forms.Button btnSort;
    }
}

