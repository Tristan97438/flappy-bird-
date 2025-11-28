using System.Collections;
using UnityEngine;

public class spaw_bomb : MonoBehaviour
{
    [SerializeField] GameObject bomb_1, bomb_2,bomb_3;
    GameObject bomb_actuelle;
    [SerializeField] GameObject canva_game_over;
    float x;
    int rand;
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
            rand = Random.Range(0, 3);
            if (rand == 0)bomb_actuelle = bomb_1;
            if (rand == 1) bomb_actuelle = bomb_2;
            if (rand == 2) bomb_actuelle = bomb_3;

            if (!canva_game_over.activeSelf && GameObject.FindWithTag("bird").GetComponent<mortbird>().mort_b == false)
            {
                x = Random.Range(-11, 11);
                Instantiate(bomb_actuelle, new Vector3(x, transform.position.y, transform.position.z), Quaternion.Euler(180,0,0));
                yield return new WaitForSeconds(1);
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
            
        }
        
    }
}
