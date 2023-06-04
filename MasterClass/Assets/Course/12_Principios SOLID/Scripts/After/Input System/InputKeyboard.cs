using UnityEngine;

namespace Course.SOLID.After
{
    public class InputKeyboard : InputHandler
    {
        public override float GetAxistHorizontal()
        {
            return Input.GetAxis("Horizontal");
        }
    }
}