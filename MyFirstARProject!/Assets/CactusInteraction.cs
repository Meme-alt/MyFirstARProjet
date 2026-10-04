using UnityEngine;

public class CactusInteraction : MonoBehaviour
{
    public Transform cactus1;
    public Transform cactus2;
    public Animator anim1;
    public Animator anim2;
    public float minDistance = 0.25f;
    private bool isAttacking = false;
    void Update()
    {
        bool InRange = inRange(minDistance, cactus1.position, cactus2.position);
        if (InRange && !isAttacking)
        {
            anim1.SetTrigger("Attack");
            anim2.SetTrigger("Attack");
            isAttacking = true;
        }
        else if (!InRange)
        {
            isAttacking = false;
        }
    }
    bool inRange(float range, Vector3 v1, Vector3 v2)
    {
        float dx = v1.x - v2.x;
        float dy = v1.y - v2.y;
        float dz = v1.z - v2.z;
        return (dx * dx + dy * dy + dz * dz) < (range * range);
    }
}