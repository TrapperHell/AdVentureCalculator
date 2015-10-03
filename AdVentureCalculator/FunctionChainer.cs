using System;
using System.Collections.Generic;
using System.Linq;

namespace AdVentureCalculator
{
    public class FunctionChainer<T>
    {
        T baseValue;

        /// <summary>
        /// Gets the base value originally supplied to the function chainer.
        /// </summary>
        public T BaseValue
        {
            get { return baseValue; }
        }

        public T Value
        {
            get
            {
                T value = BaseValue;

                foreach (Func<T, T> fn in functions.Values)
                {
                    value = fn(value);
                }

                return value;
            }
        }

        public void Add(string uniqueName, Func<T, T> fn)
        {
            lock (functions)
            {
                if (!functions.ContainsKey(uniqueName))
                    functions.Add(uniqueName, fn);
                else
                    functions[uniqueName] = fn;
            }
        }

        public void AddRange(Dictionary<string, Func<T, T>> fns)
        {
            lock (functions)
            {
                functions = functions.Concat(fns).ToDictionary(x => x.Key, x => x.Value);
            }
        }

        public void Remove(string uniqueName)
        {
            functions.Remove(uniqueName);

            //functions[uniqueName] = (j) => j;
        }

        Dictionary<string, Func<T, T>> functions;



        public FunctionChainer(T baseValue)
            : this(baseValue, new Dictionary<string, Func<T, T>>())
        { }

        public FunctionChainer(T baseValue, string affectName, Func<T, T> function)
            : this(baseValue, new Dictionary<string, Func<T, T>>() { { affectName, function } })
        { }

        public FunctionChainer(T baseValue, Dictionary<string, Func<T, T>> functions)
        {
            this.baseValue = baseValue;
            this.functions = functions;
        }



        #region Class Operators

        public static implicit operator FunctionChainer<T>(T baseValue)
        {
            return new FunctionChainer<T>(baseValue);
        }

        public static implicit operator T(FunctionChainer<T> value)
        {
            if (value == null)
                return default(T);
            else
                return value.Value;
        }

        #endregion Class Operators

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}