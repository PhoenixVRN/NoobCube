using UnityEngine;
using UnityEngine.UI;

public class InputField : MonoBehaviour
{
    [SerializeField] private Text _timeSpawnCube;
    [SerializeField] private Text _speedCube;
    [SerializeField] private Text _distanceCube;
    [SerializeField] private Text _textSpawnCube;
    [SerializeField] private Text _textSpeedCube;
    [SerializeField] private Text _textDistanceCube;
    [SerializeField] private GameObject cube;

    [HideInInspector] public int a;
    [HideInInspector] public int b;
    [HideInInspector] public int c;

    private float _timer;
    
    void Update()
    {
        _timer -= Time.deltaTime;
        
        if (a != 0 && b != 0 && c != 0 && _timer < 0)
        {
            Instantiate(cube, cube.transform.position, Quaternion.identity);
            _timer = a;
        }
    }
    
    // проверяем на корректность вввода.
    public void SetDTO()
    {
        int.TryParse(_timeSpawnCube.text, out a);
        _textSpawnCube.text = a.ToString();
        
        int.TryParse(_speedCube.text, out b);
        _textSpeedCube.text = b.ToString();
        
        int.TryParse(_distanceCube.text, out c);
        _textDistanceCube.text = c.ToString();

    }
}
