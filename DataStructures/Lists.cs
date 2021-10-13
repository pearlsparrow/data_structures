using System;

namespace CMN5201.DataStructures {

    public interface IList<T> {

        void Append(T item);

        // void Prepend(T item);

        void Insert(T item, int index);

        T Delete(int index);

        T Get(int index);

        int Count();

        // bool Contains(T item);

        // IIterator<T> Iterator();
    }

    public interface IIterator<T> {
        bool HasNext();
        T GetNext();
    }

    public class ArrayList<T> : IList<T> {

        private static int DEFAULT_INITIAL_CAPACITY = 100;
        private static int DEFAULT_EXPAND_VALUE = 100;

        int Initial_Capacity;
        int initial_Expand_Value;

        private int count = 0;

        // declare and initialize the backing array...

        private T[] items;


        public ArrayList()
        {
            items = new T[DEFAULT_INITIAL_CAPACITY];
        }
        public ArrayList(int Initial_Capacity, int initial_Expand_Value)
        {
            this.Initial_Capacity = Initial_Capacity;
            this.initial_Expand_Value = initial_Expand_Value;
            items = new T[Initial_Capacity];
        }


        /**
         * 
         */
        public void Append(T item) {
            
            // TODO: check if capacity is enough...

            items[count] = item;

            count++;
        }

        void Insert(T item, int index) {
            // TODO: check index...
            // TODO: check capacity...

            ShiftTowardsEndIfNeeded(index);

            items[index] = item;
        }

        /**
         * 
         */
        public int Count() {
            return count;
        }

        /**
         * TODO
         * 
         */
        public T Get(int index) {

            if (index < 0 || index > count - 1) {
                // throw new ArgumentException();
                throw new IndexOutOfBoundsException();
            }

            return items[index];
        }
    
        protected void ShiftTowardsEndIfNeeded(int index) {
            int i = count - 1;
            while (i >= index) {
                items[i + 1] = items[i];
                i--;
            }
        }

        protected void ShiftTowardsFrontIfNeeded(int index)
        {
            int i = index;
            while(i <= count - 2)
            {

            }
        }
        
    }

    public class ListException : Exception {

    }

    public class IndexOutOfBoundsException : ListException {

    }
}
