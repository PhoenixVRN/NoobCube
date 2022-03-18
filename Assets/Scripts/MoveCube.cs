
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private InputField inputField;
    private Vector3 _startPos;
    private float _speedCube;
    private int _distance;

    void Start()
    {
        inputField = FindObjectOfType<InputField>();
        _startPos = transform.position;
        _speedCube = inputField.b;
        _distance = inputField.c;

    }
    
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime * _speedCube;
        if (Vector3.Distance(transform.position, _startPos) >= _distance) Destroy(gameObject);
    }
    
}
