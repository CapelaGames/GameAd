using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minions : MonoBehaviour
{
    public GameObject minionPrefab;

    [SerializeField]
    List<GameObject> _minions;

    float lastSpawn = -5000
    float coolDown = 3;

    Start()
    {
        _minions = new List<GameObject>();
        SpawnMinion();
    }

    private void OnTriggerEnter(Collider other)
    {
        Gate gate = other.GetComponent<Gate>();

        if (gate != null)
        {
            if (lastSpawn + coolDown > Time.time) return;
            lastSpawn = Time.time;
            int spawnCount = gate.add != 0 ? gate.add : (_minions.Count * gate.multiply) - _minions.Count;
            Debug.Log(_minions.Count + " " + gate.multiply + " " + spawnCount)
            for (int x = 0; x < spawnCount; x++)
            {
                SpawnMinion();
            }
        }
    }

    private void SpawnMinion()
    {
        Vector3 randomOffset = new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        GameObject minion = Instantiate<GameObject>(minionPrefab, transform.position + randomOffset, Quaternion.identity);
        MoveToObject moveToObject = minion.GetComponent<MoveToObject>();
        moveToObject.target = transform;
        _minions.Add(minion);
    }

    public void RemoveMinion(GameObject go)
    {
        _minions.Remove(go);
    }
}
