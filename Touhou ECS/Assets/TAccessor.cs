using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TAccessor<T>
{
    private static TAccessor<T> _singleton;
    private List<T> _list = new List<T>();

    public static TAccessor<T> Instance()
    {
        return _singleton ??= new TAccessor<T>();
    }

    public List<T> GetAllModules()
    {
        return _list;
    }

    public T TryGetModule(GameObject entity)
    {
        foreach (var mod in _list.Select(module => entity.GetComponent<T>()).Where(mod => mod != null))
        {
            return mod;
        }

        return null;
    }

    public void Add(T module)
    {
        _list.Add(module);
    }

    public void Remove(T module)
    {
        _list.Remove(module);
    }
}
