using System.Collections;
using UnityEngine;

public class spawnmur : MonoBehaviour
{
    [SerializeField] GameObject mur1, mur2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(mur1,gameObject.transform.position,Quaternion.identity);
            yield return new WaitForSeconds(2);
            Instantiate(mur2, gameObject.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
