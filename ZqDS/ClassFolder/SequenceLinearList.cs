using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZqDS.ClassFolder
{
    class SequenceLinearList<T>
    {
        private T[] _dataContainer;
        private int _maxStorageSize;
        private int _dataLength;

        //获取数组空间大小
        public int ListSize
        {
            get
            {
                return _maxStorageSize;
            }
        }

        //获取数组空间数据元素个数
        public int DataLength
        {
            get => _dataLength;
        }
        
        //构造函数
        public SequenceLinearList(int maxSize)
        {
            _maxStorageSize = maxSize;
            _dataContainer = new T[_maxStorageSize];
            _dataLength = 0;
        }

        //显示数组元素
        public void ShowListData()
        {
            for (int i = 0; i < _dataLength; i++)
            {
                Console.Write("["+i+ "=" + _dataContainer[i] + "]  ");
            }
            Console.WriteLine();
        }

        //获取指定位置的元素
        public int GetElement(int index, ref T element)
        {
            if (0==_dataLength 
                || 0>index
                || _dataLength-1<index)
            {
                return -1;
            }

            element = _dataContainer[index];

            return 0;
        }

        //向指定位置写入元素
        public int StoreElement(int index, T element)
        {
            if (0 == _dataLength
                || 0 > index
                || _dataLength < index)
            {
                return -1;
            }

            _dataContainer[index] = element;

            return 0;
        }

        //追加元素
        public int AppendElement(T element)
        {
            if (_dataLength+1>_maxStorageSize)
            {
                return -1;
            }

            _dataContainer[_dataLength] = element;

            _dataLength++;

            return 0;
        }

        //删除指定位置的元素
        public int DeleteElement(int index, ref T element)
        {
            if (0 == _dataLength
                || 0 > index
                || _dataLength - 1 < index)
            {
                return -1;
            }

            element = _dataContainer[index];

            if (_dataLength - 1>index)
            {
                for (int i = index+1; i <_dataLength-1; i++)
                {
                    _dataContainer[i - 1] = _dataContainer[i];
                }
            }

            _dataLength--;

            return 0;
        }

        //向指定位置插入元素
        public int InsertElement(int index, T element)
        {
            if (0 == _dataLength
                || 0 > index
                || _dataLength - 1 < index)
            {
                return -1;
            }

            //判断容量
            if (_dataLength+1>_maxStorageSize)
            {
                return -1;
            }


            if (_dataLength - 1 > index)
            {
                for (int i = _dataLength - 1; i > index-1; i--)
                {
                    _dataContainer[i+1] = _dataContainer[i];
                }
            }

            _dataContainer[index] = element;

            _dataLength++;

            return 0;
        }

        //反转队列元素
        public int ReverseElement()
        {
            T temp;

            for (int i = 0; i < _dataLength/2; i++)
            {
                temp = _dataContainer[i];
                _dataContainer[i] = _dataContainer[_dataLength-1 - i];
                _dataContainer[_dataLength-1 - i] = temp;
            }
            return 0;
        }
    }
}
