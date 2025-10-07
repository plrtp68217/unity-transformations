using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private Transform _targetTransform;

    private void Update()
    {
        Moveforward();
    }

    private void Moveforward()
    {
        _targetTransform.Translate(_movementSpeed * Time.deltaTime * Vector3.forward);
    }
}