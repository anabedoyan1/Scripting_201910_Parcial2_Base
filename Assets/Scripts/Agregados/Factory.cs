using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    Collider mCollider;
    [SerializeField] GameObject[] objectsfac;

    public void Start()
    {
        mCollider = GameObject.FindWithTag("Floor").GetComponent<Collider>();
        for (int i = 0; i < objectsfac.Length; i++)
        {
            Pool.PoolInstance.RefObject = objectsfac[i];
            Pool.PoolInstance.CreatePool();
        }
    }

    public Vector3 GetPointsInVolume()
    {
        Vector3 pointPosition = new Vector3((Random.Range(mCollider.bounds.min.x, mCollider.bounds.max.x)), mCollider.transform.position.y + 2,
        (Random.Range(mCollider.bounds.min.z, mCollider.bounds.max.z)));
        return pointPosition;
    }

    public GameObject BuildObject(EnemyType objectReq)
    {
        GameObject objectRequested = objectsfac[(int)objectReq];
        GameObject objectReturned;
        objectReturned = Pool.PoolInstance.LaGarra(objectRequested);
        ApplyRenderer(objectReturned);
        objectReturned.transform.position = GetPointsInVolume();
        return objectRequested;
    }

    private void ApplyRenderer(GameObject instance)
    {
        Renderer instaceRender = instance.GetComponent<Renderer>();        
        instaceRender.material.color = GetObjectColor(instance.GetComponent<AICharacter>().MyType);
    }

    private Color GetObjectColor(EnemyType enemyType)
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color color = new Color(r, g, b);
        return color;
    }
}
