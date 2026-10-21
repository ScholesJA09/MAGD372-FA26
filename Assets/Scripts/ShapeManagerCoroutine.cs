using System.Collections;
using UnityEngine;

public class ShapeManagerCoroutine : MonoBehaviour
{
    [SerializeField] private Coroutine[] _shapes;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //User Input with Spacebar
        {
            BeginTest();
        }
    }

    public void BeginTest()
    {
        for (var i = 0; i < _shapes.Length; i++)
        {
            StartCoroutine(_shapes[i].RotateForSeconds(1 + 1 * i));

            Color col = new Color(Random.value, Random.value, Random.value);
            _shapes[i].GetComponent<Renderer>().material.color = col;

            Debug.Log($"Coroutine action {i} completed.");
        }
    }

    IEnumerator Action1()
    {
        yield return new WaitForSeconds(1);
    }

    IEnumerator Action2()
    {
        yield return new WaitForSeconds(1);
    }

    IEnumerator Action3()
    {
        yield return new WaitForSeconds(1);
    }

    IEnumerator SequentialCoroutines()
    {
        yield return StartCoroutine(Action1());
        yield return StartCoroutine(Action2());
        yield return StartCoroutine(Action3());
    }
}