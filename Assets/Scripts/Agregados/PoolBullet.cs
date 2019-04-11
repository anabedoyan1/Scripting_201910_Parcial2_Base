using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBullet : MonoBehaviour
{
    List<GameObject> poolList = new List<GameObject>();
    [SerializeField] private GameObject refObject;
    [SerializeField] int cantidad;
    // Start is called before the first frame update
    public void CreatePool()
    {
        for (int i = 0; i < cantidad; i++)
        {
            CreateObjectForPool();
        }
    }

    public void CreateObjectForPool()
    {
        GameObject objectPool = Instantiate(refObject);
        poolList.Add(objectPool);
        objectPool.SetActive(false);
    }

    public GameObject LaGarra()
    {
        if (poolList.Count > 0)
        {
            for (int i = 0; i < poolList.Count; i++)
            {
                if (!poolList[i].activeInHierarchy)
                {
                    GameObject objectDeLaGarra = poolList[i];
                    poolList.Remove(poolList[i]);
                    objectDeLaGarra.SetActive(true);
                    return objectDeLaGarra;
                }
            }
        }
        else
        {
            CreateObjectForPool();
            GameObject objectDeLaGarra = poolList[0];
            poolList.Remove(poolList[0]);
            objectDeLaGarra.SetActive(true);
            return objectDeLaGarra;
        }
        return null;
    }

    public void ReturnGameObjectToPool(GameObject _gamObjectForReturn)
    {
        poolList.Add(_gamObjectForReturn);
        _gamObjectForReturn.SetActive(false);
    }
}
