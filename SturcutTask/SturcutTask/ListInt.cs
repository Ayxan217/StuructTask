using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SturcutTask
{
    internal class ListInt
    {
        private int[] _arr;
        public ListInt()
        {
            _arr = new int[0]; 
        }
        public ListInt(int length)
        {
            _arr = new int[_arr.Length];
        }
        public ListInt(params int[] nums)
        {
            _arr = nums;
        }
        public int Length
        {
            get
            {
                return _arr.Length;
            }
        }
        public int this[int index]
        {
            get
            {
                if (index >= _arr.Length)
                {
                    return _arr[_arr.Length - 1];
                }
                
                return _arr[index];
            }

            set
            {

                if (index < _arr.Length)
                {

                _arr[index] = value;
                }
            }
        }

        public void Add(int num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = num;
            Console.WriteLine($"{num} ededi elave olundu");
        }

        public void AddRange(params int[] nums)
        {
            int oldLength = _arr.Length;
            Array.Resize(ref _arr, _arr.Length + nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                _arr[oldLength + i] = nums[i];
                
            }
        }

        public bool Containts(int num)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (num == _arr[i])
                {
                    Console.WriteLine($"{num} ededi tapıldı");
                    return true;
                }
               
            }
            Console.WriteLine(" eded tapılmadı");
            return false;
               
        }
        public void Sum()
        {
            int sum = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                sum += _arr[i];
            }
            Console.WriteLine($"cem: {sum}");
        }
        public void Remove(int num)
        {
            int j = 0;
            int[] newArr = new int[_arr.Length - 1];

            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] != num)
                {
                    newArr[j] = _arr[i];
                    j++;

                }
            }
            _arr = newArr;
            Console.WriteLine($"{num} ededi silindi");


        }


        public void RemoveRange(params int[] nums)
        {
            int j = 0;
            
            int[] newArr = new int[_arr.Length - nums.Length];

            for (int i = 0; i < _arr.Length; i++)
            {
               
                bool shouldRemove = false;

                
                for (int k = 0; k < nums.Length; k++)
                {
                    if (_arr[i] == nums[k])
                    {
                        shouldRemove = true;
                        
                        break;
                    }
                }

                
                if (!shouldRemove)
                {
                    newArr[j] = _arr[i];
                    j++;
                }
            }

           
            _arr = newArr;
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < _arr.Length; i++)
            {
                res += _arr[i];


                if (i < _arr.Length - 1)
                {
                    res += ", ";
                }
            }
            
            return res;
        }



    }
}
    

