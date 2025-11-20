using System.Collections;
using UnityEngine;

public class mouvementmur : MonoBehaviour
{
    mortbird mortbird;
    float x;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(deplacement());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator deplacement()
    {
        while (true)
        {
            
            
                x = transform.position.x;
                gameObject.transform.position = new Vector3(x - 0.05f, transform.position.y, transform.position.z);
            
            
            yield return new WaitForSeconds(0.01f);
        }
    }
}
