using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Scripts : MonoBehaviour
{
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.
    int[] nums = new int[4] { 2, 7, 11, 15 };
    public int target = 9;

    [ContextMenu("task1")]
    public void Task1()
    {
        int a;
        int b;
        int sum;
        for (int i = 0; i < nums.Length; i++)
        {
            a = nums[i];
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    sum = 0;
                }
                else
                {
                    b = nums[j];
                    sum = a + b;
                    if (sum == target)
                    {
                        Debug.Log($" {i}, {j}");
                    }
                }
            }
        }
    }

    //Given an integer x, return true if x is a palindrome, and false otherwise.

    public int palindrome = 122;

    [ContextMenu("task2")]
    public void Task2()
    {
        string text = palindrome.ToString();
        char[] chars = text.ToCharArray();
        bool isPalindrome()
        {
            for (int i = 0; i < chars.Length / 2; i++)
            {
                if (chars[i] != chars[chars.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        Debug.Log(isPalindrome());
    }
    //You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
    //    The digits are ordered from most significant to least significant 
    //    in left-to-right order. The large integer does not contain any leading 0's.
    //Increment the large integer by one and return the resulting array of digits.
    [ContextMenu("task3")]
    public void Task3()
    {
        List<int> arr1 = new List<int>() { 1, 2, 9 };

        void sumLastNum(List<int> arr)
        {
            var last1Num = arr.Last();
            last1Num = ++last1Num;
            if (last1Num == 10)
            {
                arr.RemoveAt(arr.Count - 1);
                arr.Add(1);
                arr.Add(0);
            }
            else
            {
                arr.RemoveAt(arr.Count - 1);
                arr.Add(last1Num);
            }

            Debug.Log(String.Join(",", arr));
        }
        sumLastNum(arr1);
    }
    // Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    Dictionary<string, int> RomanNum =
        new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 },
        };




    [ContextMenu("task4")]
    public void task4()
    {

        string num = "LVII";
        char[] chars = num.ToArray();
        int sum = 0;
        for (int i = 0; i < chars.Length; i++)
        {

            int findNum = RomanNum.GetValueOrDefault(chars[i].ToString());
            sum += findNum;
        }
        Debug.Log(sum);

    }

}
