using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _worldDirection; 

    private void Update()
    {
        Vector3 direction = _worldDirection ? Vector3.forward : transform.forward;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, _speed * Time.deltaTime);        
    }
}