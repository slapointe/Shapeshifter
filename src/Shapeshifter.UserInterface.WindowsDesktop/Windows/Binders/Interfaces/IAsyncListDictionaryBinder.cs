﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Shapeshifter.UserInterface.WindowsDesktop.Windows.Interfaces
{
    public interface IAsyncListDictionaryBinder<TKey, TData> where TKey : class
    {
        void Bind(
            ObservableCollection<TKey> sourceCollection, 
            ObservableCollection<TData> destinationCollection,
            Func<TKey, Task<IEnumerable<TData>>> mappingFunction);

        void LoadFromKey(TKey key);
    }
}
