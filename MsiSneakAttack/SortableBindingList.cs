using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Be.Timvw.Framework.ComponentModel
{
    public class SortableBindingList<T> : BindingList<T>
    {
        private readonly Dictionary<Type, PropertyComparer<T>> comparers;

        private bool isSorted;
        private ListSortDirection listSortDirection;
        private PropertyDescriptor propertyDescriptor;

        public SortableBindingList()
            : base(new List<T>())
        {
            comparers = new Dictionary<Type, PropertyComparer<T>>();
        }

        public SortableBindingList(IEnumerable<T> enumeration)
            : base(new List<T>(enumeration))
        {
            comparers = new Dictionary<Type, PropertyComparer<T>>();
        }

        protected override bool SupportsSortingCore => true;

        protected override bool IsSortedCore => isSorted;

        protected override PropertyDescriptor SortPropertyCore => propertyDescriptor;

        protected override ListSortDirection SortDirectionCore => listSortDirection;

        protected override bool SupportsSearchingCore => true;

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            List<T> itemsList = (List<T>)Items;

            Type propertyType = property.PropertyType;
            PropertyComparer<T> comparer;
            if (!comparers.TryGetValue(propertyType, out comparer))
            {
                comparer = new PropertyComparer<T>(property, direction);
                comparers.Add(propertyType, comparer);
            }

            comparer.SetPropertyAndDirection(property, direction);
            itemsList.Sort(comparer);

            propertyDescriptor = property;
            listSortDirection = direction;
            isSorted = true;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            isSorted = false;
            propertyDescriptor = base.SortPropertyCore;
            listSortDirection = base.SortDirectionCore;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override int FindCore(PropertyDescriptor property, object key)
        {
            int count = Count;
            for (int i = 0; i < count; ++i)
            {
                T element = this[i];
                if (property.GetValue(element).Equals(key))
                {
                    return i;
                }
            }

            return -1;
        }

        public class PropertyComparer<T> : IComparer<T>
        {
            private readonly IComparer comparer;
            private PropertyDescriptor propertyDescriptor;
            private int reverse;

            public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
            {
                this.propertyDescriptor = property;
                Type comparerForPropertyType = typeof(Comparer<>).MakeGenericType(property.PropertyType);
                this.comparer = (IComparer)comparerForPropertyType.InvokeMember("Default", BindingFlags.Static | BindingFlags.GetProperty | BindingFlags.Public, null, null, null);
                this.SetListSortDirection(direction);
            }

            #region IComparer<T> Members

            public int Compare(T x, T y)
            {
                return this.reverse * this.comparer.Compare(this.propertyDescriptor.GetValue(x), this.propertyDescriptor.GetValue(y));
            }

            #endregion

            private void SetPropertyDescriptor(PropertyDescriptor descriptor)
            {
                this.propertyDescriptor = descriptor;
            }

            private void SetListSortDirection(ListSortDirection direction)
            {
                this.reverse = direction == ListSortDirection.Ascending ? 1 : -1;
            }

            public void SetPropertyAndDirection(PropertyDescriptor descriptor, ListSortDirection direction)
            {
                this.SetPropertyDescriptor(descriptor);
                this.SetListSortDirection(direction);
            }
        }
    }
}