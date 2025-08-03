using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _scale;

    void Update()
    {
        transform.localScale += new Vector3(_scale, _scale, _scale);
    }
}
