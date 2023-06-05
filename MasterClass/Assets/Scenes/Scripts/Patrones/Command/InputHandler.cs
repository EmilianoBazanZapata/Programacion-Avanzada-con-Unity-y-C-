using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Command
{
    public class InputHandler : MonoBehaviour
    {
        public Transform objectToMove;
        [Space]
        public KeyCode moveExcecute = KeyCode.E;
        public KeyCode moveUndo = KeyCode.U;
        public KeyCode moveLeft = KeyCode.LeftArrow;
        public KeyCode moveRight = KeyCode.RightArrow;
        public KeyCode moveUp = KeyCode.UpArrow;
        public KeyCode moveDown = KeyCode.DownArrow;

        private List<ICommand> _commandList = new List<ICommand>();

        private void Update()
        {
            if (Input.GetKeyDown(moveExcecute)) MoveExecute();
            if (Input.GetKeyDown(moveUndo)) MoveUndo();

            if (Input.GetKeyDown(moveLeft)) MoveWrite(Vector3.left);
            if (Input.GetKeyDown(moveRight)) MoveWrite(Vector3.right);
            if (Input.GetKeyDown(moveUp)) MoveWrite(Vector3.up);
            if (Input.GetKeyDown(moveDown)) MoveWrite(Vector3.down);
        }

        private void MoveWrite(Vector3 direction)
        {
            ICommand move = new Move(objectToMove, direction);
            _commandList.Add(move);
        }

        private void MoveExecute()
        {
            StartCoroutine(MoveForward());
        }

        private void MoveUndo()
        {
            StartCoroutine(MoveBackward());
        }

        private IEnumerator MoveForward()
        {
            for (int i = 0; i < _commandList.Count; i++)
            {
                _commandList[i].Execute();
                yield return new WaitForSeconds(0.25f);
            }
        }

        private IEnumerator MoveBackward()
        {
            for (int i = _commandList.Count - 1; i >= 0; i--)
            {
                _commandList[i].Undo();
                yield return new WaitForSeconds(0.25f);
            }
        }
    }
}