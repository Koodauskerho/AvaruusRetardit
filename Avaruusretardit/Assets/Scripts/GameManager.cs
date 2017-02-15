using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void ApplyGravity(Rigidbody A, Rigidbody B)
    {
        // This is how to get the distance vector between two objects.
        Vector3 dist = B.transform.position - A.transform.position;
        float r = dist.magnitude;
        dist /= r;

        // This is the Newton's equation
        // G = 6.67 * 10^-11 N.m².kg^-2
        double G = 6.674f * (10 ^ 11);
        float force = ((float) G * A.mass * B.mass) / (r * r);

        // Then, just apply the forces
        A.AddForce(dist * force);
        B.AddForce(-dist * force);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get every object 
        GameObject[] planets = GameObject.FindGameObjectsWithTag("Planet");

        // The gravity between each couple of object is calculated
        foreach (GameObject planetA in planets)
        {
            foreach (GameObject planetB in planets)
            {
                // Objects must not self interact 
                if (planetA == planetB)
                    continue;

                ApplyGravity(planetA.GetComponent<Rigidbody>(), planetB.GetComponent<Rigidbody>());
            }

        }
    }
}
