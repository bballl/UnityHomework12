using System;
/// <summary>
/// Содержит делегат-наблюдатель.
/// </summary>
internal struct Observer
{
    /// <summary>
    /// Активируется в классе CharacterController, если в игре нажата кнопка активации (E).
    /// </summary>
    internal static Action ActivateButtonPressed;
}