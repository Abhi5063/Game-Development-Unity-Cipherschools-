using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            ScoreManager.instance.AddScore(1);
            Invoke("DestroyCollectables", 0.2f);
        }
    }
    void DestroyCollectables()
    {
        Destroy(this.gameObject);
    }
}