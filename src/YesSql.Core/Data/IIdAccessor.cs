﻿using System;

namespace YesSql.Core.Data {
    public interface IIdAccessor<T>
    {
        T Get(object obj);
        void Set(object obj, T value);
    }

    public class IdAccessor<T, TU> : IIdAccessor<TU>
    {
        private readonly Func<T, TU> _getter;
        private readonly Action<T, TU> _setter;

        public IdAccessor(Func<T, TU> getter, Action<T, TU> setter)
        {
            _getter = getter;
            _setter = setter;
        }

        TU IIdAccessor<TU>.Get(object obj)
        {
            return _getter((T)obj);
        }

        void IIdAccessor<TU>.Set(object obj, TU value)
        {
            _setter((T)obj, value);
        }
    }
}
