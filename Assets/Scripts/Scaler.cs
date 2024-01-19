using UnityEngine;

public class Scaler : MonoBehaviour
{
    [Range(0.01f, 1f)]
    [SerializeField] private float _speedScale;
    [SerializeField] private Vector3 _targetSize;

    private void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, _targetSize, _speedScale * Time.deltaTime);       
    }
}
