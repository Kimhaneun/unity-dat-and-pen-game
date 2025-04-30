using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("PLAYR"))
        {
            ScoreManagerment.Instance.UpdatScor();
        }
    }
}
