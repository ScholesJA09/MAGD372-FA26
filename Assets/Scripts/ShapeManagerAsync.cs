using UnityEngine;

public class ShapeManagerAsync : MonoBehaviour
{
    [SerializeField] private Async[] _shapes;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //User Input with Spacebar
        {
            BeginTest();
        }
    }

    public async void BeginTest()
    {
        for (var i = 0; i < _shapes.Length; i++)
        {
            await _shapes[i].RotateForSeconds(1 + 1 * i);

            Color col = new Color(Random.value, Random.value, Random.value);
            _shapes[i].GetComponent<Renderer>().material.color = col;

            Debug.Log($"Async action {i} completed.");
        }
    }
}