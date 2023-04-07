using UnityEngine;

public class NPC : MonoBehaviour
{
    public int Health;
    public int Level;
    public float Speed;

    // Start is called before the first frame update
    private void Start()
    {
        Health += Level;
        print(Health);
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += Speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
