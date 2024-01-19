using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speedMove;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.forward, _speedMove * Time.deltaTime);        
    }
}