using System;

namespace LinnworksAPI
{
    public abstract class LinnObject
    {
        //public override bool Equals(object obj)
        //{
        //    return PropertiesEqual(this, obj);
        //}
        
        private static bool PropertiesEqual<T>(T self, T to)
        {
            if (self != null && to != null)
            {
                Type type = self.GetType();
                Type toType = to.GetType();

                if (type != toType)
                    return false;

                foreach (System.Reflection.PropertyInfo pi in type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
                {
                    object selfValue = type.GetProperty(pi.Name).GetValue(self, null);
                    object toValue = type.GetProperty(pi.Name).GetValue(to, null);

                    if (selfValue != toValue && (selfValue == null || !selfValue.Equals(toValue)))
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }
    }
}