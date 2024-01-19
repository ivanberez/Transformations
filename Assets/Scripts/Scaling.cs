using UnityEngine;

public class Scaling : MonoBehaviour
{
    [Range(0.01f, 0.2f)]
    [SerializeField] private float _speedScale;
    [SerializeField] private Vector3 _targetSize = Vector3.one;

    private void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, _targetSize, _speedScale * Time.deltaTime);       
    }
}
