using System.Collections.Generic;
using System.Text;
using System;
using System.Collections;

namespace LinnworksAPI
{
    public class ConfigRuleCollection : ICollection<ConfigRule>
    {
        private Dictionary<string, ConfigRule> rules = new Dictionary<string, ConfigRule>();

        public ConfigRule this[string propertyName]
        {
            get { return rules[propertyName]; }
        }

        public List<ConfigRule> Items { get { return new List<ConfigRule>(rules.Values); } }

        public int Count => rules.Count;

        public bool IsReadOnly => false;

        public void Add(ConfigRule rule)
        {
            rules.Add(rule.FieldName, rule);
        }

        public ConfigRuleCollection AddRange(IEnumerable<ConfigRule> ruleItems)
        {
            foreach (ConfigRule rule in ruleItems)
                Add(rule);

            return this;
        }

        public void Clear()
        {
            rules.Clear();
        }

        public bool Contains(ConfigRule item)
        {
            return rules.ContainsValue(item);
        }

        public void CopyTo(ConfigRule[] array, int arrayIndex)
        {
            rules.Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<ConfigRule> GetEnumerator()
        {
            return rules.Values.GetEnumerator();
        }

        public bool Remove(ConfigRule item)
        {
            return rules.Remove(item.FieldName);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static implicit operator List<ConfigRule>(ConfigRuleCollection rules)
        {
            return rules.Items;
        }
    }
}