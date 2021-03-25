using UnityEngine;
using Realms;

[RequireComponent(typeof(SpriteRenderer))]
public class Square : MonoBehaviour
{
    private Realm realm;
    private SquareEntity squareEntity;

    private void Start()
    {
        realm = Realm.GetInstance();
        squareEntity = realm.Find<SquareEntity>("1");
        if (squareEntity == null)
        {
            squareEntity = new SquareEntity("1");
            realm.Write(() =>
            {
                realm.Add(squareEntity);
            });
        }
        SetColor();
    }

    private void OnMouseDown()
    {
        realm.Write(() =>
        {
            squareEntity.Red = Random.Range(0f, 1f);
            squareEntity.Green = Random.Range(0f, 1f);
            squareEntity.Blue = Random.Range(0f, 1f);
        });
        SetColor();
    }

    private void SetColor()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(squareEntity.Red, squareEntity.Green, squareEntity.Blue);
    }
}
