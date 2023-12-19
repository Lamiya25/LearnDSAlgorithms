using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms
{
    public class BinaryLinearSearch
    {
        public int binarysearch(int[] A, int key, int l, int r)
        {
            if (l > r)
                return -1;
            else
            {
                int mid = (l + r) / 2;
                if (key == A[mid])
                    return mid;
                else if (key < A[mid])
                    return binarysearch(A, key, l, mid - 1);
                else if (key > A[mid])
                    return binarysearch(A, key, mid + 1, r);
            }
            return -1;
        }
        public int binarysearchIterative(int[] A, int n, int key)
        {
            int l = 0;
            int r = n - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (key == A[mid])
                    return mid;
                else if (key < A[mid])
                    r = mid - 1;
                else if (key > A[mid])
                    l = mid + 1;
            }
            return -1;
        }
      

        public int BinarySearchTwoDimension(int[,] A, int key)
        {
            int l = 0;
            int r = A.Length - 1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    int middle = (l + r) / 2;
                    if (A[i, j] == middle)
                    {
                        return middle;
                    }
                    else if (key < A[i, j])
                    {
                        r = middle - 1;
                    }

                    else if (key > A[i, j])
                    {
                        l = middle + 1;
                    }
                }
            }
            return -1;
        }

        public int binarysearchrecursive(int[] A, int key, int l, int r)
        {
            if (l > r)
            {
                return -1;
            }
            else
            {
                int mid = (l + r) / 2;
                if (A[mid] == key)
                {
                    return mid;
                }
                else if (key < A[mid])
                {
                    return binarysearchrecursive(A, key, l, mid - 1);
                }
                else if (key > A[mid])
                {
                    return binarysearchrecursive(A, key, mid + 1, r);
                }
            }
            return -1;
        }

        //LinearSearch
        public int linearsearch(int[] A, int n, int key)
        {
            int index = 0;
            while (index < n)
            {
                if (A[index] == key)
                    return index;
                index = index + 1;
            }
            return -1;
        }
    }
}
