using UnityEngine;

public class MobileCubeController : MonoBehaviour
{
    //[SerializeField] private LayerMask layerMask;

    private Rigidbody rb;
    private float speed = Data.MobileCubeSpeed;
    
    /// <summary>
    /// Направление координат трансформа игрока.
    /// </summary>
    private Vector3 direction;
    private float deltaTime;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        deltaTime = Time.deltaTime;
    }

    void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// Логика движения. Получение вектора направления, поворот, импульс твердому телу. 
    /// </summary>
    private void Move()
    {
        GetDirection();
        gameObject.transform.LookAt(direction);
        rb.AddForce(gameObject.transform.forward * deltaTime * speed, ForceMode.Impulse);
    }

    private void GetDirection()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        direction = player.transform.position;
    }

    /// <summary>
    /// Метод проверяет, есть ли в заданном радиусе объект, у которого Layer == Character (задано через редактор).
    /// Дальше какая-то логика...
    /// </summary>
    //private void Overlap()
    //{
    //    byte radius = 5;
    //    Collider[] colliders = Physics.OverlapSphere(transform.position, radius, layerMask);

    //    if (colliders.Length > 0) //так как слой Character содержит только один объект, то он единственный может попасть в массив.
    //    {
    //        Debug.Log(colliders[0].name);
    //    }
    //}
}
