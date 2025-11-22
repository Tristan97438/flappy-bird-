using System.Collections;
using UnityEngine;

public class spawnmur : MonoBehaviour
{
    [SerializeField] GameObject mur1, mur2;
    [SerializeField] GameObject canva_game_over;
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
            if(!canva_game_over.activeSelf && GameObject.FindWithTag("bird").GetComponent<mortbird>().mort_b == false)
            {
                Instantiate(mur1, gameObject.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(2);
                
            }
            if (!canva_game_over.activeSelf && GameObject.FindWithTag("bird").GetComponent<mortbird>().mort_b == false)
            {
                
                Instantiate(mur2, gameObject.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(2);
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
            
        }
    }
}
