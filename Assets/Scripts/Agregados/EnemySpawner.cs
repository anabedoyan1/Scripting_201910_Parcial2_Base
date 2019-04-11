using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Factory factory;
    [SerializeField] AICharacter[] actor;
    private int amountEnemies = 2;

    private float timeToAsk = 5f;

    public void Start()
    {
        AskForObject();
    }

    public void SelectObjectWanted()
    {
        for (int i = 0; i < actor.Length; i++)
        {
            GameObject objectFabricated = factory.BuildObject(actor[i].MyType);
        }
    }

    public void AskForObject()
    {
        while(amountEnemies > 0)
        {
            SelectObjectWanted();
            amountEnemies--;
        }
    }
}
