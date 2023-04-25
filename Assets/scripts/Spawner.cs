using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public birdmove birdScript;
    public GameObject borular;

    private void Start()
    {

        StartCoroutine(SpawnObject());
    }

    public IEnumerator SpawnObject()
    {
        while (!birdScript.isdead)
        {

            Instantiate(borular, new Vector3(2, Random.Range(-0.45f, 0.38f), 0), Quaternion.identity);


            yield return new WaitForSeconds(2.2f);
        }

    }
}
