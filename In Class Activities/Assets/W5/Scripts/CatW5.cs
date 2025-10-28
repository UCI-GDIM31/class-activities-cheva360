using UnityEngine;

public class CatW5 : MonoBehaviour
{
    [SerializeField] private bool _flipWSControls;
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;
    [SerializeField] private Animator _animator;

    private string _isWalkingName = "IsWalking";

    private void Update()
    {
        // STEP 1 & 2 ---------------------------------------------------------
        // STEP 1
        // This CatW5 class is a Component on the Cat GameObject. It controls
        //      the cat's movement.
        //
        // The Cat should move forwards and backwards with the W and S keys.
        //
        // Use the "static properties" listed under the Vector3 documentation:
        //  https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Vector3.html
        //
        // to change the value of the translation variable,
        // and then call Translate on this GameObject's transform to make it move
        // using translation, _moveSpeed, and Time.deltaTime.
        //
        // Ask yourself:
        //      Which axis moves the cat forwards and backwards?
        //      Which Vector3 static property would be useful here based on
        //          changing that axis?
        //      Should I modify translation with Vector addition, or multiplication,
        //          or both

        // translation variable for moving
        Vector3 move = Vector3.zero;

        Vector3 translation = Vector3.forward * (Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime);

        // flip logic
        if (_flipWSControls)
        {
            translation *= -1;
        }

        // translate position (depends on flip logic because its after)
        transform.Translate(translation);


        // STEP 2
        // After Step 1 is working, add more code to make it possible to flip
        //      the player's control scheme.
        // The _flipWSControls member variable, which we can change in the Inspector,
        //      determines if our controls should be flipped.
        // If _flipWSControls is true, interpret the value of translation as the
        //      OPPOSITE value, so that W moves the player backwards and S moves
        //      them forwards.
        //
        // MULTIPLY one of your vectors with a certain value to do this. >:)


        // resets the move variable if not moving for animation purposes
        


        // STEP 1 & 2 ---------------------------------------------------------

        float rotation = Input.GetAxis("Horizontal") * _turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        if (translation.magnitude != 0.0f || rotation != 0.0f)
        {
            _animator.SetBool(_isWalkingName, true);
        }
        else
        {
            _animator.SetBool(_isWalkingName, false);
        }
    }
}
