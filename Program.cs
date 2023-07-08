namespace LeetCodeSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }


        /// <summary>
        /// 2395. Find Subarrays With Equal Sum
        /// Given a 0-indexed integer array nums, determine whether there exist two subarrays of length 2 with equal sum. Note that the two subarrays must begin at different indices.
        ///Return true if these subarrays exist, and false otherwise.
        ///A subarray is a contiguous non-empty sequence of elements within an array.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool FindSubarrays(int[] num)
        {
            int tempNum1;
            int tempNum2;
            for (int i = 0; i < (num.Length - 1); i++)
            {

                //Console.WriteLine(tempNum1);
                //Console.WriteLine(tempNum2);
                int j = i + 1;
                tempNum1 = num[i] + num[j];
                while (j < (num.Length - 1))
                {
                    tempNum2 = num[j] + num[j + 1];
                    if (tempNum2 == tempNum1)
                    {
                        return true;
                    }
                    j++;
                }


            }

            return false;
        }


        /// <summary>
        /// 876. Middle of the Linked List
        /// 
        /// Given the head of a singly linked list, return the middle node of the linked list.
        ///If there are two middle nodes, return the second middle node.
        ///
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode MiddleNode(ListNode head)
        {
            int count = 1;
            int middle;
            ListNode currentNode = head;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
                count++;
            }
            middle = (count / 2) + 1;
            currentNode = head;
            for (int i = 1; i < middle; i++)
            {
                currentNode = currentNode.next;
            }
            return currentNode;
        }


        /// <summary>
        /// 1. Two Sum
        /// 
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        ///You can return the answer in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {


            int[] returnArray = { 0, 0 };
            for (int i = 0; i < nums.Length - 1; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[i] + nums[j] == target)
                    {
                        returnArray[0] = i;
                        returnArray[1] = j;
                        return returnArray;
                    }

                }

            }

            return null;
        }


        /// <summary>
        /// 121. Best Time to Buy and Sell Stock
        /// You are given an array prices where prices[i] is the price of a given stock on the ith day.
        ///You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
        ///Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int buy = 0;
            int sell = 1;
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < prices[buy])
                {
                    buy = i;
                }
                if (prices[i] - prices[buy] > maxProfit)
                {
                    maxProfit = prices[i] - prices[buy];
                    sell = i;
                }
            }
            return maxProfit;



        }

        /// <summary>
        /// 217. Contains Duplicate
        /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>();
            foreach (int num in nums)
            {
                if (numSet.Contains(num))
                {
                    return true;
                }
                else
                {
                    numSet.Add(num);
                }
            }
            return false;
        }

        /// <summary>
        /// 70. Climbing Stairs
        /// 
        /// You are climbing a staircase. It takes n steps to reach the top.
        /// Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs(int n)
        {

            if (n == 0 || n == 1 || n == 2)
            {
                return n;
            }
            int[] fibArray = new int[n];
            fibArray[0] = 1;
            fibArray[1] = 2;
            for (int i = 2; i < n; i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
            }

            return fibArray[n - 1];
        }

        /// <summary>
        /// 104. Maximum Depth of Binary Tree
        /// Given the root of a binary tree, return its maximum depth.
        ///A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);
            return Math.Max(leftDepth, rightDepth) + 1;


        }

        /// <summary>
        /// 100. Same Tree
        /// Given the roots of two binary trees p and q, write a function to check if they are the same or not.
        ///Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            else if (p == null || q == null)
            {
                return false;
            }
            else if (p.val != q.val)
            {
                return false;
            }
            if (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 88. Merge Sorted Array
        /// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
        /// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
        /// The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var numList = new List<int>();

            if (n == 0)
            {
                //nums1 is already sorted, so do nothing
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    numList.Add(nums1[i]);
                }
                for (int j = 0; j < n; j++)
                {
                    numList.Add(nums2[j]);
                }
                numList.Sort();
                int k = 0;
                foreach (var num in numList)
                {
                    nums1[k] = num;
                    k++;
                }

            }

        }




    }
}