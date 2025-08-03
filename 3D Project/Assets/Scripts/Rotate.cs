using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotateY;

    void Update()
    {
        transform.Rotate(0, _rotateY, 0);
    }
}
