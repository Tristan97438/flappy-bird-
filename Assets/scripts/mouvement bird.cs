using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class mouvementbird : MonoBehaviour
{
    float y;
    [SerializeField] GameObject explosion_obj;
    [SerializeField]UnityEvent effet_saut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        explosion_obj.SetActive(false);
        StartCoroutine(mouv());
    }

    // Update is called once per frame
    void Update()
    {
        
        y = gameObject.transform.position.y;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            effet_saut.Invoke();
            y += 1f;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, y, gameObject.transform.position.z);
            StartCoroutine(explosion());
        }


    }
    IEnumerator mouv()
    {
        while (true) 
        {
            y = gameObject.transform.position.y;
            
            
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, y -= 0.1f, gameObject.transform.position.z);
            yield return new WaitForSeconds(0.1f);
           
           

        }

       
        
    }
    IEnumerator explosion()
    {
        explosion_obj.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        explosion_obj.SetActive(false);
    }
}
