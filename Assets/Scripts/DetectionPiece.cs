using UnityEngine;

public class DetectionPiece : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Boule boule))
        {
            boule.AjoutePiece();
            Destroy(gameObject);
        }
    }
}
