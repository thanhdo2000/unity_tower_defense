using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Pool")]
    public SpawnPool characterPool;
    public SpawnPool gameEffectPool;
    public SpawnPool mapPool;
    public SpawnPool itemPool;
    private void Start()
    {
        if (Instance == null) Instance = this;
        LoadPool();
    }

    private void LoadPool()
    {
        if (!PoolManagerMy.Pools.ContainsKey(GameConstant.CHARACTER_POOL))
            characterPool = PoolManagerMy.Pools.Create(GameConstant.CHARACTER_POOL);
        if (!PoolManagerMy.Pools.ContainsKey(GameConstant.GAMEEFFECT_POOL))
            gameEffectPool = PoolManagerMy.Pools.Create(GameConstant.GAMEEFFECT_POOL);
        if (!PoolManagerMy.Pools.ContainsKey(GameConstant.MAP_POOL))
            mapPool = PoolManagerMy.Pools.Create(GameConstant.MAP_POOL);
        if (!PoolManagerMy.Pools.ContainsKey(GameConstant.ITEM_POOL))
            itemPool = PoolManagerMy.Pools.Create(GameConstant.ITEM_POOL);
    }
}
