
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;


public static class PoolUtils
{
    public static T Spawn<T>(Transform transform, Vector3 position, Quaternion rotation, string POOL_KEY = "Pools") where T : Component
    {
        Transform trans = PoolManagerMy.Pools[POOL_KEY].Spawn(transform, position, rotation);
        T component = trans.GetComponent<T>();
        return component;
    }

    public static T Spawn<T>(string prefapName, Vector3 position, Quaternion rotation, string POOL_KEY = "Pools") where T : Component
    {
        Transform trans = PoolManagerMy.Pools[POOL_KEY].Spawn(prefapName, position, rotation);
        T component = trans.GetComponent<T>();
        return component;
    }

    public static Transform Spawn(string prefapName, Vector3 position, Quaternion rotation, string POOL_KEY = "Pools")
    {
        Transform trans = PoolManagerMy.Pools[POOL_KEY].Spawn(prefapName, position, rotation);
        return trans;
    }

    public static Transform Spawn(Transform transform, Vector3 position, Quaternion rotation, string POOL_KEY = "Pools")
    {
        Transform trans = PoolManagerMy.Pools[POOL_KEY].Spawn(transform, position, rotation);
        return trans;
    }

    public static void Despawn(Transform transform, bool resetParent = false, string POOL_KEY = "Pools")
    {
        if (transform.gameObject.activeSelf)
        {
            if (resetParent)
                transform.parent = PoolManagerMy.Pools[POOL_KEY].transform;
            PoolManagerMy.Pools[POOL_KEY].Despawn(transform);
        }
    }

    public static void Despawn(Transform transform, float time, string POOL_KEY = "Pools")
    {
        if (transform.gameObject.activeSelf)
        {
            PoolManagerMy.Pools[POOL_KEY].Despawn(transform, time);
        }
    }

	public static void AddToPool(PrefabPool prefabPool, string POOL_KEY = "Pools")
	{
        PoolManagerMy.Pools[POOL_KEY].CreatePrefabPool(prefabPool);
	}

    public static void AddToPoolSafe(PrefabPool prefabPool, string POOL_KEY = "Pools")
    {
        if (PoolManagerMy.Pools.ContainsKey(POOL_KEY))
        {
            AddToPool(prefabPool);
        }
        else
        {
            // wait till pool is available
            PoolManagerMy.Pools.AddOnCreatedDelegate(POOL_KEY, (p) => 
            {
                AddToPool(prefabPool);
            });
        }
    }
}

