using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Text/Show Dialogue")]
public class ShowDialogueAction : ClickAction
{
    [TextArea] public string message;

    public override void Execute(GameObject target, GameObject actor)
      {
        MessageBox.Instance.Show(message);
        // Debug.Log("Attemtping to show message");
      }
}
