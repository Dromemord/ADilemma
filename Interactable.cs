using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;

    bool isFocus = false;
    bool hasInteracted = false;
    Transform player;
    Compteur compteur;

    void Awake()
    {
        compteur = GameObject.FindWithTag("Compteur").GetComponent<Compteur>();
    }

    public virtual void Interact()
    {
        Destroy(transform.gameObject);
        compteur.Increment();
    }

    void Update()
    {
        if(isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if(distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    public void OnFocused(Transform playerTransform)
    {
        float distance = Vector3.Distance(playerTransform.position, transform.position);
        if (distance <= radius)
        {
            isFocus = true;
            player = playerTransform;
            hasInteracted = false;
        }

    }

    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
