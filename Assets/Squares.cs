using UnityEngine;

public class Squares : MonoBehaviour
{
    [SerializeField] private GameObject SquarePrefab = default;

    public void ButtonClicked()
    {
        Vector2 position = new Vector2(Screen.width * Random.Range(-0.5f, 0.5f), Screen.height * Random.Range(-0.5f, 0.5f));
        GameObject square = Instantiate(SquarePrefab, this.transform);
        square.transform.position = position;
    }
}
