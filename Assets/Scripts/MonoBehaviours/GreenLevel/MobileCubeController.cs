using UnityEngine;

public class MobileCubeController : MonoBehaviour
{
    //[SerializeField] private LayerMask layerMask;

    private Rigidbody rb;
    private float speed = Data.MobileCubeSpeed;
    
    /// <summary>
    /// ����������� ��������� ���������� ������.
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
    /// ������ ��������. ��������� ������� �����������, �������, ������� �������� ����. 
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
    /// ����� ���������, ���� �� � �������� ������� ������, � �������� Layer == Character (������ ����� ��������).
    /// ������ �����-�� ������...
    /// </summary>
    //private void Overlap()
    //{
    //    byte radius = 5;
    //    Collider[] colliders = Physics.OverlapSphere(transform.position, radius, layerMask);

    //    if (colliders.Length > 0) //��� ��� ���� Character �������� ������ ���� ������, �� �� ������������ ����� ������� � ������.
    //    {
    //        Debug.Log(colliders[0].name);
    //    }
    //}
}
