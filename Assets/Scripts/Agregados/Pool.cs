using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public static Pool PoolInstance { get; set; }
    public GameObject RefObject { get => refObject; set => refObject = value; }

    List<GameObject> poolList = new List<GameObject>();
    private GameObject refObject;
    [SerializeField] int cantidad;

    void Awake()
    {
        if (PoolInstance == null)
        {
            PoolInstance = this;
        }
        else
        {
            Destroy(this);
        }
    }

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

    public GameObject LaGarra(GameObject grab)
    {
        if (poolList.Count > 0)
        {
            for (int i = 0; i < poolList.Count; i++)
            {
                if (poolList[i].GetComponent<AICharacter>().MyType == grab.GetComponent<AICharacter>().MyType && !poolList[i].activeInHierarchy)
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
