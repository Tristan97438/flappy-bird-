using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class mortbird : MonoBehaviour
{
    [SerializeField] AudioSource monde;
    private Transform rectTransform;
    private Vector3 taille_normale;
    private Vector3 changement_scale;
    public float grossisement = 2f;
    public float duree_zoom = 0.5f;
    [SerializeField] UnityEvent mort_bird;
    [SerializeField] GameObject canva;
    public bool mort_b;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mort_b = false;
        rectTransform = GetComponent<Transform>();
        taille_normale = rectTransform.localScale;
        canva.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y <= -5)
        {
            StartCoroutine(mort());
            
        }
    }
    public void restart()
    {
        monde.Play();
        canva.SetActive(false);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (mort_b == false)
        StartCoroutine(mort());
        
    }
    IEnumerator mort()
    {
        monde.Stop();
        mort_b = true;
        mort_bird.Invoke();
        while(transform.localScale.x < 1.5f)
        {
            changement_scale.x = transform.localScale.x +0.1f;
            changement_scale.y = transform.localScale.x+0.1f;
            transform.localScale = changement_scale;
            yield return new WaitForSeconds(0.1f);
        }
        canva.SetActive(true);
        transform.localScale = taille_normale;
        mort_b = false;
    }
}
