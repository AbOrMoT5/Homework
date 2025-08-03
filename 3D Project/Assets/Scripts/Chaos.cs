using UnityEngine;

public class Chaos : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotateSpeedY;
    [SerializeField] private float _scaleSpeed;

    void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
        transform.Rotate(0, _rotateSpeedY, 0);
        transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed);
    }
}
