using System;

namespace DataStructures
{
    public class ArrayList
    {
        private int[] _array;
        private int _TrueLength
        {
            get
            {
                return _array.Length;
            }
        }
        public int Length { get; private set; }
        public ArrayList()
        {
            _array = new int[9];
            Length = 0;
        }
        public ArrayList(int a)
        {
            _array = new int[9];
            _array[0] = a;
            Length = 1;
        }
        public ArrayList(int[] array)
        {
            _array = new int[(int)(array.Length * 1.33)];
            Array.Copy(array, _array, array.Length);
            Length = array.Length;
        }
        public int this[int index]
        {
            get
            {
                if (index > Length - 1)
                {
                    throw new Exception();
                }
                return _array[index];
            }
            set
            {
                if (index > Length - 1)
                {
                    throw new Exception();
                }
                _array[index] = value;
            }
        }
        public void Add(int number)
        {
            if (Length >= _TrueLength)
            {
                IncreaseLenght();
            }
            _array[Length] = number;
            Length++;
        }
        public void Add(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Length >= _TrueLength)
                {
                    IncreaseLenght(1);
                }
                _array[Length] = array[i];
                Length++;
            }
        }
        public void AddFirst(int value)
        {
            if (Length >= _TrueLength)
            {
                IncreaseLenght();
            }
            Length++;
            int tmpFirst = _array[0];
            int tmpSecond;
            _array[0] = value;
            for (int i = 1; i < Length; i++)
            {
                tmpSecond = _array[i];
                _array[i] = tmpFirst;
                tmpFirst = tmpSecond;
            }
        }
        public void AddFirst(int[] array)
        {
            while (Length + array.Length >= _TrueLength)
            {
                IncreaseLenght();
            }
            int[] newArray = new int[Length + array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = 0; i < Length; i++)
            {
                newArray[array.Length + i] = _array[i];
            }
            _array = newArray;
            Length += array.Length;
        }
        public void AddByIndex(int index, int value)
        {
            if (index < 0)
            {
                throw new Exception();
            }
            Length++;
            if (Length >= _TrueLength)
            {
                IncreaseLenght();
            }
            int tmp1 = _array[index];
            int tmp2;
            _array[index] = value;
            for (int i = index; i < Length; i++)
            {
                tmp2 = _array[i + 1];
                _array[i + 1] = tmp1;
                tmp1 = tmp2;
            }
        }
        public void AddByIndex(int index, int[] array)
        {
            Length += array.Length;
            while (Length >= _TrueLength)
            {
                IncreaseLenght();
            }
            int[] tmpArray = new int[array.Length + (Length - index)];
            for (int i = 0; i < array.Length; i++)
            {
                tmpArray[i] = array[i];
            }
            for (int i = array.Length, k = 0; i < tmpArray.Length; i++, k++)
            {
                tmpArray[i] = _array[index + k];
            }
            for (int i = index, k = 0; i < Length; i++, k++)
            {
                _array[i] = tmpArray[k];
            }
        }
        public void Remove()
        {
            if (Length > _TrueLength / 2)
            {
                ReduceSize(1);
            }
            Length--;
        }
        public void Remove(int quatity)
        {
            if (quatity < 0)
            {
                throw new Exception();
            }
            for (int i = 0; i < quatity; i++)
            {
                if (Length < _TrueLength / 2)
                {
                    ReduceSize(1);
                }
                Length--;
            }
        }
        public void RemoveFirst()
        {
            while (Length < _TrueLength / 2)
            {
                ReduceSize(1);
            }
            if (Length > 1)
            {
                for (int i = 0; i < Length; i++)
                {
                    _array[i] = _array[i + 1];
                }
                Length--;
            }
            else
            {
                Length--;
            }
        }
        public void RemoveFirst(int quantity)
        {
            if (quantity < 0 || quantity > Length)
            {
                throw new Exception();
            }
            for (int i = quantity, k = 0; i < Length; i++, k++)
            {
                _array[k] = _array[quantity + k];
            }
            while (Length < _TrueLength / 2)
            {
                ReduceSize(1);
            }
            Length -= quantity;
        }
        public void RemoveByIndex(int index)
        {
            if (index < 0 || index > Length)
            {
                throw new Exception();
            }
            if (Length < _TrueLength / 2)
            {
                ReduceSize(1);
            }
            Length--;
            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
        }
        public void RemoveByIndex(int index, int quantity)
        {
            if (index < 0 || index > Length || quantity <= 0)
            {
                throw new Exception();
            }
            while (quantity != 0)
            {
                RemoveByIndex(index);
                quantity--;
            }
        }
        public void RemoveByValueFirst(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    RemoveByIndex(i);
                    break;
                }
            }
        }
        public void RemoveByValueAll(int value)
        {
            int index;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    RemoveByIndex(i);
                }
            }
        }
        public int FindMax()
        {
            int max = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }
        public int FindMin()
        {
            int min = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }
        public int FindIndexMax()
        {
            int max = _array[0];
            int index = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                    index = i;
                }
            }
            return index;
        }
        public void Reverse()
        {
            for (int i = 0, j = Length - 1; i < j; i++, j--)
            {
                int temp = _array[i];
                _array[i] = _array[j];
                _array[j] = temp;
            }
        }
        public void SortIncrease()
        {
            for (int i = 0; i < Length; i++)
            {
                int min = i;
                for (int j = i; j < Length; j++)
                {
                    if (_array[j] < _array[min])
                    {
                        min = j;
                    }
                }
                int tmp = _array[i];
                _array[i] = _array[min];
                _array[min] = tmp;
            }
        }
        public void SortDecrease()
        {
            for (int i = 1; i < _array.Length; i++)
            {
                for (int j = i; j > 0 && _array[j - 1] < _array[j]; j--)
                {
                    int temp = _array[j - 1];
                    _array[j - 1] = _array[j];
                    _array[j] = temp;
                }
            }
        }
        public int FindIndexMin()
        {
            int min = _array[0];
            int index = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                    index = i;
                }
            }
            return index;
        }
        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            if (Length != arrayList.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    if (_array[i] != arrayList._array[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void IncreaseLenght(int number = 1)
        {
            int newLength = _TrueLength;
            while (newLength <= _TrueLength + number)
            {
                newLength = (int)(newLength * 1.33 + number);
            }
            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, _TrueLength);
            _array = newArray;
        }
        private void ReduceSize(int size)
        {
            int newLength = _TrueLength;
            if (newLength == 0)
            {
                return;
            }
            while (newLength > _TrueLength - size)
            {
                newLength = (int)(newLength * 0.66);
            }
            if (newLength > 0)
            {
                int[] newArray = new int[newLength];
                Array.Copy(_array, newArray, newLength);

                _array = newArray;
            }

        }
    }
}