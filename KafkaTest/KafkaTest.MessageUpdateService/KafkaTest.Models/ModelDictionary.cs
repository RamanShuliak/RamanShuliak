using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.Models
{
    public class ModelDictionary
    {
        public Dictionary<string, Type> modelDictionary;

        public ModelDictionary()
        {
            modelDictionary = new Dictionary<string, Type>();

            var modelTypes = Assembly.GetExecutingAssembly().DefinedTypes
                .Where(type => type.IsClass &&
                type.CustomAttributes.Any(attr => attr.AttributeType == typeof(ModelNameAttribute)));

            foreach (var modelType in modelTypes)
            {
                var modelNameAttribute = modelType.GetCustomAttribute<ModelNameAttribute>();
                if (modelNameAttribute != null)
                {
                    string modelName = modelNameAttribute.Name;
                    modelDictionary[modelName] = modelType;
                }
            }
        }

        public void AddModel(string modelName, Type modelType)
        {
            modelDictionary[modelName] = modelType;
        }

        public Type GetModelType(string modelName)
        {
            return modelDictionary[modelName];
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class ModelNameAttribute : Attribute
    {
        public string Name { get; }

        public ModelNameAttribute(string name)
        {
            Name = name;
        }
    }
}
