using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    private void Awake()
    {
        IInput input = new DesktopInput();
        MovementHandler movementHandler = new MovementHandler(input);
        
        // дальше прокидываем куда то movementHandler сли надо, например игроку
        // все зависит от реализации логики
    }
}
