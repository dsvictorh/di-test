using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.XPath;

namespace UI
{
    class DependencyInjector
    {
        private List<KeyValuePair<Type, Type>> _dependencies;

        public DependencyInjector() 
        {
            this._dependencies = new List<KeyValuePair<Type, Type>>();
        }

        public void Register<I, C>() where C : I
        {
            var dependency = this._dependencies.FirstOrDefault((i) => i.Key.Equals(typeof(I)));
            if (!dependency.Equals(default(KeyValuePair<Type, Type>)))
            {
                throw new Exception("Dependency of type " + typeof(I).Name + " is already registered");
            }

            this._dependencies.Add(new KeyValuePair<Type, Type>(typeof(I), typeof(C)));
        }

        private object Resolve<I>()
        {
            var pair = this._dependencies.FirstOrDefault((i) => i.Key.Equals(typeof(I)));
            if (pair.Equals(default(KeyValuePair<Type, Type>)))
            {
                throw new Exception("Dependency is not registered");
            }

            return this.GetType().GetMethod("Instantiate")
                        .MakeGenericMethod(pair.Value)
                        .Invoke(this, null);
        }

        public C Instantiate<C>() where C : class
        {
            Type t = typeof(C);
            var constructor = t.GetConstructors()[0];
            var parameters = constructor.GetParameters();
            var arguments = new object[constructor.GetParameters().Length];

            for(var i = 0; i < parameters.Length; i++) 
            {
                var type = this.GetType();
                arguments[i] = type
                        .GetMethod("Resolve", BindingFlags.Instance | BindingFlags.NonPublic)
                        .MakeGenericMethod(parameters[i].ParameterType)
                        .Invoke(this, null);
            }

            return (C)Activator.CreateInstance(typeof(C), arguments);
        }
    }
}
