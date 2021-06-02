using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorts
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        void RevokeCheckedSortAdvanceSort()
        {
            rdoQuickSort.Checked = false;
            rdoMergeSort.Checked = false;
            rdoHeapSort.Checked = false;
        }

        void RevokeCheckedSortBasicSort()
        {
            rdoSelectionSort.Checked = false;
            rdoBubleSort.Checked = false;
            rdoInsertionSort.Checked = false;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            RevokeCheckedSortAdvanceSort();
            rdoSelectionSort.Checked = true;
            rdoCreatingArray.Checked = true;
        }

        private void rdoSelectionSort_Click(object sender, EventArgs e)
        {
            RevokeCheckedSortAdvanceSort();
        }

        
        private void rdoBubleSort_Click(object sender, EventArgs e)
        {
            RevokeCheckedSortAdvanceSort();
        }

        private void rdoInsertionSort_Click(object sender, EventArgs e)
        {
            RevokeCheckedSortAdvanceSort();
        }

        private void rdoQuickSort_Click(object sender, EventArgs e)
        {
            RevokeCheckedSortBasicSort();
        }

        private void rdoMergeSort_Click(object sender, EventArgs e)
        {
            RevokeCheckedSortBasicSort();
        }

        private void rdoHeapSort_Click(object sender, EventArgs e)
        {
            RevokeCheckedSortBasicSort();
        }

        private void btnCreatingArray_Click(object sender, EventArgs e)
        {
            try
            {
                rtbInput.Text = "";
                int n = (int)Math.Round(Convert.ToDouble(txtN.Text), 1);
                int[] a = new int[n];
                string s = "";
                for (int i = 0; i < n; i++)
                {
                    Thread.Sleep(10);
                    a[i] = new Random().Next(0, 10000);
                    s += a[i] + ",";
                }
                s = s.Substring(0, s.Length - 1);
                rtbInput.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdoCreatingArray_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreatingArray.Checked)
            {
                txtN.Enabled = true;
                btnCreatingArray.Enabled = true;
            }
        }

        private void rdoType_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoType.Checked)
            {
                txtN.Enabled = false;
                btnCreatingArray.Enabled = false;
                rtbInput.Text = "";
            }         
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {               
                string[] s = rtbInput.Text.Split(',');
                int[] a = new int[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    a[i] = (int)Math.Round(Convert.ToDouble(s[i]),1);
                }
                Stopwatch sw = new Stopwatch(); 
                if (rdoSelectionSort.Checked)
                {
                    sw.Start();
                    Sorts.SelectionSort(ref a);
                    sw.Stop();
                }
                else if (rdoBubleSort.Checked)
                {
                    sw.Start();
                    Sorts.BubbleSort(ref a);
                    sw.Stop();
                }
                else if (rdoInsertionSort.Checked)
                {
                    sw.Start();
                    Sorts.InsertionSort(ref a);
                    sw.Stop();
                }
                else if (rdoQuickSort.Checked)
                {
                    sw.Start();
                    Sorts.QuickSort(ref a, 0, a.Length - 1);
                    sw.Stop();
                }
                else if (rdoMergeSort.Checked)
                {
                    sw.Start();
                    Sorts.MergeSort(ref a, 0, a.Length - 1);
                    sw.Stop();
                }
                else if (rdoHeapSort.Checked)
                {
                    sw.Start();
                    Sorts.HeapSort(a);
                    sw.Stop();
                }
                
                lbTimeExecute.Text = "Thời gian thực hiện:  " + sw.Elapsed.TotalMilliseconds + " mili giây (ms)";
                string res = "";
                for (int i = 0; i < s.Length; i++)
                {
                    res += a[i] + ",";
                }
                res = res.Substring(0, res.Length -1);
                rtbOutput.Text = res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
