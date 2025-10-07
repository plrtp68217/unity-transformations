using Unity.VisualScripting;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private Transform _targetTransform;

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        _targetTransform.localScale += _scaleSpeed * Time.deltaTime * Vector3.one;
    }
}
