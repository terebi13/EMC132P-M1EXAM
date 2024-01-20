using System.Collections;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject EnemySpawn;
    
    private void OnTriggerEnter()
    {
        EnemySpawn.SetActive(true);
    }
}
