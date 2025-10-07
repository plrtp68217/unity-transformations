using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Transform _targetTransform;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        _targetTransform.Rotate(_rotationSpeed * Time.deltaTime * Vector3.up);
    }
}
