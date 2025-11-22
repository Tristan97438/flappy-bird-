
using UnityEngine;
using UnityEngine.EventSystems;

public class script_bouton_anim_pause : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    private RectTransform rectTransform;
    private Vector3 tailleNormale;
    public float grossisement = 1.2f;
    public float duree_zoom = 0.2f;
  
  

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        tailleNormale = rectTransform.localScale;





    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Zoom au survol
        LeanTween.scale(rectTransform, tailleNormale * grossisement, duree_zoom)
                 .setEaseOutQuad();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Retour à la taille normale
        LeanTween.scale(rectTransform, tailleNormale, duree_zoom)
                 .setEaseOutQuad();
    }
}