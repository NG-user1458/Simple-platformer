using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform CheckPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            collision.gameObject.transform.position = CheckPoint.position;
        }
    }
}
