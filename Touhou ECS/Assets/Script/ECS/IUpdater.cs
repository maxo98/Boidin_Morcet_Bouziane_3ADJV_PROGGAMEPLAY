using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IUpdater : MonoBehaviour
{
    private readonly Dictionary<string, TAccessor<TModule>> _dictionary = new Dictionary<string, TAccessor<TModule>>();
    private static IUpdater _singleton; 

    public static IUpdater Instance()
    {
        return _singleton;
    }

    private void Awake()
    {
        _singleton = this;
    }

    public void SystemUpdate(IEnumerable<TModule> moduleList)
    {
        foreach (var module in moduleList)
        {
            if (!_dictionary.ContainsKey(module.GetType().Name))
            {
                _dictionary.Add(module.GetType().Name, new TAccessor<TModule>());
            }
            _dictionary[module.GetType().Name].Add(module);
        }
    }
}
