using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    static class Sorts
    {
        // Hàm hoán đổi vị trí s1 và s2
        static void Swap(ref int s1, ref int s2)
        {
            int temp = s1;
            s1 = s2;
            s2 = temp;
        }

        // Hàm hoán đổi vị trí s1 và s2 
        // không dùng biến tạm
        static void SwapNotTemp(ref int s1, ref int s2)
        {
            s2 = s1 + s2;
            s1 = s2 - s1;
            s2 = s2 - s1;
        }

        // Sắp xếp chọn
        public static void SelectionSort(ref int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        // Hoán đổi vị trí a[i] và a[j]
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
        }

        // Sắp xếp nổi bọt
        public static void BubbleSort(ref int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        // Hoán đổi vị trí a[j] và a[j+1]
                        Swap(ref a[j], ref a[j + 1]);
                    }
                }
            }
        }

        // Sắp xếp chèn
        public static void InsertionSort(ref int[] a)
        {
            int n = a.Length;
            int t, j;
            for (int i = 1; i < n; i++)
            {
                j = i - 1;
                t = a[i];
                while (j >= 0 && t < a[j])
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = t; // Chèn
            }
        }

        // Sắp xếp nhanh 
        // l là index đầu tiên của mảng, r là index cuối cùng của mảng
        public static void QuickSort(ref int[] data, int l, int r)
        {
            // Nếu index đầu tiên <= index cuối cùng
            if (l <= r)
            {
                // Tạo phần tử key (ở đây lấy giá trị giữa của mảng)
                int key = data[(l + r) / 2];

                // Tạo biến tạm để lặp
                int i = l;
                int j = r;

                while (i <= j)
                {
                    while (data[i] < key)
                        i++;
                    while (data[j] > key)
                        j--;

                    if (i <= j)
                    {
                        Swap(ref data[i], ref data[j]);
                        i++;
                        j--;
                    }
                }

                // Đệ quy
                if (l < j)
                    QuickSort(ref data, l, j);
                if (r > i)
                    QuickSort(ref data, i, r);
            }
        }

        #region Sắp xếp trộn
        // Sắp xếp các phần tử có chỉ số từ left đến right của mảng data.
        static void Merge(ref int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            //tạo 2 mảng tạm thời để chứa các phần tử sau khi chia
            int[] L = new int[n1];
            int[] R = new int[n2];

            // Copy dữ liệu sang các mảng tạm 
            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];

            // khởi tạo các giá trị ban đầu
            i = 0;
            j = 0;
            k = l;

            //gộp hai mảng tạm thời vào mảng arr
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy các phần tử còn lại của mảng L vào arr nếu có 
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy các phần tử còn lại của mảng R vào arr nếu có 
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // l là chỉ số trái và r là chỉ số phải của mảng cần được sắp xếp 
        public static void MergeSort(ref int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                // Gọi hàm đệ quy tiếp tục chia đôi từng nửa mảng
                MergeSort(ref arr, l, m);
                MergeSort(ref arr, m + 1, r);

                Merge(ref arr, l, m, r);
            }
        }
        #endregion

        #region Sắp xếp vun đống
        // Sắp xếp vun đống
        public static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            // Tạo Heap
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // Lấy phần tử từ Heap
            for (int i = n - 1; i > 0; i--)
            {
                // Duyệt từ gốc đến hết
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Lấy giá trị lớn nhất từ Heap
                Heapify(arr, i, 0);
            }
        }

        // Xây dựng một Heap
        public static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;   // Nút gốc (nút có giá trị lớn nhất)
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            // Nếu nút con bên trái lớn hơn nút gốc
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // Nếu nút con bên phải lớn hơn giá trị lớn nhất
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // Nếu giá trị lớn nhất không phải là gốc
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Đệ quy
                Heapify(arr, n, largest);
            }
        }
        #endregion
    }
}
