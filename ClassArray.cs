using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
    {
        private Dictionary<int, T> places;

        private int maxCount;
        private T defaultValue;
        private int currentIndex;

        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() < other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < this.places.Count; ++i)
                {
                    if (this.places[thisKeys[i]] is Locomotive &&
                        other.places[otherKeys[i]] is CartLocomotive)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is CartLocomotive &&
                        other.places[thisKeys[i]] is Locomotive)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is Locomotive &&
                        other.places[thisKeys[i]] is Locomotive)
                    {
                        return (this.places[thisKeys[i]] is Locomotive)
                            .CompareTo(other.places[thisKeys[i]] is Locomotive);
                    }
                    if (this.places[thisKeys[i]] is CartLocomotive &&
                        other.places[thisKeys[i]] is CartLocomotive)
                    {
                        return (this.places[thisKeys[i]] is CartLocomotive)
                            .CompareTo(other.places[thisKeys[i]] is CartLocomotive);
                    }
                }
            }
            return 0;
        }
        public ClassArray(int sizes, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = sizes;
        }


        public static int operator +(ClassArray<T> p, T locomotive)
        {
            var isCartLocomotive = locomotive is CartLocomotive;
            if (p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (locomotive.GetType() == p.places[i].GetType())
                {
                    if (isCartLocomotive)
                    {
                        if ((locomotive as CartLocomotive).Equals(p.places[i]))
                        {
                            throw new ParkingAlreadyHaveException();
                        }
                    }
                    else if ((locomotive as Locomotive).Equals(p.places[i]))
                    {
                        throw new ParkingAlreadyHaveException();
                    }
                }
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, locomotive);
                return index;
            }
            p.places.Add(p.places.Count, locomotive);
            return p.places.Count - 1;

        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T locomotive = p.places[index];
                p.places.Remove(index);
                return locomotive;
            }
            throw new ParkingIndexOutOfRangeException();
        }

        private bool CheckFreePlace(int index)
        {

            return !places.ContainsKey(index);
        }

        public T this[int ind]
        {
            get
            {

                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }
    }
}
